using stok_takip.BLL;       
using stok_takip.DAL;
using stok_takip.DAL.Modeller; 
using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace stok_takip
{
    public partial class SalesForm : Form
    {
        
        musteriBLL _musteriBll = new musteriBLL();
        UrunBLL _urunBll = new UrunBLL();
        SatisBLL _satisBll = new SatisBLL();

        public SalesForm()
        {
            InitializeComponent();
            GridDoldur();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            FormYukle();
        }

        private void FormYukle()
        {
            
            cmbMusteriler.DataSource = _musteriBll.TumMusterileriGetir();
            cmbMusteriler.DisplayMember = "Ad"; 
            cmbMusteriler.ValueMember = "Id";   

            
            cmbUrunler.DataSource = _urunBll.TumUrunleriGetir();
            cmbUrunler.DisplayMember = "UrunAdi";
            cmbUrunler.ValueMember = "Id";

            
        }

        
        private void cmbUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbUrunler.SelectedItem != null)
            {
                
                Urun secilenUrun = (Urun)cmbUrunler.SelectedItem;
                lblFiyat.Text = secilenUrun.SatisFiyati.ToString() + " TL";
            }
        }
        private void GridDoldur()
        {
            
            dgvSatislar.DataSource = _satisBll.Listele();
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (cmbMusteriler.SelectedIndex == -1 || cmbUrunler.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen müşteri ve ürün seçiniz.");
                    return;
                }

                if (string.IsNullOrEmpty(txtAdet.Text))
                {
                    MessageBox.Show("Lütfen adet giriniz.");
                    return;
                }

                
                int musteriId = (int)cmbMusteriler.SelectedValue;
                int urunId = (int)cmbUrunler.SelectedValue;
                int adet = int.Parse(txtAdet.Text);

                Urun secilenUrun = (Urun)cmbUrunler.SelectedItem;
                decimal guncelFiyat = secilenUrun.SatisFiyati;

                
                _satisBll.SatisYap(musteriId, urunId, adet, guncelFiyat);

                MessageBox.Show("Satış Başarılı! Stok güncellendi.");

                
                GridDoldur();

                
                txtAdet.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


    }
}