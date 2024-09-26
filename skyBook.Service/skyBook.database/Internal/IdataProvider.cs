using skyBook.Entiti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skyBook.database.Internal
{
    public interface IdataProvider
    {
        User validateUserConection(string username, string password);
        long CreateReservation(int idUser, List<Ticket> tickets);
        void DeleteReservation(int idReservation);
        void UpdateReservation(int idReservation, List<Ticket> tickets);
        List<Reservation> GetReservations(int idUser);
        List<Fligth> GetAllFlights();
        FligthDetail GetFlightById(int id);
    }
}
