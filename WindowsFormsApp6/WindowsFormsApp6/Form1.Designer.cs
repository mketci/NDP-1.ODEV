namespace WindowsFormsApp6
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.txtKitapID = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.txtKitapTur = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.KitapAdiBul = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.Red;
            this.btnKaydet.Location = new System.Drawing.Point(286, 28);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(286, 134);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.ForeColor = System.Drawing.Color.Red;
            this.btnGüncelle.Location = new System.Drawing.Point(286, 82);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGüncelle.TabIndex = 2;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(58, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kitap ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(58, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kitap Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(58, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yazar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(58, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tür";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(58, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sayfa Sayısı";
            // 
            // Liste
            // 
            this.Liste.BackgroundColor = System.Drawing.Color.MistyRose;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Location = new System.Drawing.Point(1, 170);
            this.Liste.Name = "Liste";
            this.Liste.ReadOnly = true;
            this.Liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Liste.Size = new System.Drawing.Size(543, 254);
            this.Liste.TabIndex = 9;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // txtKitapID
            // 
            this.txtKitapID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtKitapID.Location = new System.Drawing.Point(138, 28);
            this.txtKitapID.Name = "txtKitapID";
            this.txtKitapID.Size = new System.Drawing.Size(100, 20);
            this.txtKitapID.TabIndex = 10;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtKitapAdi.Location = new System.Drawing.Point(138, 51);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKitapAdi.TabIndex = 11;
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtYazarAdi.Location = new System.Drawing.Point(138, 78);
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(100, 20);
            this.txtYazarAdi.TabIndex = 12;
            // 
            // txtKitapTur
            // 
            this.txtKitapTur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtKitapTur.Location = new System.Drawing.Point(138, 112);
            this.txtKitapTur.Name = "txtKitapTur";
            this.txtKitapTur.Size = new System.Drawing.Size(100, 20);
            this.txtKitapTur.TabIndex = 13;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSayfaSayisi.Location = new System.Drawing.Point(138, 144);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtSayfaSayisi.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(455, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Aradığınız Kitabın Adını Giriniz";
            // 
            // KitapAdiBul
            // 
            this.KitapAdiBul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.KitapAdiBul.Location = new System.Drawing.Point(492, 93);
            this.KitapAdiBul.Name = "KitapAdiBul";
            this.KitapAdiBul.Size = new System.Drawing.Size(100, 20);
            this.KitapAdiBul.TabIndex = 16;
            this.KitapAdiBul.TextChanged += new System.EventHandler(this.KitapAdiBul_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(670, 436);
            this.Controls.Add(this.KitapAdiBul);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSayfaSayisi);
            this.Controls.Add(this.txtKitapTur);
            this.Controls.Add(this.txtYazarAdi);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.txtKitapID);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.TextBox txtKitapID;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtYazarAdi;
        private System.Windows.Forms.TextBox txtKitapTur;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox KitapAdiBul;
    }
}

