using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRentalDal
    {
        Rental GetById(int id);
        List<Rental> GetAll();
        void Add(Rental rental);
        void Update(Rental rental);
        void Delete(Rental rental);

        // Rental'a özgü metotlar
        List<Rental> GetRentalsByCarId(int carId);
        List<Rental> GetRentalsByCustomerId(int userId);
        List<Rental> GetAvailableCars();
        List<object> GetRentalsWithCarModels()
           ;
    }
}
