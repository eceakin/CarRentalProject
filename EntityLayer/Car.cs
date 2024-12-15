using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Car
    {
        public Car()
        {
        }

        public Car(int carId, string model, int price, bool isAvailable)
        {
            CarId = carId;
            Model = model;
            Price = price;
            this.isAvailable = isAvailable;
        }

        public int CarId { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public bool isAvailable { get; set; }
    }
}
