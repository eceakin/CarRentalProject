using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Rental
    {
        public Rental()
        {
        }

        public Rental(int rentalId, int carId, int userId, DateTime startDate, DateTime endDate)
        {
            RentalId = rentalId;
            CarId = carId;
            UserId = userId;
            StartDate = startDate;
            EndDate = endDate;
        }

        public int RentalId { get; set; }

        public int CarId { get; set; }
        public int UserId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
