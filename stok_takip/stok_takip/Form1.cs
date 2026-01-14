using stok_takip.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using stok_takip.BLL;

namespace stok_takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

         

private void btnGiris_Click(object sender, EventArgs e)
    {
       
        KullaniciBLL kullaniciBll = new KullaniciBLL();

        
        string rol = kullaniciBll.KontrolEt(txtKullaniciAdi.Text, txtSifre.Text);

        if (rol != null)
        {
            MessageBox.Show("Giriş Başarılı! Rolünüz: " + rol);
            AnaForm ana = new AnaForm(rol); 
            ana.Show();
            this.Hide(); 
        }
        else
        {
            MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
        }
    }

        
    }
}
