using BusinessLayer.Concrete;
using DataAccessLayer;
using DataAccessLayer.Concrete;
using EntityLayer;
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
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
        }

        private void RentalForm_Load(object sender, EventArgs e)
        {
            ListOfCars();
        }

      /*  private void ListOfRentals()
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
                /* var carModels = context.Rentals
                    .Select(c => c.CarId)
                    .Distinct()
                    .ToList(); 
                // cbxRental.DataSource = carModels;


            }
            RentalManager rentalManager = new RentalManager(new RentalDal());
            dgwRentals.DataSource = rentalManager.GetAllRentals();
            dgwRentals.Columns["RentalId"].Visible = false;
            dgwRentals.Columns["UserId"].Visible = false;

        } */ 
        private void TimerFunc()
        {
            Timer timer = new Timer();
            timer.Interval = 10000; // Her 60 saniyede bir kontrol
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateCarAvailability();
        }

        private void UpdateCarAvailability()
        {
            using (AppDbContext context = new AppDbContext())
            {
                DateTime today = DateTime.Now;

                // Kiralama bitiş tarihi geçmiş olan araçların durumunu güncelle
                var rentals = context.Rentals
                    .Where(r => r.EndDate < today)
                    .ToList();

                foreach (var rental in rentals)
                {
                    var car = context.Cars.FirstOrDefault(c => c.CarId == rental.CarId);
                    if (car != null && !car.isAvailable)
                    {
                        car.isAvailable = true;
                    }
                }

                context.SaveChanges();
            }
            ListOfCars();
            // Listeyi yenile

        }


        private void ListOfCars()
        {
            /*  using (AppDbContext context = new AppDbContext())
              {
                  //cbxModel.DataSource = context.Cars.ToList();

                  CarManager _carManagger = new CarManager(new CarDal());
                  dgwFilter.DataSource = _carManagger.GetAvailableCars();

                  dgwFilter.Columns["isAvailable"].Visible = false;


              }*/

            using (AppDbContext context = new AppDbContext())
            {
                // Benzersiz araç modellerini alıyoruz
                var carModels = context.Cars
                    .Select(c => c.Model)
                    .Distinct()
                    .ToList();

                // ComboBox'ı model listesi ile dolduruyoruz
                 
            }

            // Kiralanabilir araçları listeleyelim
            CarManager _carManager = new CarManager(new CarDal());
            dgwFilter.DataSource = _carManager.GetAvailableCars();

            dgwFilter.Columns["isAvailable"].Visible = false;
        }
        private void RentCar(int carId, DateTime startDate, DateTime endDate)
        {
            if (startDate >= endDate)
            {
                MessageBox.Show("Başlangıç tarihi bitiş tarihinden önce olmalıdır.");
                return;
            }

            using (AppDbContext context = new AppDbContext())
            {
                var car = context.Cars.FirstOrDefault(c => c.CarId == carId);
                if (car != null && car.isAvailable)
                {
                    car.isAvailable = false;

                    var rental = new Rental
                    {
                        CarId = carId,
                        UserId = GetCurrentUserId(),
                        StartDate = startDate,
                        EndDate = endDate
                    };

                    context.Rentals.Add(rental);
                    context.SaveChanges();

                    MessageBox.Show("Araç başarıyla kiralandı.");
                }
                else
                {
                    MessageBox.Show("Bu araç zaten kiralanmış.");
                }
            }

            // Listeyi güncelle

            ListOfCars();
            //ListOfRentals();
        }
        private int GetCurrentUserId()
        {
            // Kullanıcı giriş sistemi varsa burada oturumdaki kullanıcı ID'sini alın
            // Örnek bir değer döndürüyorum:
            return 1; // Örneğin, 1 numaralı kullanıcı
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (dgwFilter.SelectedRows.Count > 0)
            {
                int selectedCarId = Convert.ToInt32(dgwFilter.SelectedRows[0].Cells["CarId"].Value);
                DateTime startDate = dtpStartDate.Value.Date;
                DateTime endDate = dtpEndDate.Value.Date;

                RentCar(selectedCarId, startDate, endDate); // Tarihlerle birlikte aracı kirala
            }
            else
            {
                MessageBox.Show("Lütfen bir araç seçin.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void goToRentaledForm_Click(object sender, EventArgs e)
        {
            var RentaledCarsForm = new RentaledCarsForm();
            RentaledCarsForm.Show();
            this.Hide();
        }

        /* private void btnRent_Click(object sender, EventArgs e)
         {
             if (dgwFilter.SelectedRows.Count > 0)
             {
                 int selectedCarId = Convert.ToInt32(dgwFilter.SelectedRows[0].Cells["CarId"].Value);
                 DateTime startDate = dtpStartDate.Value.Date;
                 DateTime endDate = dtpEndDate.Value.Date;

                 RentCar(selectedCarId, startDate, endDate); // Tarihlerle birlikte aracı kirala
             }
             else
             {
                 MessageBox.Show("Lütfen bir araç seçin.");
             }
         } */


    }
}
