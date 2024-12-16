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
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
            ListOfCars();
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

        private void AddCarForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }
    }
}
