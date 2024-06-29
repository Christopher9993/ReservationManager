using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManager
{
    public class Reservation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
    }
}
