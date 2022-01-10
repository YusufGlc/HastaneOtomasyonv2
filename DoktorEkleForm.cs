using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneOtomasyon
{
    public partial class DoktorEkleSilForm : Form
    {
        public DoktorEkleSilForm()
        {
            InitializeComponent();
        }

       

        Sqlİslemler sqlİslemler = new Sqlİslemler();

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[1].Show();
        }

        private void DoktorEkleSilForm_Load(object sender, EventArgs e)
        {
            sqlİslemler.goruntule("select bolum_ad from Bolum", cbx_bolum);

            doktorListele(); 

        }

        private void button1_Click(object sender, EventArgs e)
        {

            #region Kontrol

            if (txt_ad.Text == string.Empty || txt_soyad.Text == string.Empty || cbx_bolum.SelectedIndex == -1 || txt_kullaniciAd.Text == string.Empty || txt_sifre.Text == string.Empty) 
            {
                MessageBox.Show("Doktor bilgileri boş bırakılamaz");
                return;
            }


            if (sqlİslemler.goruntule($"select kullaniciad from Doktor where kullaniciad='{txt_kullaniciAd.Text}' ") == txt_kullaniciAd.Text) 
            {
                MessageBox.Show("girilen Kullanıcı adı başka hesap ile kayıtlı");
                return;
            }
            
            #endregion

            #region bolum_id
            string bolum_id;
            sqlİslemler.baglan();
            SqlCommand command = new SqlCommand("select bolum_id from Bolum where bolum_ad = '"+ cbx_bolum.SelectedItem +"'",sqlİslemler.connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            bolum_id = reader["bolum_id"].ToString();
            sqlİslemler.baglantiKes();
            #endregion;

            sqlİslemler.degisiklikYap("insert into Doktor (ad,soyad,bolum_id,kullaniciad,sifre) values ('"+
              $"{txt_ad.Text}','{txt_soyad.Text}','{bolum_id}','{txt_kullaniciAd.Text}','{txt_sifre.Text}')");
            
            doktorListele();

        }

        private void doktorListele()
        {

            sqlİslemler.goruntule("select id,ad,soyad,bolum_ad,kullaniciad,sifre from Doktor as d left join Bolum as b on d.bolum_id=b.bolum_id ", dataGridView1);

        }

        private void listele_button_Click(object sender, EventArgs e)
        {
            doktorListele();
        }

        private void sil_Button_Click(object sender, EventArgs e)
        {
           

            if (dataGridView1.SelectedRows.Count != 0) 
            {

                if (MessageBox.Show($"{dataGridView1.SelectedRows[0].Cells["ad"].Value.ToString().TrimEnd()} {dataGridView1.SelectedRows[0].Cells["soyad"].Value.ToString().TrimEnd()} isimli Doktoru Silmek üzeresiniz !", "UYARI", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                sqlİslemler.degisiklikYap($"delete Randevu where doktor_id = {id} ");
                sqlİslemler.degisiklikYap($"update Recete set doktor_id = NULL where doktor_id = {id} ");
                sqlİslemler.degisiklikYap($"delete Doktor where id = '{id}' ");
                doktorListele();
            }
            else
            {
                MessageBox.Show("Doktor seçiniz");
            }
            
        }

        private void ara_Button(object sender, EventArgs e)
        {

            sqlİslemler.goruntule("select id,ad,soyad,bolum_ad,kullaniciad,sifre from Doktor as d " +
                "inner join Bolum as b on d.bolum_id=b.bolum_id " +
                $"where ad like '{txt_adAra.Text}%' and soyad like '{txt_soyadAra.Text}%' ", dataGridView1);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulamadan Çıkmak İstermisiniz", "UYARI!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private const int cCaption = 50;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

            }
            base.WndProc(ref m);
        }

        private void bolumAta_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count==0)
            {
                MessageBox.Show("Doktor seçiniz");
                return;
            }

            if (cbx_bolum.SelectedIndex==-1)
            {
                MessageBox.Show("Bölüm seçiniz");
                return;
            }

            string secilenDoktor = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string secilenBolum = sqlİslemler.goruntule($"select bolum_id from Bolum where bolum_ad='{cbx_bolum.SelectedItem}' ");
            sqlİslemler.degisiklikYap($"update Doktor set bolum_id={secilenBolum} where id={secilenDoktor} ");
            doktorListele();

        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
