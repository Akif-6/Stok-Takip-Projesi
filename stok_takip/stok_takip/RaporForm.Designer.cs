namespace stok_takip
{
    partial class RaporForm
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
            this.btnKritik = new System.Windows.Forms.Button();
            this.btnMusteriler = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.btnCiro = new System.Windows.Forms.Button();
            this.btnAylikSatis = new System.Windows.Forms.Button();
            this.btnKarZarar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKritik
            // 
            this.btnKritik.BackColor = System.Drawing.Color.Transparent;
            this.btnKritik.FlatAppearance.BorderSize = 0;
            this.btnKritik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKritik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKritik.Location = new System.Drawing.Point(12, 83);
            this.btnKritik.Name = "btnKritik";
            this.btnKritik.Size = new System.Drawing.Size(98, 67);
            this.btnKritik.TabIndex = 0;
            this.btnKritik.Text = "Kritik Stoklar";
            this.btnKritik.UseVisualStyleBackColor = false;
            this.btnKritik.Click += new System.EventHandler(this.btnKritik_Click_1);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.BackColor = System.Drawing.Color.Transparent;
            this.btnMusteriler.FlatAppearance.BorderSize = 0;
            this.btnMusteriler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriler.Location = new System.Drawing.Point(136, 83);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(109, 67);
            this.btnMusteriler.TabIndex = 1;
            this.btnMusteriler.Text = "En İyi Müşteriler";
            this.btnMusteriler.UseVisualStyleBackColor = false;
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 274);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnUrunler
            // 
            this.btnUrunler.FlatAppearance.BorderSize = 0;
            this.btnUrunler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunler.Location = new System.Drawing.Point(275, 83);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(114, 86);
            this.btnUrunler.TabIndex = 3;
            this.btnUrunler.Text = "En Çok Satan Ürünler";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // btnCiro
            // 
            this.btnCiro.FlatAppearance.BorderSize = 0;
            this.btnCiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCiro.Location = new System.Drawing.Point(415, 83);
            this.btnCiro.Name = "btnCiro";
            this.btnCiro.Size = new System.Drawing.Size(111, 67);
            this.btnCiro.TabIndex = 4;
            this.btnCiro.Text = "Toplam Ciro";
            this.btnCiro.UseVisualStyleBackColor = true;
            this.btnCiro.Click += new System.EventHandler(this.btnCiro_Click);
            // 
            // btnAylikSatis
            // 
            this.btnAylikSatis.FlatAppearance.BorderSize = 0;
            this.btnAylikSatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAylikSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAylikSatis.Location = new System.Drawing.Point(679, 83);
            this.btnAylikSatis.Name = "btnAylikSatis";
            this.btnAylikSatis.Size = new System.Drawing.Size(109, 67);
            this.btnAylikSatis.TabIndex = 5;
            this.btnAylikSatis.Text = "Aylık Satışlar";
            this.btnAylikSatis.UseVisualStyleBackColor = true;
            this.btnAylikSatis.Click += new System.EventHandler(this.btnAylikSatis_Click);
            // 
            // btnKarZarar
            // 
            this.btnKarZarar.FlatAppearance.BorderSize = 0;
            this.btnKarZarar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKarZarar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKarZarar.Location = new System.Drawing.Point(552, 83);
            this.btnKarZarar.Name = "btnKarZarar";
            this.btnKarZarar.Size = new System.Drawing.Size(111, 67);
            this.btnKarZarar.TabIndex = 6;
            this.btnKarZarar.Text = "Kâr / Zarar";
            this.btnKarZarar.UseVisualStyleBackColor = true;
            this.btnKarZarar.Click += new System.EventHandler(this.btnKarZarar_Click_1);
            // 
            // RaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKarZarar);
            this.Controls.Add(this.btnAylikSatis);
            this.Controls.Add(this.btnCiro);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMusteriler);
            this.Controls.Add(this.btnKritik);
            this.Name = "RaporForm";
            this.Text = "RaporForm";
            this.Load += new System.EventHandler(this.RaporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKritik;
        private System.Windows.Forms.Button btnMusteriler;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Button btnCiro;
        private System.Windows.Forms.Button btnAylikSatis;
        private System.Windows.Forms.Button btnKarZarar;
    }
}