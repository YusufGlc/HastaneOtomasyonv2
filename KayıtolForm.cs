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

    }
}
