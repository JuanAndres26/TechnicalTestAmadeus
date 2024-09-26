using ReservationCrudService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skyBook.Unitest.Stubs
{
    public static class GetFlightResponseStub
    {
        public static getFlightResponse FligthDetail()
        {
            var data = new getFlightResponse() { getFlightResult = new FligthDetail() { Id = 1, Date = DateTime.Now, Departure = "Los Angeles", Destination = "new york" }  };
            return data;
        }
    }
}
