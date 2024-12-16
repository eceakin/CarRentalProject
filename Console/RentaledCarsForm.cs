using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console
{
    public partial class RentaledCarsForm : Form
    {
        public RentaledCarsForm()
        {
            InitializeComponent();
        }

        private void RentaledCarsForm_Load(object sender, EventArgs e)
        {
            ListOfRentals();
        }
        private void ListOfRentals()
        {
            using (AppDbContext context = new AppDbContext())
            {
                var rentalsWithCars = from rental in context.Rentals
                                      join car in context.Cars
                                      on rental.CarId equals car.CarId
                                      select new
                                      {
                                          RentalId = rental.RentalId,
                                          Model = car.Model,
                                          UserId = rental.UserId,
                                          StartDate = rental.StartDate,
                                          EndDate = rental.EndDate
                                      };
       


            }
            RentalManager rentalManager = new RentalManager(new RentalDal());
            dgwRentals.DataSource = rentalManager.GetAllRentals();
            dgwRentals.Columns["RentalId"].Visible = false;
            dgwRentals.Columns["UserId"].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var RentalForm = new RentalForm();
            RentalForm.Show();
            this.Hide();
        }
    }
}
