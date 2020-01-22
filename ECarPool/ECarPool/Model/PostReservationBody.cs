using System;

namespace ECarPool.Model
{
    public class PostReservationBody
    {
        public int CarId { get; set; }

        public String EmployeeName { get; set; }

        public DateTime day { get; set; }
    }
}
