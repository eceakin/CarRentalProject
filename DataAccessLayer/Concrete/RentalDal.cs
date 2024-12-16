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
    public class RentalDal : IRentalDal
    {
        public Rental GetById(int id)
        {
            using (var context = new AppDbContext())
            {
                return context.Rentals.FirstOrDefault(r => r.RentalId == id);
            }
        }

        public List<Rental> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.Rentals.ToList();
            }
        }

        public void Add(Rental rental)
        {
            using (var context = new AppDbContext())
            {
                context.Rentals.Add(rental);
                context.SaveChanges();
            }
        }

        public void Update(Rental rental)
        {
            using (var context = new AppDbContext())
            {
                var existingRental = context.Rentals.FirstOrDefault(r => r.RentalId == rental.RentalId);
                if (existingRental != null)
                {
                    existingRental.CarId = rental.CarId;
                    existingRental.UserId = rental.UserId;
                    existingRental.StartDate = rental.StartDate;
                    existingRental.EndDate = rental.EndDate;

                    context.SaveChanges();
                }
            }
        }

        public void Delete(Rental rental)
        {
            using (var context = new AppDbContext())
            {
                var rentalToDelete = context.Rentals.FirstOrDefault(r => r.RentalId == rental.RentalId);
                if (rentalToDelete != null)
                {
                    context.Rentals.Remove(rentalToDelete);
                    context.SaveChanges();
                }
            }
        }

        // Rental'a özgü metotlar
        public List<Rental> GetRentalsByCarId(int carId)
        {
            using (var context = new AppDbContext())
            {
                return context.Rentals.Where(r => r.CarId == carId).ToList();
            }
        }

        public List<Rental> GetRentalsByCustomerId(int userId)
        {
            using (var context = new AppDbContext())
            {
                return context.Rentals.Where(r => r.UserId == userId).ToList();
            }
        }

        public List<Rental> GetAvailableCars()
        {
            using (var context = new AppDbContext())
            {
                return context.Rentals.Where(r => r.EndDate == null).ToList();
            }
        }

        public List<object> GetRentalsWithCarModels()
        {
            using (AppDbContext context = new AppDbContext())
            {
                var rentalsWithCars = from rental in context.Rentals
                                      join car in context.Cars
                                      on rental.CarId equals car.CarId
                                      select new
                                      {
                                          RentalId = rental.RentalId,
                                          Model = car.Model, // Araç modeli
                                          UserId = rental.UserId,
                                          StartDate = rental.StartDate,
                                          EndDate = rental.EndDate
                                      };

                return rentalsWithCars.ToList<object>();
            }
        }
    }
}
