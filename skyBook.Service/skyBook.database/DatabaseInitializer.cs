using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skyBook.database
{
    public class DatabaseInitializer
    {
        private static string connectionString = ConfigurationManager.AppSettings["conectionString"];

        public static void InitializeDatabase()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Crear tablas
                CreateUsersTable(connection);
                CreateReservationTable(connection);
                CreateTicketTable(connection);
                CreateFlyTable(connection);

                // Insertar datos de prueba
                InsertSampleData(connection);
            }
        }

        private static void CreateUsersTable(SQLiteConnection connection)
        {
            string createUsersTable = @"
        CREATE TABLE IF NOT EXISTS users (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            username TEXT NOT NULL,
            password TEXT NOT NULL
        );"
            ;

            using (var command = new SQLiteCommand(createUsersTable, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        private static void CreateReservationTable(SQLiteConnection connection)
        {
            string createReservationTable = @"
        CREATE TABLE IF NOT EXISTS reservation (
            idReservation INTEGER PRIMARY KEY AUTOINCREMENT,
            idUser INTEGER,
            FOREIGN KEY (idUser) REFERENCES users(id)
        );"
            ;

            using (var command = new SQLiteCommand(createReservationTable, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        private static void CreateTicketTable(SQLiteConnection connection)
        {
            string createTicketTable = @"
        CREATE TABLE IF NOT EXISTS ticket (
            idTicket INTEGER PRIMARY KEY AUTOINCREMENT,
            idFly INTEGER,
            idReservation INTEGER,
            FOREIGN KEY (idFly) REFERENCES fly(id),
            FOREIGN KEY (idReservation) REFERENCES reservation(idReservation)
        );"
            ;

            using (var command = new SQLiteCommand(createTicketTable, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        private static void CreateFlyTable(SQLiteConnection connection)
        {
            string createFlyTable = @"
        CREATE TABLE IF NOT EXISTS fly (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            date DATETIME NOT NULL,
            departure TEXT NOT NULL,
            destination TEXT NOT NULL
        );"
            ;

            using (var command = new SQLiteCommand(createFlyTable, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        private static void InsertSampleData(SQLiteConnection connection)
        {
            // Insertar usuario de prueba
            string insertUser = "INSERT INTO users (username, password) VALUES ('testuser', 'password123');";
            using (var command = new SQLiteCommand(insertUser, connection))
            {
                command.ExecuteNonQuery();
            }

            // Insertar vuelos de prueba
            string[] insertFlyCommands = {
        "INSERT INTO fly (date, departure, destination) VALUES ('2024-09-30 10:00:00', 'New York', 'Los Angeles');",
        "INSERT INTO fly (date, departure, destination) VALUES ('2024-10-05 14:30:00', 'San Francisco', 'Chicago');",
        "INSERT INTO fly (date, departure, destination) VALUES ('2024-10-07 18:45:00', 'Miami', 'Houston');",
        "INSERT INTO fly (date, departure, destination) VALUES ('2024-10-12 09:15:00', 'Boston', 'Dallas');",
        "INSERT INTO fly (date, departure, destination) VALUES ('2024-10-15 22:00:00', 'Seattle', 'Denver');",
        "INSERT INTO fly (date, departure, destination) VALUES ('2024-10-20 06:00:00', 'Las Vegas', 'Atlanta');",
        "INSERT INTO fly (date, departure, destination) VALUES ('2024-10-25 12:00:00', 'Orlando', 'Newark');"
    };

            foreach (var insertFly in insertFlyCommands)
            {
                using (var command = new SQLiteCommand(insertFly, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            Console.WriteLine("Datos de prueba insertados.");
        }
    }
}
