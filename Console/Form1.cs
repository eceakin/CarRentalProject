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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Console
{
    public partial class Form1 : Form
    {
      /*  private ICarManager carManager;
        private IRentalManager rentalManager;
        
        private IRentalDal rentalDal;
        private ICarDal carDal;*/
        public Form1()
        {
            InitializeComponent();
            _rentalManager = new RentalManager(rentalDal);
            listingManager = new ListingManager(listingDal);


           /* carDal = new CarDal();  // Örnek olarak CarDal'ı kullanıyoruz
            rentalDal = new RentalDal();  // Örnek olarak RentalDal'ı kullanıyoruz

            // CarManager nesnesini oluşturuyoruz
            carManager = new CarManager(carDal);  // ICarDal ve IRentalDal'ı CarManager'a inject ediyoruz
            rentalManager = new RentalManager(rentalDal);*/
        }

        private IRentalDal rentalDal;
        private IListingDal listingDal;
        private IRentalManager _rentalManager;
        private IListingManager listingManager;
        private void Form1_Load(object sender, EventArgs e)
        {
            ListOfRentals();
            ListOfCars();

        }

        private void ListOfRentals()
        {
            using (AppDbContext context = new AppDbContext())
            {
                dgwFilter.DataSource = context.Rentals.ToList();

            }
        }
        private void ListOfCars()
        {
            using (AppDbContext context = new AppDbContext())
            {
                cbxModel.DataSource = context.Cars.ToList();
                cbxModel.DisplayMember = "Model";

            }
        }
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
