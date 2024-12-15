using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Listing
    {
        public Listing()
        {
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public Listing(int ıd, string title, string description, decimal price)
        {
            Id = ıd;
            Title = title;
            Description = description;
            Price = price;
        }
    }
}

