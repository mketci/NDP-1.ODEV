/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** ÖDEV NUMARASI..........:1
** ÖĞRENCİ ADI............:Metehan Taha KETÇİ   
** ÖĞRENCİ NUMARASI.......:B181200373
** DERSİN ALINDIĞI GRUP...:
****************************************************************************/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        int seciliSatir;
        public Form1()
        {
            InitializeComponent();
        }
        // tablo adında yeni, verileri çekmek için sanal bir tablo oluşturuldu.
        DataTable tablo = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {

            txtKitapID.Text = "1";
            txtKitapID.ReadOnly = true;
            tablo.Columns.Add("Kitap ID", typeof(int));
            tablo.Columns.Add("KitapAdı", typeof(string));
            tablo.Columns.Add("Yazar", typeof(string));
            tablo.Columns.Add("Tür", typeof(string));
            tablo.Columns.Add("Sayfa Sayısı", typeof(int));

            Liste.DataSource = tablo;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Kaydetme işleminden sonra hata düzeltilirse eski rengine dönmesi için.
            txtKitapAdi.BackColor = DefaultBackColor;
            txtKitapID.BackColor = DefaultBackColor;
            txtKitapTur.BackColor = DefaultBackColor;
            txtSayfaSayisi.BackColor = DefaultBackColor;
            txtYazarAdi.BackColor = DefaultBackColor;

            // Alanlardan herhangi birinin boş olması durumunda kayıt yapılmasını engellemek için koşul yazıldı.
            if (txtKitapID.Text != "" && txtKitapAdi.Text != "" && txtKitapTur.Text != "" && txtYazarAdi.Text != "" && txtSayfaSayisi.Text != "")
            {
              
                try
                {
                    tablo.Rows.Add(txtKitapID.Text, txtKitapAdi.Text, txtYazarAdi.Text, txtKitapTur.Text, txtSayfaSayisi.Text);
                    Liste.DataSource = tablo;


                    Temizle();
                }
                catch (Exception)
                {

                    MessageBox.Show("Kitap ID veya Sayfa Sayısı Hatalı.");
                }


            }

            else
            {
                // Boş bırakılan alan için MessageBox gösterildi.
                // Boş bırakılan alanların rengi kırmızıya dönüştürüldü.

                if (txtKitapAdi.Text == "")
                {
                    txtKitapAdi.BackColor = Color.Red;
                    MessageBox.Show("Kitap Adı Giriniz.");
                }
                if (txtKitapID.Text == "")
                {
                    txtKitapID.BackColor = Color.Red;
                    MessageBox.Show("Kitap ID Giriniz.");
                }
                if (txtKitapTur.Text == "")
                {
                    txtKitapTur.BackColor = Color.Red;
                    MessageBox.Show("Kitap Türü Giriniz.");
                }
                if (txtSayfaSayisi.Text == "")
                {
                    txtSayfaSayisi.BackColor = Color.Red;
                    MessageBox.Show("Sayfa Sayısı Giriniz.");
                }
                if (txtYazarAdi.Text == "")
                {
                    txtYazarAdi.BackColor = Color.Red;
                    MessageBox.Show("Yazar Adı Giriniz.");
                }

            }
            txtKitapID.Text = Liste.RowCount.ToString();



        }

        void Temizle()
        {
            txtKitapAdi.Text = "";
            txtKitapID.Text = "";
            txtKitapTur.Text = "";
            txtYazarAdi.Text = "";
            txtSayfaSayisi.Text = "";
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            seciliSatir = Liste.CurrentRow.Index;
            MessageBox.Show(seciliSatir.ToString());
            txtKitapAdi.Text = Liste.CurrentRow.Cells[1].Value.ToString();
            txtKitapID.Text = Liste.CurrentRow.Cells[0].Value.ToString();
            txtKitapTur.Text = Liste.CurrentRow.Cells[2].Value.ToString();
            txtSayfaSayisi.Text = Liste.CurrentRow.Cells[4].Value.ToString();
            txtYazarAdi.Text = Liste.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // Seçilen satırı butona tıkladığında siler satır seçilmemişse hata mesajı gelir.
            if (Liste.SelectedRows.Count > 0)
            {
                Liste.Rows.RemoveAt(Liste.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lüffen silinecek satırı seçin.");
            }
        }

        

        private void KitapAdiBul_TextChanged(object sender, EventArgs e)
        {
            // TextChanged eventi sayesinde textboxa girilen her karakterde tabloyu değiştirir.
            DataView dv = tablo.DefaultView;
            dv.RowFilter = "KitapAdı LIKE '" + "%" + KitapAdiBul.Text + "%'";
            Liste.DataSource = dv;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            // Yukarıda global olarak tanımlanmış seciliSatir değişkeni sayesinde iki kere tıklanan satırın index bilgisi alınarak güncelleme yapılır.
            Liste.Rows[seciliSatir].Cells[0].Value = txtKitapID.Text;
            Liste.Rows[seciliSatir].Cells[1].Value = txtKitapAdi.Text;
            Liste.Rows[seciliSatir].Cells[2].Value = txtYazarAdi.Text;
            Liste.Rows[seciliSatir].Cells[3].Value = txtKitapTur.Text;
            Liste.Rows[seciliSatir].Cells[4].Value = txtSayfaSayisi.Text;

            //Güncelleme yapıldıktan sonra aynı zamanda Datatable tipindeki sanal tablomuzda da değişikliği uygulamak için yazıldı. Ama başarılı sonuç alınamadı.
            DataRow satir = tablo.Rows[seciliSatir];
            satir["Yazar"]= txtYazarAdi.Text; 
        }


    }
}
