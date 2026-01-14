using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stok_takip
{
    public partial class AnaForm : Form
    {

        string _kullaniciRolu;

        
        public AnaForm(string rol)
        {
            InitializeComponent();
            _kullaniciRolu = rol;
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            
            btnUrunYonetimi.Visible = true;
            btnMusteriYonetimi.Visible = true;
            btnSatisYap.Visible = true;
            btnRaporlar.Visible = true;

            
            if (_kullaniciRolu == "Satış Personeli" || _kullaniciRolu == "satis")
            {
                
                btnUrunYonetimi.Visible = false;


                btnRaporlar.Visible = false;

                
            }

            
            else if (_kullaniciRolu == "Depo Görevlisi" || _kullaniciRolu == "depo")
            {
                
                btnSatisYap.Visible = false;


                btnMusteriYonetimi.Visible = false;

                
                btnRaporlar.Visible = false;

                
            }
        }

        

        private void btnUrunYonetimi_Click(object sender, EventArgs e)
        {
            ProductForm urunForm = new ProductForm();
            urunForm.ShowDialog(); 
        }

        private void btnMusteriYonetimi_Click(object sender, EventArgs e)
        {
            CustomerForm musteri = new CustomerForm();
            musteri.ShowDialog();
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            SalesForm satis = new SalesForm();
            satis.ShowDialog();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            RaporForm raporEkrani = new RaporForm();
            raporEkrani.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 loginSayfasi = new Form1();
            loginSayfasi.Show();
            this.Close();
        }
    }
}