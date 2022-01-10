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
    public partial class KullaniciGirisForm : Form
    {
        public KullaniciGirisForm()
        {
            InitializeComponent();
        }

        Sqlİslemler sqlİslemler = new Sqlİslemler();


        

        private void hastaGirisButton_Click(object sender, EventArgs e)
        {
            
            bool giris_yaptimi = false;
            sqlİslemler.baglan();
            SqlCommand command = new SqlCommand("select * from Hasta", sqlİslemler.connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (hastaTextBox1.Text == reader["tcno"].ToString() && hastaTextBox2.Text == reader["sifre"].ToString())
                {
                    giris_yaptimi = true;
                    HastaGirisYap(reader["tcno"].ToString());
                }
            }
            sqlİslemler.baglantiKes();

            girisKontrol(giris_yaptimi);

        }

        private void HastaGirisYap(string tcno)
        {
            HastaForm hastaForm = new HastaForm(tcno);
            this.Hide();
            hastaForm.Show();
            hastaTextBox1.Clear();
            hastaTextBox2.Clear();
        }

        private void DoktorGirisYap(string doktor_İd)
        {
            DoktorForm doktorForm = new DoktorForm(doktor_İd);
            this.Hide();
            doktorForm.Show();
            doktorTextBox1.Clear();
            doktorTextBox2.Clear();
        }

        private void AdminGirisYap(string admin_id)
        {
            AdminForm adminForm = new AdminForm();
            this.Hide();
            adminForm.Show();
            adminTextBox1.Clear();
            adminTextBox2.Clear();
        }

        private void doktorGirisButton_Click(object sender, EventArgs e)
        {
            bool giris_yaptimi = false;
            sqlİslemler.baglan();
            SqlCommand command = new SqlCommand("select kullaniciad,sifre,id from Doktor", sqlİslemler.connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (doktorTextBox1.Text == reader[0].ToString().TrimEnd() && doktorTextBox2.Text == reader[1].ToString().TrimEnd())
                {
                    giris_yaptimi = true;
                    DoktorGirisYap(reader[2].ToString());
                }
            }
            sqlİslemler.baglantiKes();

            girisKontrol(giris_yaptimi);

        }

        private void adminGirisButton_Click(object sender, EventArgs e)
        {
            bool giris_yaptimi = false;
            sqlİslemler.baglan();
            SqlCommand command = new SqlCommand("select kullaniciad,sifre,id from Admin", sqlİslemler.connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (adminTextBox1.Text == reader[0].ToString().TrimEnd() && adminTextBox2.Text == reader[1].ToString().TrimEnd())
                {
                    giris_yaptimi = true;
                    AdminGirisYap(reader[2].ToString());
                }
            }
            sqlİslemler.baglantiKes();

            girisKontrol(giris_yaptimi);          

        }


        private void girisKontrol(bool girisYaptimi)
        {
            if (!girisYaptimi)
            {
                MessageBox.Show("Giriş Bilgileri Yanlış");
            }
        }


        private void KullaniciGirisForm_Load_1(object sender, EventArgs e)
        {
            sqlİslemler.baglan();
            sqlİslemler.baglantiKes();
        }

        private void hastaKayıt_Button_Click(object sender, EventArgs e)
        {
            HastaKayitForm hastaKayitForm = new HastaKayitForm();
            this.Hide();
            hastaKayitForm.Show();
        }

        private void sifreGosterGizle(TextBox sifre,CheckBox checkBox)
        {
            if (sifre.UseSystemPasswordChar)
            {
                sifre.UseSystemPasswordChar = false;
                checkBox.Text = "Gizle";
            }
            else
            {
                sifre.UseSystemPasswordChar = true;
                checkBox.Text = "Göster";
            }
        }

        private void check_hastaSifre_CheckedChanged(object sender, EventArgs e)
        {
            sifreGosterGizle(hastaTextBox2, check_hastaSifre);
        }

        private void check_doktorSifre_CheckedChanged(object sender, EventArgs e)
        {
            sifreGosterGizle(doktorTextBox2, check_doktorSifre);
        }

        private void check_adminSifre_CheckedChanged(object sender, EventArgs e)
        {
            sifreGosterGizle(adminTextBox2, check_adminSifre);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Uygulamadan Çıkmak İstermisiniz","UYARI!!",MessageBoxButtons.YesNo)==DialogResult.Yes)
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
