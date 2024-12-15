using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICarManager
    {
        List<Car> GetAllCars();
        void AddCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(int carId);

        // Araba'ya özgü işlemler
        List<Car> GetAvailableCars();
        List<Car> FilterCars(string model, decimal minPrice, decimal maxPrice, DateTime startDate, DateTime endDate);

    }
}
