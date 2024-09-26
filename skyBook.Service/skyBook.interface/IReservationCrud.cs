using skyBook.Entiti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace skyBook.@interface
{
    [ServiceContract]
    public interface IReservationCrud
    {
        [OperationContract]
        Reservation createReservation(int idUser, List<Ticket> tickets);
        [OperationContract]
        bool deletReservation(int idReservation);
        [OperationContract]
        Reservation updateReservation(int idReservation, List<Ticket> tickets);
        [OperationContract]
        List<Reservation> getReservation(int idUser);

        [OperationContract]
        List<Fligth> getFlights();

        [OperationContract]
        FligthDetail getFlight(int idFligth);
    }
}
