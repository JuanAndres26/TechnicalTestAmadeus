using ReservationCrudService;
using skyBook.Entiti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace skyBook.Interfaces
{
    public interface ICrudReservations
    {
        object GetFlights();

        object CreateReservation(RequestcreateReservation request);

        object DeletReservation(int idReservation);

        object UpdateReservation(RequestUpdateReservation request);

        object GetReservations(int idUser);

        object GetFlight(int idFligth);
    }
}
