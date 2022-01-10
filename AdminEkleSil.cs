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
    public partial class AdminEkleSil : Form
    {
        public AdminEkleSil()
        {
            InitializeComponent();
        }

        Sqlİslemler sqlİslemler = new Sqlİslemler();

        private void button2_Click(object sender, EventArgs e)
        {
            #region Kontrol

            if (txt_kullaniciAd.Text == string.Empty || txt_sifre.Text == string.Empty)
            {
                MessageBox.Show("Admin bilgileri boş bırakılamaz");
                return;
            }


            if (sqlİslemler.goruntule($"select kullaniciad from Admin where kullaniciad='{txt_kullaniciAd.Text}' ") == txt_kullaniciAd.Text)
            {
                MessageBox.Show("girilen Kullanıcı adı başka hesap ile kayıtlı");
                return;
            }

            #endregion

            sqlİslemler.degisiklikYap($"insert into Admin (kullaniciad,sifre) values ('{txt_kullaniciAd.Text}',{txt_sifre.Text}) ");


        }
    }
}
