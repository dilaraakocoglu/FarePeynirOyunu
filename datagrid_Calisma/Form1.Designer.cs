namespace datagrid_Calisma
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgv_labirent = new System.Windows.Forms.DataGridView();
            this.btn_labirentOlustur = new System.Windows.Forms.Button();
            this.txtBuyukluk = new System.Windows.Forms.TextBox();
            this.btnDuvarEkle = new System.Windows.Forms.Button();
            this.btnYolEkle = new System.Windows.Forms.Button();
            this.btnFareEkle = new System.Windows.Forms.Button();
            this.btnPeynir = new System.Windows.Forms.Button();
            this.btnArmayiBaslat = new System.Windows.Forms.Button();
            this.zamanlayici = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pB_peynir = new System.Windows.Forms.PictureBox();
            this.pB_fare = new System.Windows.Forms.PictureBox();
            this.pB_yol = new System.Windows.Forms.PictureBox();
            this.pB_duvar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_labirent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_peynir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_fare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_yol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_duvar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_labirent
            // 
            this.dgv_labirent.AllowUserToAddRows = false;
            this.dgv_labirent.AllowUserToDeleteRows = false;
            this.dgv_labirent.AllowUserToResizeColumns = false;
            this.dgv_labirent.AllowUserToResizeRows = false;
            this.dgv_labirent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_labirent.ColumnHeadersVisible = false;
            this.dgv_labirent.Location = new System.Drawing.Point(11, 11);
            this.dgv_labirent.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_labirent.Name = "dgv_labirent";
            this.dgv_labirent.ReadOnly = true;
            this.dgv_labirent.RowHeadersVisible = false;
            this.dgv_labirent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_labirent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_labirent.Size = new System.Drawing.Size(465, 469);
            this.dgv_labirent.TabIndex = 0;
            this.dgv_labirent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_labirent_CellClick);
            // 
            // btn_labirentOlustur
            // 
            this.btn_labirentOlustur.Location = new System.Drawing.Point(596, 319);
            this.btn_labirentOlustur.Name = "btn_labirentOlustur";
            this.btn_labirentOlustur.Size = new System.Drawing.Size(99, 46);
            this.btn_labirentOlustur.TabIndex = 1;
            this.btn_labirentOlustur.Text = "Labirent Oluştur";
            this.btn_labirentOlustur.UseVisualStyleBackColor = true;
            this.btn_labirentOlustur.Click += new System.EventHandler(this.btn_labirentOlustur_Click);
            // 
            // txtBuyukluk
            // 
            this.txtBuyukluk.Location = new System.Drawing.Point(657, 259);
            this.txtBuyukluk.Multiline = true;
            this.txtBuyukluk.Name = "txtBuyukluk";
            this.txtBuyukluk.Size = new System.Drawing.Size(91, 23);
            this.txtBuyukluk.TabIndex = 4;
            this.txtBuyukluk.TextChanged += new System.EventHandler(this.txtBuyukluk_TextChanged);
            this.txtBuyukluk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuyukluk_KeyPress);
            // 
            // btnDuvarEkle
            // 
            this.btnDuvarEkle.Location = new System.Drawing.Point(528, 68);
            this.btnDuvarEkle.Name = "btnDuvarEkle";
            this.btnDuvarEkle.Size = new System.Drawing.Size(75, 29);
            this.btnDuvarEkle.TabIndex = 7;
            this.btnDuvarEkle.Text = "Duvar Ekle";
            this.btnDuvarEkle.UseVisualStyleBackColor = true;
            this.btnDuvarEkle.Click += new System.EventHandler(this.btnDuvarEkle_Click);
            // 
            // btnYolEkle
            // 
            this.btnYolEkle.Location = new System.Drawing.Point(673, 67);
            this.btnYolEkle.Name = "btnYolEkle";
            this.btnYolEkle.Size = new System.Drawing.Size(75, 30);
            this.btnYolEkle.TabIndex = 8;
            this.btnYolEkle.Text = "Yol Ekle";
            this.btnYolEkle.UseVisualStyleBackColor = true;
            this.btnYolEkle.Click += new System.EventHandler(this.btnYolEkle_Click);
            // 
            // btnFareEkle
            // 
            this.btnFareEkle.Location = new System.Drawing.Point(528, 179);
            this.btnFareEkle.Name = "btnFareEkle";
            this.btnFareEkle.Size = new System.Drawing.Size(75, 27);
            this.btnFareEkle.TabIndex = 9;
            this.btnFareEkle.Text = "Fare Ekle";
            this.btnFareEkle.UseVisualStyleBackColor = true;
            this.btnFareEkle.Click += new System.EventHandler(this.btnFareEkle_Click);
            // 
            // btnPeynir
            // 
            this.btnPeynir.Location = new System.Drawing.Point(673, 179);
            this.btnPeynir.Name = "btnPeynir";
            this.btnPeynir.Size = new System.Drawing.Size(75, 27);
            this.btnPeynir.TabIndex = 10;
            this.btnPeynir.Text = "Peynir Ekle";
            this.btnPeynir.UseVisualStyleBackColor = true;
            this.btnPeynir.Click += new System.EventHandler(this.btnPeynir_Click);
            // 
            // btnArmayiBaslat
            // 
            this.btnArmayiBaslat.Location = new System.Drawing.Point(577, 400);
            this.btnArmayiBaslat.Name = "btnArmayiBaslat";
            this.btnArmayiBaslat.Size = new System.Drawing.Size(138, 66);
            this.btnArmayiBaslat.TabIndex = 11;
            this.btnArmayiBaslat.Text = "Aramayı Başlat";
            this.btnArmayiBaslat.UseVisualStyleBackColor = true;
            this.btnArmayiBaslat.Click += new System.EventHandler(this.btnArmayiBaslat_Click);
            // 
            // zamanlayici
            // 
            this.zamanlayici.Tick += new System.EventHandler(this.zamanlayici_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Labirent Boyutu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pB_peynir
            // 
            this.pB_peynir.Image = global::datagrid_Calisma.Properties.Resources.peynir22;
            this.pB_peynir.Location = new System.Drawing.Point(673, 119);
            this.pB_peynir.Name = "pB_peynir";
            this.pB_peynir.Size = new System.Drawing.Size(75, 50);
            this.pB_peynir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_peynir.TabIndex = 6;
            this.pB_peynir.TabStop = false;
            // 
            // pB_fare
            // 
            this.pB_fare.Image = global::datagrid_Calisma.Properties.Resources.fare2;
            this.pB_fare.Location = new System.Drawing.Point(528, 119);
            this.pB_fare.Name = "pB_fare";
            this.pB_fare.Size = new System.Drawing.Size(75, 50);
            this.pB_fare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_fare.TabIndex = 5;
            this.pB_fare.TabStop = false;
            // 
            // pB_yol
            // 
            this.pB_yol.Image = global::datagrid_Calisma.Properties.Resources.yoll;
            this.pB_yol.Location = new System.Drawing.Point(673, 11);
            this.pB_yol.Name = "pB_yol";
            this.pB_yol.Size = new System.Drawing.Size(75, 50);
            this.pB_yol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_yol.TabIndex = 3;
            this.pB_yol.TabStop = false;
            // 
            // pB_duvar
            // 
            this.pB_duvar.Image = global::datagrid_Calisma.Properties.Resources.duvar;
            this.pB_duvar.Location = new System.Drawing.Point(528, 12);
            this.pB_duvar.Name = "pB_duvar";
            this.pB_duvar.Size = new System.Drawing.Size(75, 50);
            this.pB_duvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_duvar.TabIndex = 2;
            this.pB_duvar.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnArmayiBaslat);
            this.Controls.Add(this.btnPeynir);
            this.Controls.Add(this.btnFareEkle);
            this.Controls.Add(this.btnYolEkle);
            this.Controls.Add(this.btnDuvarEkle);
            this.Controls.Add(this.pB_peynir);
            this.Controls.Add(this.pB_fare);
            this.Controls.Add(this.txtBuyukluk);
            this.Controls.Add(this.pB_yol);
            this.Controls.Add(this.pB_duvar);
            this.Controls.Add(this.btn_labirentOlustur);
            this.Controls.Add(this.dgv_labirent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_labirent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_peynir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_fare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_yol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_duvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_labirent;
        private System.Windows.Forms.Button btn_labirentOlustur;
        private System.Windows.Forms.PictureBox pB_duvar;
        private System.Windows.Forms.PictureBox pB_yol;
        private System.Windows.Forms.TextBox txtBuyukluk;
        private System.Windows.Forms.PictureBox pB_fare;
        private System.Windows.Forms.PictureBox pB_peynir;
        private System.Windows.Forms.Button btnDuvarEkle;
        private System.Windows.Forms.Button btnYolEkle;
        private System.Windows.Forms.Button btnFareEkle;
        private System.Windows.Forms.Button btnPeynir;
        private System.Windows.Forms.Button btnArmayiBaslat;
        private System.Windows.Forms.Timer zamanlayici;
        private System.Windows.Forms.Label label1;
    }
}

