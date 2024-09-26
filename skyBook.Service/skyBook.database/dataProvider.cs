using skyBook.database.Internal;
using skyBook.Entiti;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skyBook.database
{
    public class dataProvider : IdataProvider
    {
        private static string connectionString = ConfigurationManager.AppSettings["conectionString"];
        public User validateUserConection(string username, string password)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Modificar la consulta para devolver id y username si existe el usuario
                string query = "SELECT id, username FROM users WHERE username = @username AND password = @password;";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    using (var reader = command.ExecuteReader())
                    {
                        // Si se encuentra un registro, obtener los datos del usuario
                        if (reader.Read())
                        {
                            User user = new User
                            {
                                Id = reader.GetInt32(0),        // Leer el id
                                Username = reader.GetString(1)  // Leer el username
                            };
                            return user;
                        }
                        else
                        {
                            // Si no se encuentra el usuario, retornar null
                            return null;
                        }
                    }
                }
            }
        }

        public long CreateReservation(int idUser, List<Ticket> tickets)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Iniciar transacción para asegurar que tanto la reserva como los tickets se crean correctamente
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Paso 1: Crear la reserva
                        string insertReservation = "INSERT INTO reservation (idUser) VALUES (@idUser);";
                        using (var command = new SQLiteCommand(insertReservation, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@idUser", idUser);
                            command.ExecuteNonQuery();
                        }

                        // Obtener el id de la reserva recién creada
                        long idReservation = connection.LastInsertRowId;

                        // Paso 2: Insertar los tickets asociados a la reserva
                        string insertTicket = "INSERT INTO ticket (idFly, idReservation) VALUES (@idFly, @idReservation);";
                        foreach (var ticket in tickets)
                        {
                            using (var command = new SQLiteCommand(insertTicket, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@idFly", ticket.IdFly);
                                command.Parameters.AddWithValue("@idReservation", idReservation);
                                command.ExecuteNonQuery();
                            }
                        }

                        // Confirmar la transacción
                        transaction.Commit();

                        // Devolver el id de la reserva recién creada
                        return idReservation;
                    }
                    catch
                    {
                        // Si algo sale mal, revertir la transacción
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

    public void DeleteReservation(int idReservation)
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            // Eliminar tickets asociados
            string deleteTickets = "DELETE FROM ticket WHERE idReservation = @idReservation;";
            using (var command = new SQLiteCommand(deleteTickets, connection))
            {
                command.Parameters.AddWithValue("@idReservation", idReservation);
                command.ExecuteNonQuery();
            }

            // Eliminar reserva
            string deleteReservation = "DELETE FROM reservation WHERE idReservation = @idReservation;";
            using (var command = new SQLiteCommand(deleteReservation, connection))
            {
                command.Parameters.AddWithValue("@idReservation", idReservation);
                command.ExecuteNonQuery();
            }
        }
    }

    public void UpdateReservation(int idReservation, List<Ticket> tickets)
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            // Eliminar tickets existentes
            string deleteTickets = "DELETE FROM ticket WHERE idReservation = @idReservation;";
            using (var command = new SQLiteCommand(deleteTickets, connection))
            {
                command.Parameters.AddWithValue("@idReservation", idReservation);
                command.ExecuteNonQuery();
            }

            // Insertar nuevos tickets
            foreach (var ticket in tickets)
            {
                string insertTicket = "INSERT INTO ticket (idFly, idReservation) VALUES (@idFly, @idReservation);";
                using (var command = new SQLiteCommand(insertTicket, connection))
                {
                    command.Parameters.AddWithValue("@idFly", ticket.IdFly);
                    command.Parameters.AddWithValue("@idReservation", idReservation);
                    command.ExecuteNonQuery();
                }
            }
        }
    }

        public List<Reservation> GetReservations(int idUser)
        {
            var reservations = new List<Reservation>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Consulta para obtener todas las reservas del usuario
                string query = "SELECT idReservation, idUser FROM reservation WHERE idUser = @idUser;";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idUser", idUser);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var reservation = new Reservation
                            {
                                IdReservation = reader.GetInt32(0), // idReservation
                                IdUser = reader.GetInt32(1)        // idUser
                            };

                            // Obtener los tickets asociados a esta reserva
                            reservation.Tickets = GetTicketsByReservationId(connection, reservation.IdReservation);

                            reservations.Add(reservation);
                        }
                    }
                }
            }

            return reservations;
        }

        private List<Ticket> GetTicketsByReservationId(SQLiteConnection connection, int idReservation)
        {
            var tickets = new List<Ticket>();

            // Consulta para obtener todos los tickets relacionados con la reserva
            string query = "SELECT idTicket, idFly FROM ticket WHERE idReservation = @idReservation;";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idReservation", idReservation);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tickets.Add(new Ticket
                        {
                            IdFly = reader.GetInt32(1)     // idFly
                        });
                    }
                }
            }

            return tickets;
        }

        public List<Fligth> GetAllFlights()
        {
            List<Fligth> flights = new List<Fligth>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Consulta para obtener todos los vuelos
                string query = "SELECT id, date, departure, destination FROM fly;";
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Crear un objeto Fligth y asignar los valores de la base de datos
                            Fligth flight = new Fligth
                            {
                                Id = reader.GetInt32(0),
                                Date = reader.GetDateTime(1),
                                Departure = reader.GetString(2),
                                Destination = reader.GetString(3)
                            };

                            // Agregar el vuelo a la lista de vuelos
                            flights.Add(flight);
                        }
                    }
                }

                connection.Close();
            }

            return flights;
        }

        public FligthDetail GetFlightById(int id)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Consulta para obtener la información del vuelo con el id especificado
                string query = "SELECT id, date, departure, destination FROM fly WHERE id = @id;";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Crear un objeto Fligth con la información del vuelo
                            return new FligthDetail
                            {
                                Id = reader.GetInt32(0),            // id del vuelo
                                Date = reader.GetDateTime(1),       // fecha del vuelo
                                Departure = reader.GetString(2),    // lugar de salida
                                Destination = reader.GetString(3)   // lugar de destino
                            };
                        }
                        else
                        {
                            // Si no se encuentra el vuelo, retornar null
                            return null;
                        }
                    }
                }
            }
        }
    }
}
