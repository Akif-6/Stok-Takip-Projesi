using stok_takip.BLL;
using stok_takip.DAL.Modeller;
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
    public partial class ProductForm : Form
    {
        UrunBLL _urunBll = new UrunBLL();

        public ProductForm()
        {
            InitializeComponent();
        }

        // Form Yüklendiğinde
        private void ProductForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        // Listeleme Metodu
        public void Listele()
        {
            dgvUrunler2.DataSource = _urunBll.TumUrunleriGetir();
        }

        // Tablodan Seçme (CellClick)
        private void dgvUrunler2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Seçilen satırdaki verileri kutulara doldur
                txtId.Text = dgvUrunler2.CurrentRow.Cells["Id"].Value.ToString();
                txtUrunAdi.Text = dgvUrunler2.CurrentRow.Cells["UrunAdi"].Value.ToString();
                txtStok.Text = dgvUrunler2.CurrentRow.Cells["StokMiktari"].Value.ToString();
                txtAlis.Text = dgvUrunler2.CurrentRow.Cells["AlisFiyati"].Value.ToString();
                txtSatis.Text = dgvUrunler2.CurrentRow.Cells["SatisFiyati"].Value.ToString();
                txtMinStok.Text = dgvUrunler2.CurrentRow.Cells["MinStokSeviyesi"].Value.ToString();
            }
        }

        // EKLEME BUTONU
        private void ekle_button_Click(object sender, EventArgs e)
        {
            try
            {
                Urun yeniUrun = new Urun
                {
                    UrunAdi = txtUrunAdi.Text,
                    StokMiktari = int.Parse(txtStok.Text),
                    AlisFiyati = decimal.Parse(txtAlis.Text),
                    SatisFiyati = decimal.Parse(txtSatis.Text),
                    MinStokSeviyesi = int.Parse(txtMinStok.Text)
                };

                _urunBll.UrunEkle(yeniUrun);
                MessageBox.Show("Ürün başarıyla eklendi!");

                Listele();
                Temizle(); // İşlem bitince kutuları temizle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme Hatası: " + ex.Message);
            }
        }

        // GÜNCELLEME BUTONU
        private void guncelle_button_Click(object sender, EventArgs e)
        {
            try
            {
                Urun guncelUrun = new Urun
                {
                    Id = int.Parse(txtId.Text),
                    UrunAdi = txtUrunAdi.Text,
                    StokMiktari = int.Parse(txtStok.Text),
                    AlisFiyati = decimal.Parse(txtAlis.Text),     // Eksik kısımları tamamladım
                    SatisFiyati = decimal.Parse(txtSatis.Text),   // Eksik kısımları tamamladım
                    MinStokSeviyesi = int.Parse(txtMinStok.Text)  // Eksik kısımları tamamladım
                };

                _urunBll.UrunGuncelle(guncelUrun);
                MessageBox.Show("Ürün Güncellendi!");

                Listele();
                Temizle(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme Hatası: " + ex.Message);
            }
        }

        // SİLME BUTONU
        private void sil_button_click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                try
                {
                    int id = int.Parse(txtId.Text);
                    _urunBll.UrunSil(id);
                    MessageBox.Show("Ürün başarıyla silindi.");

                    Listele();
                    Temizle(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: Lütfen silinecek ürünü tablodan seçin! " + ex.Message);
                }
            }
        }

        
        private void Temizle()
        {
            txtId.Clear();
            txtUrunAdi.Clear();
            txtStok.Clear();
            txtAlis.Clear();
            txtSatis.Clear();
            txtMinStok.Clear();

            
            txtUrunAdi.Focus();
        }
        
    }
}