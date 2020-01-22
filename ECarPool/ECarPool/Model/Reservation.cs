using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECarPool.Model
{
    public class Reservation
    {
        public int Id { get; set; }

        [Required]
        public int CarId { get; set; }

        public Car Car { get; set; }

        [Required]
        public DateTime Day { get; set; }

        [Required]
        public String EmployeeName { get; set; }
    }
}
