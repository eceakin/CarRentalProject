using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Console
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



            /* carDal = new CarDal();  // Örnek olarak CarDal'ı kullanıyoruz
             rentalDal = new RentalDal();  // Örnek olarak RentalDal'ı kullanıyoruz

             // CarManager nesnesini oluşturuyoruz
             carManager = new CarManager(carDal);  // ICarDal ve IRentalDal'ı CarManager'a inject ediyoruz
             rentalManager = new RentalManager(rentalDal);*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TimerFunc();
            ListOfRentals();
            ListOfCars();
        }


        // Timer  // Her 30 saniyede bir tarihi kontrol ediyor . 
        private void TimerFunc()
        {
            Timer timer = new Timer();
            timer.Interval = 10000; // Her 10 saniyede bir kontrol
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
                // Bugünkü tarihi al
                DateTime today = DateTime.Now;

                // Kiralama bitiş tarihi geçmiş olan araçları bul
                var rentals = context.Rentals
                    .Where(r => r.EndDate < today)
                    .ToList();

                foreach (var rental in rentals)
                {
                    // Aracın durumunu güncelle
                    var car = context.Cars.FirstOrDefault(c => c.CarId == rental.CarId);
                    if (car != null && !car.isAvailable)
                    {
                        car.isAvailable = true; // Aracı tekrar kiralanabilir yap
                    }

                    // Gerekirse kiralama kaydını da silebilirsin
                    // context.Rentals.Remove(rental);
                }

                // Değişiklikleri kaydet
                context.SaveChanges();
            }

            // Listeyi yenile

        }

        // TİMER BİTİŞ 



        // DGW LİSTELERİ 
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
                /* var carModels = context.Rentals
                    .Select(c => c.CarId)
                    .Distinct()
                    .ToList(); */
                // cbxRental.DataSource = carModels;


            }
            RentalManager rentalManager = new RentalManager(new RentalDal());
            //dgwRentals.DataSource = rentalManager.GetAllRentals();
            // dgwRentals.Columns["RentalId"].Visible = false;
            //dgwRentals.Columns["UserId"].Visible = false;

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
                cbxCar.DataSource = carModels;
            }

            // Kiralanabilir araçları listeleyelim
            CarManager _carManager = new CarManager(new CarDal());
            dgwFilter.DataSource = _carManager.GetAvailableCars();

            dgwFilter.Columns["isAvailable"].Visible = false;
        }


        // FİLTRELER 
        private void cbxCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedModel = cbxCar.SelectedItem.ToString();  // Seçilen model

            // Seçilen modele göre araçları filtreliyoruz
            ListCarsByModel(selectedModel);
        }
        private void ListCarsByModel(string model)
        {
            using (AppDbContext context = new AppDbContext())
            {
                // Seçilen modele göre araçları filtreliyoruz
                var cars = context.Cars
                    .Where(c => c.Model == model && c.isAvailable == true)  // Kiralanabilir araçlar
                    .ToList();

                dgwFilter.DataSource = cars;
            }
        }
        private void ListCars(string modelKey, int? minPriceKey, int? maxPriceKey)
        {
            using (AppDbContext context = new AppDbContext())
            {
                // Tüm araçlar ile başlıyoruz
                var query = context.Cars.AsQueryable();

                // Model adına göre filtreleme
                if (!string.IsNullOrEmpty(modelKey))
                {
                    query = query.Where(c => c.Model.Contains(modelKey));
                }

                // Min ve Max fiyatına göre filtreleme
                if (minPriceKey.HasValue)
                {
                    query = query.Where(c => c.Price >= minPriceKey.Value); // Min fiyat
                }

                if (maxPriceKey.HasValue)
                {
                    query = query.Where(c => c.Price <= maxPriceKey.Value); // Max fiyat
                }

                // Sadece kiralanabilir araçlar
                query = query.Where(c => c.isAvailable == true);

                // Sonuçları alıyoruz
                var cars = query.ToList();

                // Datagrid'e bind ediyoruz
                dgwFilter.DataSource = cars;
            }





        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {  // Kullanıcı model adı ve fiyat aralığını girdiğinde filtreleme yapacağız
            int? minPrice = string.IsNullOrEmpty(txtMinPrice.Text) ? (int?)null : Convert.ToInt32(txtMinPrice.Text); // Min fiyat
            int? maxPrice = string.IsNullOrEmpty(txtMaxPrice.Text) ? (int?)null : Convert.ToInt32(txtMaxPrice.Text); // Max fiyat

            // ListCars metodunu çağırıyoruz (model adı, min ve max fiyat ile)
            ListCars(txtName.Text, minPrice, maxPrice);
        }
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            int? minPrice = string.IsNullOrEmpty(txtMinPrice.Text) ? (int?)null : Convert.ToInt32(txtMinPrice.Text); // Min fiyat
            int? maxPrice = string.IsNullOrEmpty(txtMaxPrice.Text) ? (int?)null : Convert.ToInt32(txtMaxPrice.Text); // Max fiyat

            // ListCars metodunu çağırıyoruz (model adı, min ve max fiyat ile)
            ListCars(txtName.Text, minPrice, maxPrice);
        }

        private void goToRentalFormBtn_Click(object sender, EventArgs e)
        {
            var rentalForm = new RentalForm();
            rentalForm.Show();
            this.Hide();
        }

        private void goToAddCarFormBtn_Click(object sender, EventArgs e)
        {
            var addCarForm = new AddCarForm();
            addCarForm.Show();
            this.Hide();
        }

        private void txtMaxPrice_TextChanged(object sender, EventArgs e)
        {
            int? minPrice = string.IsNullOrEmpty(txtMinPrice.Text) ? (int?)null : Convert.ToInt32(txtMinPrice.Text); // Min fiyat
            int? maxPrice = string.IsNullOrEmpty(txtMaxPrice.Text) ? (int?)null : Convert.ToInt32(txtMaxPrice.Text); // Max fiyat

            // ListCars metodunu çağırıyoruz (model adı, min ve max fiyat ile)
            ListCars(txtName.Text, minPrice, maxPrice);
        }

    }
}