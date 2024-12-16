using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class RentalManager:IRentalManager
    {
        private readonly IRentalDal _rentalDal;

        // Constructor dependency injection (IRentalDal bağımlılığını alıyoruz)
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        // Tüm kiralamaları getir
        public List<Rental> GetAllRentals()
        {
            return _rentalDal.GetAll();
        }

        // Bir kiralama ekle
        public void AddRental(Rental rental)
        {
            // İş mantığı eklenebilir (örneğin, araba mevcut mu kontrolü vb.)
            var car = _rentalDal.GetRentalsByCarId(rental.CarId);
            if (car != null && car.Count > 0)
            {
                throw new Exception("Bu araba zaten kiralanmış.");
            }

            _rentalDal.Add(rental);
        }

        // Bir kiralamayı güncelle
        public void UpdateRental(Rental rental)
        {
            // İş mantığı eklenebilir
            var existingRental = _rentalDal.GetById(rental.RentalId);
            if (existingRental == null)
            {
                throw new Exception("Güncellenecek kiralama bulunamadı.");
            }

            _rentalDal.Update(rental);
        }

        // Bir kiralamayı sil
        public void DeleteRental(int rentalId)
        {
            var rentalToDelete = _rentalDal.GetById(rentalId);
            if (rentalToDelete == null)
            {
                throw new Exception("Silinecek kiralama bulunamadı.");
            }

            _rentalDal.Delete(rentalToDelete);
        }

        // Müşteriye ait kiralamaları getir
        public List<Rental> GetRentalsByCustomerId(int customerId)
        {
            return _rentalDal.GetRentalsByCustomerId(customerId);
        }

        // Kiralanabilir araçları getir
        public List<Rental> GetAvailableRentals()
        {
            return _rentalDal.GetAvailableCars();
        }

        public List<object> GetRentalsWithCarModels()
        {
            return _rentalDal.GetRentalsWithCarModels();
        }
    }
}
