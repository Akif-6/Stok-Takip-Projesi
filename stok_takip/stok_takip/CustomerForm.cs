using stok_takip.BLL; 
using stok_takip.DAL;
using stok_takip.DAL.Modeller; 
using System;
using System.Windows.Forms;

namespace stok_takip
{
    public partial class CustomerForm : Form
    {
        
        musteriBLL _musteriBll = new musteriBLL();

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void Temizle()
        {
            
            txtId.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelefon.Text = "";
            txtEposta.Text = "";

            
            cmbMusteriTuru.SelectedIndex = -1;
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        public void Listele()
        {
            
            dgvMusteriler.DataSource = _musteriBll.TumMusterileriGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = dgvMusteriler.Rows[e.RowIndex];

                
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtAd.Text = row.Cells["Ad"].Value.ToString();
                txtSoyad.Text = row.Cells["Soyad"].Value.ToString();
                cmbMusteriTuru.Text = row.Cells["MusteriTuru"].Value.ToString();

                
                txtTelefon.Text = row.Cells["Telefon"].Value != null ? row.Cells["Telefon"].Value.ToString() : "";
                txtEposta.Text = row.Cells["Eposta"].Value != null ? row.Cells["Eposta"].Value.ToString() : "";
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Musteri m = new Musteri();
                m.Id = int.Parse(txtId.Text); // Kimi güncelleyeceğimizi ID'den anlarız
                m.Ad = txtAd.Text;
                m.Soyad = txtSoyad.Text;
                m.MusteriTuru = cmbMusteriTuru.Text;
                m.Telefon = txtTelefon.Text;
                m.Eposta = txtEposta.Text;

                _musteriBll.MusteriGuncelle(m);
                MessageBox.Show("Müşteri bilgileri güncellendi.");
                Listele();
                Temizle(); // İşlem bitince kutuları boşalt
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                
                DialogResult cevap = MessageBox.Show("Bu müşteriyi silmek istediğine emin misin?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (cevap == DialogResult.Yes)
                {
                    int silinecekId = int.Parse(txtId.Text);
                    _musteriBll.MusteriSil(silinecekId);
                    MessageBox.Show("Müşteri silindi.");
                    Listele();
                    Temizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            try
            {
                Musteri yeni = new Musteri
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Telefon = txtTelefon.Text,
                    Eposta = txtEposta.Text,
                    MusteriTuru = cmbMusteriTuru.Text
                };

                _musteriBll.MusteriEkle(yeni);
                MessageBox.Show("Müşteri başarıyla kaydedildi.");
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}