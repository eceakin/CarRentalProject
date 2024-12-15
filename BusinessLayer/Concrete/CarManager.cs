using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CarManager:ICarManager
    {
        private readonly ICarDal _carDal;
        private readonly IRentalDal _rentalDal;

        // Constructor dependency injection (ICarDal bağımlılığını alıyoruz)
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        // Tüm araçları getir
        public List<Car> GetAllCars()
        {
            return _carDal.GetAll();
        }

        // Araba ekle
        public void AddCar(Car car)
        {
            // İş mantığı eklenebilir (örneğin, fiyat kontrolü, model kontrolü vb.)
            if (car.Price <= 0)
            {
                throw new Exception("Araba fiyatı sıfırdan büyük olmalıdır.");
            }

            _carDal.Add(car);
        }

        // Araba güncelle
        public void UpdateCar(Car car)
        {
            // İş mantığı eklenebilir
            var existingCar = _carDal.GetById(car.CarId);
            if (existingCar == null)
            {
                throw new Exception("Güncellenecek araba bulunamadı.");
            }

            _carDal.Update(car);
        }

        // Araba sil
        public void DeleteCar(int carId)
        {
            var carToDelete = _carDal.GetById(carId);
            if (carToDelete == null)
            {
                throw new Exception("Silinecek araba bulunamadı.");
            }

            _carDal.Delete(carToDelete);
        }

        // Kiralanabilir araçları getir
        public List<Car> GetAvailableCars()
        {
            return _carDal.GetAvailableCars();
        }

        public List<Car> FilterCars(string model, decimal minPrice, decimal maxPrice, DateTime startDate, DateTime endDate)
        {
            var cars = _carDal.GetAll();  // Tüm araçları alıyoruz

            // Model filtresi
            if (!string.IsNullOrEmpty(model))
            {
                cars = cars.Where(c => c.Model.Contains(model)).ToList();
            }

            // Fiyat filtresi
            cars = cars.Where(c => c.Price >= minPrice && c.Price <= maxPrice).ToList();

            // Kiralama tarih filtresi
            cars = cars.Where(c =>
            {
                var rentals = _rentalDal.GetRentalsByCarId(c.CarId);
                return rentals != null && !rentals.Any(r => r.StartDate >= startDate && r.EndDate <= endDate);
            }).ToList();

            return cars;
        }
    }
}
