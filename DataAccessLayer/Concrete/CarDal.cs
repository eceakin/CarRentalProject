using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class CarDal : ICarDal
    {
        public Car GetById(int id)
        {
            using (var context = new AppDbContext())
            {
                return context.Cars.FirstOrDefault(c => c.CarId == id);
            }
        }

        public List<Car> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.Cars.ToList();
            }
        }

        public void Add(Car car)
        {
            using (var context = new AppDbContext())
            {
                context.Cars.Add(car);
                context.SaveChanges();
            }
        }

        public void Update(Car car)
        {
            using (var context = new AppDbContext())
            {
                var existingCar = context.Cars.FirstOrDefault(c => c.CarId == car.CarId);
                if (existingCar != null)
                {
                    existingCar.Model = car.Model;
                    existingCar.Price = car.Price;
                

                    context.SaveChanges();
                }
            }
        }

        public void Delete(Car car)
        {
            using (var context = new AppDbContext())
            {
                var carToDelete = context.Cars.FirstOrDefault(c => c.CarId == car.CarId);
                if (carToDelete != null)
                {
                    context.Cars.Remove(carToDelete);
                    context.SaveChanges();
                }
            }
        }

        // Araba'ya özgü metot
        public List<Car> GetAvailableCars()
        {
            using (var context = new AppDbContext())
            {
                //  return context.Cars.Where(c => c.isAvailable).ToList();

                DateTime today = DateTime.Now;

                // Hala kirada olan araçları hariç tut
                var unavailableCarIds = context.Rentals
                    .Where(r => r.EndDate >= today)
                    .Select(r => r.CarId)
                    .Distinct()
                    .ToList();

                // Kiralanabilir olan araçlar
                return context.Cars
                    .Where(c => c.isAvailable && !unavailableCarIds.Contains(c.CarId))
                    .ToList();
            }
        }
    }
}
