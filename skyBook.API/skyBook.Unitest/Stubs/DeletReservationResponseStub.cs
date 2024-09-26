using ReservationCrudService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skyBook.Unitest.Stubs
{
    public static class DeletReservationResponseStub
    {
        public static deletReservationResponse response()
        {
            var data = new deletReservationResponse() { deletReservationResult =  true };
            return data;
        }
    }
}
