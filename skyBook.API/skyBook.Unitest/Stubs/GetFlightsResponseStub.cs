using ReservationCrudService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skyBook.Unitest.Stubs
{
    public static class GetFlightsResponseStub
    {
        public static getFlightsResponse Flights()
        {
            var flights = new List<Fligth>() { 
                new Fligth() { Id = 1, Date= DateTime.Now, Departure = "Los Angeles", Destination = "new york" },
                new Fligth() { Id = 1, Date= DateTime.Now, Departure = "Los Angeles", Destination = "new york" },
                new Fligth() { Id = 1, Date= DateTime.Now, Departure = "Los Angeles", Destination = "new york" },
                new Fligth() { Id = 1, Date= DateTime.Now, Departure = "Los Angeles", Destination = "new york" }
            };
            var data = new getFlightsResponse() { getFlightsResult = flights.ToArray() };
            return data;
        }
    }
}
