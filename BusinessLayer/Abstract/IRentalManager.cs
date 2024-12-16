using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRentalManager
    {
        List<Rental> GetAllRentals();
        void AddRental(Rental rental);
        void UpdateRental(Rental rental);
        void DeleteRental(int rentalId);

        // Kiralama'ya özgü işlemler
        List<Rental> GetRentalsByCustomerId(int customerId);
        List<Rental> GetAvailableRentals();
        List<object> GetRentalsWithCarModels();
    }
}
