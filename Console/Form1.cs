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
            TimerFunc();
            ListOfRentals();
            ListOfCars();
        }


        // Timer  // Her 30 saniyede bir tarihi kontrol ediyor . 
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
            ListOfCars();
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
        private void ListCars(string modelKey, int? priceKey)
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

                // Fiyatına göre filtreleme
                if (priceKey.HasValue)
                {
                    query = query.Where(c => c.Price > priceKey.Value);
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
        {
            int? price = null;
            if (int.TryParse(txtPrice.Text, out int parsedPrice))
            {
                price = parsedPrice;
            }

            ListCars(txtName.Text, price);
        }
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            int? price = null;
            if (int.TryParse(txtPrice.Text, out int parsedPrice))
            {
                price = parsedPrice;
            }

            ListCars(txtName.Text, price);
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

        // FİLTRELER BİTİŞ 




        /*
                // KİRALAMA 
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

                // KİRALAMA BİTİŞ 
        */
        /*
                // İLAN EKLEME
                private void btnAddListing_Click(object sender, EventArgs e)
                {
                    if (string.IsNullOrWhiteSpace(txtAddModel.Text))
                    {
                        MessageBox.Show("Lütfen araba modeli giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!int.TryParse(txtAddPrice.Text, out int price) || price <= 0)
                    {
                        MessageBox.Show("Lütfen geçerli bir fiyat giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    try
                    {
                        // Formdan verileri al
                        string model = txtAddModel.Text;
                        bool isAvailable = chkIsAvailable.Checked;

                        // Fiyat girişini kontrol et ve dönüştür
                        if (!int.TryParse(txtAddPrice.Text, out int carPrice))
                        {
                            MessageBox.Show("Lütfen geçerli bir fiyat girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Yeni araba nesnesini oluştur
                        var newCar = new Car
                        {
                            Model = model,
                            Price = price,
                            isAvailable = isAvailable
                        };

                        // Veritabanına ekle
                        using (AppDbContext context = new AppDbContext())
                        {
                            context.Cars.Add(newCar);
                            context.SaveChanges();
                        }

                        // Kullanıcıya bilgi ver
                        MessageBox.Show("Araba başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Giriş alanlarını temizle
                        txtAddModel.Text = string.Empty;
                        txtAddPrice.Text = string.Empty;
                        chkIsAvailable.Checked = false;

                        // Güncel listeyi göster
                        ListOfCars();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // İLAN EKLEME BİTİŞ 
        */


    }
}






// bitiş 













        /* private void cbxRental_SelectedIndexChanged(object sender, EventArgs e)
          {
              if (cbxRental.SelectedValue != null)
              {
                  int selectedCarId = (int)cbxRental.SelectedValue;  // Seçilen aracın CarId'si

                  // Kiralamaları seçilen CarId'ye göre filtreliyoruz
                  ListRentalsByCarId(selectedCarId);
              }
          }

          private void ListRentalsByCarId(int carId)
          {
              using (AppDbContext context = new AppDbContext())
              {
                  var rentals = from rental in context.Rentals
                                join car in context.Cars
                                on rental.CarId equals car.CarId
                                where rental.CarId == carId
                                select new
                                {
                                    RentalId = rental.RentalId,
                                    Model = car.Model,
                                    UserId = rental.UserId,
                                    StartDate = rental.StartDate,
                                    EndDate = rental.EndDate
                                };

                  dgwRentals.DataSource = rentals.ToList();
                  dgwRentals.Columns["RentalId"].Visible = false;
                  dgwRentals.Columns["UserId"].Visible = false;
              }
          }
          private void ListOfCarsForRentals()
          {
              using (AppDbContext context = new AppDbContext())
              {
                  // Kiralanmış araçları buluyoruz
                  var rentedCars = context.Rentals
                                          .Join(context.Cars, rental => rental.CarId, car => car.CarId, (rental, car) => new { car.CarId, car.Model })
                                          .Distinct()
                                          .ToList();

                  // ComboBox'ı kiralanan araçların modelleri ile dolduruyoruz
                  cbxRental.DataSource = rentedCars;
                  cbxRental.DisplayMember = "Model";  // Görüntüleyeceğimiz özellik
                  cbxRental.ValueMember = "CarId";  // Seçilen aracın CarId'sini tutacağız
              }
          }*/
        /* Rental Listeleme

            private void ListRentalsByModel(string model)
        {
            using (AppDbContext context = new AppDbContext())
            {
                // Seçilen modele göre araçları filtreliyoruz
                var cars = context.Cars
                    .Where(c => c.Model == model)  // Kiralanabilir araçlar
                    .ToList();

                dgwRentals.DataSource = cars;
            }
        }
            private void cbxRental_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedModel = cbxRental.SelectedItem.ToString();
            ListRentalsByModel(selectedModel);

        } */


        /* Filreler 
         *  private void txtName_TextChanged(object sender, EventArgs e)
        {
            ListCarsByModelName(txtName.Text);
        }
        private void ListCarsByModelName(string key)
        {
            using (AppDbContext context = new AppDbContext())
            {
                // Seçilen modele göre araçları filtreliyoruz
                var cars = context.Cars
                    .Where(c => c.Model.Contains(key) && c.isAvailable == true) // Kiralanabilir araçlar
                    .ToList();

                dgwFilter.DataSource = cars;
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtPrice.Text, out int price))
            {
                ListCarsByPrice(price);
            }

        }


        private void ListCarsByPrice(int key)
        {
            using (AppDbContext context = new AppDbContext())
            {
                // Seçilen modele göre araçları filtreliyoruz
                var cars = context.Cars
                    .Where(c => c.Price > key && c.isAvailable == true) // Kiralanabilir araçlar
                    .ToList();

                dgwFilter.DataSource = cars;
            }
        } */












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

