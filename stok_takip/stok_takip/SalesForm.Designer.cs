namespace stok_takip
{
    partial class SalesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbMusteriler = new System.Windows.Forms.ComboBox();
            this.cmbUrunler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.dgvSatislar = new System.Windows.Forms.DataGridView();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMusteriler
            // 
            this.cmbMusteriler.FormattingEnabled = true;
            this.cmbMusteriler.Location = new System.Drawing.Point(51, 12);
            this.cmbMusteriler.Name = "cmbMusteriler";
            this.cmbMusteriler.Size = new System.Drawing.Size(121, 24);
            this.cmbMusteriler.TabIndex = 0;
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(51, 105);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(121, 24);
            this.cmbUrunler.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürünler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Müşteriler";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(62, 179);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(100, 22);
            this.txtAdet.TabIndex = 4;
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.FlatAppearance.BorderSize = 0;
            this.btnSatisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisYap.Location = new System.Drawing.Point(322, 12);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(125, 189);
            this.btnSatisYap.TabIndex = 6;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // dgvSatislar
            // 
            this.dgvSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatislar.Location = new System.Drawing.Point(3, 254);
            this.dgvSatislar.Name = "dgvSatislar";
            this.dgvSatislar.RowHeadersWidth = 51;
            this.dgvSatislar.RowTemplate.Height = 24;
            this.dgvSatislar.Size = new System.Drawing.Size(785, 184);
            this.dgvSatislar.TabIndex = 7;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(544, 79);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(0, 16);
            this.lblFiyat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adet";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvSatislar);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUrunler);
            this.Controls.Add(this.cmbMusteriler);
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMusteriler;
        private System.Windows.Forms.ComboBox cmbUrunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.DataGridView dgvSatislar;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label label3;
    }
}