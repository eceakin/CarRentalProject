using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IListingManager
    {
        List<Listing> GetAll();
        Listing Get(int id);
        void Add(Listing listing);
        void Remove(Listing listing);
        void Update(Listing listing);
    }
}
