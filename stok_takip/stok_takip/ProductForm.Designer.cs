namespace stok_takip
{
    partial class ProductForm
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
            this.dgvUrunler2 = new System.Windows.Forms.DataGridView();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.ekle_button = new System.Windows.Forms.Button();
            this.guncelle_button = new System.Windows.Forms.Button();
            this.sıl_button = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtSatis = new System.Windows.Forms.TextBox();
            this.txtMinStok = new System.Windows.Forms.TextBox();
            this.txtAlis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUrunler2
            // 
            this.dgvUrunler2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUrunler2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler2.Location = new System.Drawing.Point(0, 0);
            this.dgvUrunler2.Name = "dgvUrunler2";
            this.dgvUrunler2.RowHeadersWidth = 51;
            this.dgvUrunler2.RowTemplate.Height = 24;
            this.dgvUrunler2.Size = new System.Drawing.Size(1066, 245);
            this.dgvUrunler2.TabIndex = 0;
            this.dgvUrunler2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler2_CellClick);
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(317, 313);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(100, 22);
            this.txtStok.TabIndex = 2;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(159, 313);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 22);
            this.txtUrunAdi.TabIndex = 3;
            // 
            // ekle_button
            // 
            this.ekle_button.Location = new System.Drawing.Point(342, 390);
            this.ekle_button.Name = "ekle_button";
            this.ekle_button.Size = new System.Drawing.Size(75, 23);
            this.ekle_button.TabIndex = 4;
            this.ekle_button.Text = "Ekle";
            this.ekle_button.UseVisualStyleBackColor = true;
            this.ekle_button.Click += new System.EventHandler(this.ekle_button_Click);
            // 
            // guncelle_button
            // 
            this.guncelle_button.Location = new System.Drawing.Point(488, 390);
            this.guncelle_button.Name = "guncelle_button";
            this.guncelle_button.Size = new System.Drawing.Size(85, 23);
            this.guncelle_button.TabIndex = 5;
            this.guncelle_button.Text = "Güncelle";
            this.guncelle_button.UseVisualStyleBackColor = true;
            this.guncelle_button.Click += new System.EventHandler(this.guncelle_button_Click);
            // 
            // sıl_button
            // 
            this.sıl_button.Location = new System.Drawing.Point(684, 390);
            this.sıl_button.Name = "sıl_button";
            this.sıl_button.Size = new System.Drawing.Size(75, 23);
            this.sıl_button.TabIndex = 6;
            this.sıl_button.Text = "Sil";
            this.sıl_button.UseVisualStyleBackColor = true;
            this.sıl_button.Click += new System.EventHandler(this.sil_button_click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 313);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 7;
            // 
            // txtSatis
            // 
            this.txtSatis.Location = new System.Drawing.Point(668, 313);
            this.txtSatis.Name = "txtSatis";
            this.txtSatis.Size = new System.Drawing.Size(100, 22);
            this.txtSatis.TabIndex = 8;
            // 
            // txtMinStok
            // 
            this.txtMinStok.Location = new System.Drawing.Point(842, 313);
            this.txtMinStok.Name = "txtMinStok";
            this.txtMinStok.Size = new System.Drawing.Size(100, 22);
            this.txtMinStok.TabIndex = 9;
            // 
            // txtAlis
            // 
            this.txtAlis.Location = new System.Drawing.Point(488, 313);
            this.txtAlis.Name = "txtAlis";
            this.txtAlis.Size = new System.Drawing.Size(100, 22);
            this.txtAlis.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Alış Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(681, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Satış Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(839, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kritik Stok Sınırı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ürün No (ID)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ürün Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Stok Miktarı";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::stok_takip.Properties.Resources._3wVcMN;
            this.ClientSize = new System.Drawing.Size(1057, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAlis);
            this.Controls.Add(this.txtMinStok);
            this.Controls.Add(this.txtSatis);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.sıl_button);
            this.Controls.Add(this.guncelle_button);
            this.Controls.Add(this.ekle_button);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.dgvUrunler2);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUrunler2;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Button ekle_button;
        private System.Windows.Forms.Button guncelle_button;
        private System.Windows.Forms.Button sıl_button;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtSatis;
        private System.Windows.Forms.TextBox txtMinStok;
        private System.Windows.Forms.TextBox txtAlis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}