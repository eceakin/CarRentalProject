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
            ListOfRentals();
            ListOfCars();           
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

                RentalManager rentalManager = new RentalManager(new RentalDal());
                dgwRentals.DataSource = rentalManager.GetAllRentals();
                dgwRentals.Columns["RentalId"].Visible = false;
                dgwRentals.Columns["UserId"].Visible = false;

            }
        }

        
        private void ListOfCars()
        {
            using (AppDbContext context = new AppDbContext())
            {
                //cbxModel.DataSource = context.Cars.ToList();
               
                CarManager _carManagger = new CarManager(new CarDal());
                dgwFilter.DataSource = _carManagger.GetAvailableCars();
               
                dgwFilter.Columns["isAvailable"].Visible = false;


            }
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
                // Seçilen aracı kontrol et
                var car = context.Cars.FirstOrDefault(c => c.CarId == carId);
                if (car != null && car.isAvailable)
                {
                    car.isAvailable = false; // Artık kiralanabilir değil
                    context.SaveChanges();   // Değişiklikleri kaydet

                    // Yeni bir Rental kaydı oluştur
                    var rental = new Rental
                    {
                        CarId = carId,
                        UserId = GetCurrentUserId(), // Mevcut kullanıcı ID'sini alın
                        StartDate = startDate,
                        EndDate = endDate
                    };

                    context.Rentals.Add(rental);
                    context.SaveChanges(); // Değişiklikleri kaydet

                    MessageBox.Show("Araç başarıyla kiralandı.");
                }
                else
                {
                    MessageBox.Show("Bu araç zaten kiralanmış.");
                }
            }

            // Listeyi güncelle
           
            ListOfCars();
            ListOfRentals();
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








        /*
                private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
                {
                    try
                    {
                        ListOfCarsByModel(Convert.ToInt32(comboBox1.SelectedValue));
                    }
                    catch 
                    {


                    }
                }
                private void ListAvailableCars()
                {
                    using (AppDbContext context = new AppDbContext())
                    {
                        // Sadece isAvailable == true olan araçları listele
                        var availableCars = context.Cars.Where(c => c.isAvailable).ToList();

                        // DataGridView'e bu listeyi ata
                        dgwFilter.DataSource = availableCars;
                    }
                }
                private void cbxModel_SelectedIndexChanged(object sender, EventArgs e)
                {
                    try
                    {
                        ListRentalsByCarId(Convert.ToInt32(cbxModel.SelectedValue));
                    }
                    catch
                    {


                    }

                }
                private void ListOfCarsByModel(int carId)
                {
                    using (AppDbContext context = new AppDbContext())
                    {
                        //cbxModel.DataSource = context.Cars.ToList();
                        dgwFilter.DataSource = context.Cars.Where(p => p.CarId == carId).ToList();

                        //dgwFilter.Columns["isAvailable"].Visible = false;


                    }
                }
                private void ListRentalsByCarId(int carId)
                {
                    using (AppDbContext context = new AppDbContext())
                    {
                        dgwRentals.DataSource = context.Rentals.Where(p => p.CarId == carId).ToList();

                    }
                }
                /* private void ListRentalsByCarId(int carId)
                 {
                     using (AppDbContext context = new AppDbContext())
                     {
                         var rentalsWithCars = from rental in context.Rentals
                                               join car in context.Cars
                                               on rental.CarId equals car.CarId
                                               where car.CarId == carId
                                               select new
                                               {
                                                   RentalId = rental.RentalId,
                                                   Model = car.Model,
                                                   UserId = rental.UserId,
                                                   StartDate = rental.StartDate,
                                                   EndDate = rental.EndDate
                                               };

                         dgwRentals.DataSource = rentalsWithCars.ToList();
                         dgwRentals.Columns["RentalId"].Visible = false;
                         dgwRentals.Columns["UserId"].Visible = false;
                     }
                 }





                */











        /* private void button1_Click(object sender, EventArgs e)
          {
              try
              {
                  // Kullanıcıdan alınan verileri Rental nesnesine atama
                  Rental newRental = new Rental
                  {
                      CarId = Convert.ToInt32(txtCarId.Text),
                      StartDate = Convert.ToDateTime(txtStartDate.Text),
                      EndDate = string.IsNullOrEmpty(txtEndDate.Text) ? (DateTime?)null : Convert.ToDateTime(txtEndDate.Text)
                  };

                  // RentalManager üzerinden ekleme işlemi
                  RentalManager rentalManager = new RentalManager(new RentalDal());
                  rentalManager.AddRental(newRental);

                  // İşlem başarılıysa kullanıcıya bilgi verme ve listeyi güncelleme
                  MessageBox.Show("Rental başarıyla eklendi.");
                  ListOfRentals(); // DataGridView'deki listeyi güncelle
              }
              catch (Exception ex)
              {
                  MessageBox.Show($"Hata: {ex.Message}");
              }

          }*/
        /*  private void LoadListings()
{
IListingDal listingDal = new ListingDal();
ListingManager listingManager = new ListingManager(listingDal);

dataGridView1.DataSource = listingManager.GetAll(); 
}
add button
private void button1_Click(object sender, EventArgs e)
{
using (var context = new AppDbContext())
{
var listing = new Listing
{
Title = titleTxt.Text,
Description = descriptionTxt.Text,
Price = Convert.ToInt32(priceTxt.Text)
};
context.Listings.Add(listing);
context.SaveChanges();
}
LoadListings();

}

private void updateButton_Click(object sender, EventArgs e)
{
if (dataGridView1.CurrentRow != null)
{
int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
using (var context = new AppDbContext())
{
var listing = context.Listings.SingleOrDefault(x => x.Id == id);
if (listing != null)
{
listing.Title = titleTxtUp.Text;
listing.Description = descriptionTxtUp.Text;
listing.Price = Convert.ToInt32(priceTxtUp.Text);
context.SaveChanges();
}
}
LoadListings(); // Listeyi yenile
}
}
*/
        /*private void ListCarModelCBX()
           {
               using (AppDbContext context = new AppDbContext())
               {
                   // Tüm araçları alıyoruz ve Model sütununda benzersiz olanları alıyoruz
                   var carModels = context.Cars
                       .Select(c => c.Model)
                       .Distinct()
                       .ToList();
                   comboBox1.DataSource = carModels;
                   comboBox1.DisplayMember = "Model";
                   comboBox1.ValueMember = "CarId";
               }
           }*/

        /* private void ListOfRentals()
         {
             using (AppDbContext context = new AppDbContext())
             {
                 dgwFilter.DataSource = context.Rentals.ToList();

             }
         }*/




        /*   private void btnFilter_Click(object sender, EventArgs e)
           {
               string selectedModel = cbCarModel.SelectedItem?.ToString();
               decimal minPrice = string.IsNullOrEmpty(txtMinPrice.Text) ? 0 : Convert.ToDecimal(txtMinPrice.Text);
               decimal maxPrice = string.IsNullOrEmpty(txtMaxPrice.Text) ? decimal.MaxValue : Convert.ToDecimal(txtMaxPrice.Text);
               DateTime startDate = dtpStartDate.Value;
               DateTime endDate = dtpEndDate.Value;

               // Filtrelenen araçları almak için CarManager'ı kullanıyoruz
               var filteredCars = carManager.FilterCars(selectedModel, minPrice, maxPrice, startDate, endDate);

               // DataGridView'de listeleme
               dgvAvailableCars.DataSource = filteredCars;

       }*/

        /* private void dgvAvailableCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
             if (e.ColumnIndex == dgvAvailableCars.Columns["btnRent"].Index)
             {
                 var selectedCar = (Car)dgvAvailableCars.Rows[e.RowIndex].DataBoundItem;

                 // Kiralama işlemi başlat
                 Rental rental = new Rental
                 {
                     CarId = selectedCar.CarId,
                   //  UserId = userId,  // Şu anda oturum açmış kullanıcı
                     StartDate    = DateTime.Now,
                     EndDate = null  // Henüz iade edilmedi
                 };

                 rentalManager.AddRental(rental); // RentalManager üzerinden kiralama işlemi yapıyoruz

                 MessageBox.Show("Araba başarıyla kiralandı!");
             }
         }
       private void AddRentButtonColumn()
         {
             DataGridViewButtonColumn rentButtonColumn = new DataGridViewButtonColumn();
             rentButtonColumn.Name = "btnRent";
             rentButtonColumn.Text = "Kirala";
             rentButtonColumn.UseColumnTextForButtonValue = true;
             dgvAvailableCars.Columns.Add(rentButtonColumn);
         }*/

    }
}
