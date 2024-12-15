using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class ListingDal : IListingDal
    {
        /*public List<Listing> GetAll()
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Listings.ToList();
            }

        }
        public Listing Get(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Listings.SingleOrDefault(p => p.Id == id);
            }

        }*/
        public void Add(Listing listing)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Listings.Add(listing);
                context.SaveChanges();
            }
        }

        public Listing Get(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Listings.SingleOrDefault(p => p.Id == id);
            }
        }

        public List<Listing> GetAll()
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Listings.ToList();
            }
        }

        public void Remove(Listing listing)
        {
           
                using (AppDbContext context = new AppDbContext())
                {
                    context.Listings.Remove(listing);
                    context.SaveChanges();
                }
            
        }

        public void Update(Listing listing)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var entity = context.Listings.SingleOrDefault(x => x.Id == listing.Id);
                if (entity != null)
                {
                    // İstediğiniz alanları güncelleyin
                    entity.Title = listing.Title;
                    entity.Description = listing.Description;
                    // Diğer alanlar için aynı işlemi yapabilirsiniz

                    context.SaveChanges();
                }
            }
        }
    }
}
