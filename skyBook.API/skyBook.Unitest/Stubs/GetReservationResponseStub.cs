using ReservationCrudService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skyBook.Unitest.Stubs
{
    public static class GetReservationResponseStub
    {
        public static getReservationResponse Reservations()
        {
            var tickets = new List<Ticket>() { new Ticket() { IdFly = 1 } };
            var reservations = new List<Reservation>() {
            new Reservation() { IdReservation = 1, IdUser = 1, Tickets = tickets.ToArray() },
            new Reservation() { IdReservation = 1, IdUser = 1, Tickets = tickets.ToArray() },
            new Reservation() { IdReservation = 1, IdUser = 1, Tickets = tickets.ToArray() },
            new Reservation() { IdReservation = 1, IdUser = 1, Tickets = tickets.ToArray() }
            };
            var data = new getReservationResponse() { getReservationResult = reservations.ToArray() };
            return data;
        }
    }
}
