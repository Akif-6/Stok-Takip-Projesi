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
    public partial class RaporForm : Form
    {
        RaporBLL _raporBll = new RaporBLL();

        public RaporForm()
        {
            InitializeComponent();
        }


        private void btnKritik_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _raporBll.KritikStokListele();
            dataGridView1.BackgroundColor = System.Drawing.Color.GreenYellow;
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _raporBll.EnIyiMusterilerListele();
            dataGridView1.BackgroundColor = System.Drawing.Color.Aqua;
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _raporBll.EnCokSatanlarListele();
            
            dataGridView1.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
        }

        private void btnCiro_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _raporBll.CiroListele();
            dataGridView1.BackgroundColor = System.Drawing.Color.LightGreen;
        }

        private void RaporForm_Load(object sender, EventArgs e)
        {

        }

        

        private void btnKarZarar_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _raporBll.KarZararRaporu();
            dataGridView1.BackgroundColor = Color.Salmon;
        }

        private void btnAylikSatis_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _raporBll.AylikSatisRaporu();
            dataGridView1.BackgroundColor = Color.LightSkyBlue;
        }
    }
}

