using ReservationCrudService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using userManagmentService;

namespace skyBook.Unitest.Stubs
{
    public static class CreateReservationResponseStub
    {
        public static createReservationResponse Reservation()
        {
            var tickets = new List<Ticket>() { new Ticket() { IdFly = 1} };
            var data = new createReservationResponse() { createReservationResult = new Reservation() { IdReservation = 1, IdUser = 1, Tickets = tickets.ToArray() } };
            return data;
        }
    }
}
