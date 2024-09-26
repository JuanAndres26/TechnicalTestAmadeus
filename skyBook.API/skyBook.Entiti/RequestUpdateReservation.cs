using ReservationCrudService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skyBook.Entiti
{
    public class RequestUpdateReservation
    {
        public int IdReservation { get; set; }
        public List<Ticket>? Tickets { get; set; }
    }
}
