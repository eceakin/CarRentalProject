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
    public class ListingManager : IListingManager
    {
        private readonly IListingDal _listingDal;
        //dependency injection 
        public ListingManager(IListingDal listingDal)
        {
            _listingDal = listingDal;
        }

        public void Add(Listing listing)
        {
            _listingDal.Add(listing);
        }

        public Listing Get(int id)
        {
                throw new NotImplementedException();
        }

        public List<Listing> GetAll()
        {


            return _listingDal.GetAll();
        }

        public void Remove(Listing listing)
        {
            _listingDal.Remove(listing);
        }

        public void Update(Listing listing)
        {
            _listingDal.Update(listing);
        }
    }
}
