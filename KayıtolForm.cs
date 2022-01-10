using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class HastaKayitForm : Form
    {
        public HastaKayitForm()
        {
            InitializeComponent();
        }

        Sqlİslemler sqlİslemler = new Sqlİslemler();

        private void Kayit_Button_Click(object sender, EventArgs e)
        {

            #region Giriş Kontrol

            if (tcno.Text==string.Empty || ad.Text==string.Empty || soyad.Text==string.Empty || sifre.Text==string.Empty)
            {
                MessageBox.Show("Kayıt Bilgilerini giriniz");
                return;
            }


            DataGridView items=new DataGridView();

            sqlİslemler.goruntule("select tcno from Hasta", items);


            if (sqlİslemler.goruntule($"select tcno from Hasta where tcno = {tcno.Text} ") == tcno.Text)
            {
                MessageBox.Show("Girilen Tc ye ait başka bir hesap var");
                return;
            }


            if (sifre.Text != sifreTekrar.Text) 
            {
                MessageBox.Show("Şifreler uyuşmuyor");
                return;
            }


            if (sifre.Text.Length < 8) 
            {
                MessageBox.Show("en az 8 karakter uzunluğunda şifre giriniz");
                return;
            }

            #endregion


            sqlİslemler.degisiklikYap("insert into Hasta values (" + tcno.Text + ",'" + ad.Text + "','" + soyad.Text + "','" + sifre.Text + "') ");
            MessageBox.Show("Kayıt Başarılı, Giriş yapınız.");
            geriDon();

        }


        private void geriDon()
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void geriDon_ButtonClick(object sender, EventArgs e)
        {
            geriDon();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (sifre.UseSystemPasswordChar)
            {
                sifre.UseSystemPasswordChar = false;
                sifreTekrar.UseSystemPasswordChar = false;
                checkBox1.Text = "Gizle";
            }
            else
            {
                sifre.UseSystemPasswordChar = true;
                sifreTekrar.UseSystemPasswordChar = true;
                checkBox1.Text = "Göster";
            }
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

        private void tcno_MouseEnter(object sender, EventArgs e)
        {

        }

        private void tcno_Enter(object sender, EventArgs e)
        {
            if (tcno.Text == "Tc No") 
            {
                tcno.Text = "";
                tcno.ForeColor = Color.Black;
            }
        }

        private void tcno_Leave(object sender, EventArgs e)
        {
            if (tcno.Text == "")
            {
                tcno.Text = "Tc No";
                tcno.ForeColor = Color.Silver;
            }
        }

        private void ad_Enter(object sender, EventArgs e)
        {

            if (ad.Text == "Ad")
            {
                ad.Text = "";
                ad.ForeColor = Color.Black;
            }
        }

        private void ad_Leave(object sender, EventArgs e)
        {

            if (ad.Text == "")
            {
                ad.Text = "Ad";
                ad.ForeColor = Color.Silver;
            }
        }

        private void soyad_Enter(object sender, EventArgs e)
        {

            if (soyad.Text == "Soyad")
            {
                soyad.Text = "";
                soyad.ForeColor = Color.Black;
            }
        }

        private void soyad_Leave(object sender, EventArgs e)
        {
            if (soyad.Text == "")
            {
                soyad.Text = "Soyad";
                soyad.ForeColor = Color.Silver;
            }
        }

        private void sifre_Enter(object sender, EventArgs e)
        {
            if (sifre.Text == "****")
            {
                sifre.Text = "";
                sifre.ForeColor = Color.Black;
            }
        }

        private void sifre_Leave(object sender, EventArgs e)
        {
            if (sifre.Text == "")
            {
                sifre.Text = "****";
                sifre.ForeColor = Color.Silver;
            }
        }

        private void sifreTekrar_Enter(object sender, EventArgs e)
        {
            if (sifreTekrar.Text == "****")
            {
                sifreTekrar.Text = "";
                sifreTekrar.ForeColor = Color.Black;
            }
        }

        private void sifreTekrar_Leave(object sender, EventArgs e)
        {
            if (sifreTekrar.Text == "")
            {
                sifreTekrar.Text = "****";
                sifreTekrar.ForeColor = Color.Silver;
            }
        }
    }
}
