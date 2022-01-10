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

            sqlİslemler.degisiklikYap($"insert into Admin (kullaniciad,sifre) values ('{txt_kullaniciAd.Text}','{txt_sifre.Text}') ");

            adminListele();

        }

        private void geriDon_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[1].Show();
        }


        private void adminListele()
        {
            sqlİslemler.goruntule($"select * from Admin where id!={AdminForm.adminİd}",dataGridView1);
        }


        private void listele_Button_Click(object sender, EventArgs e)
        {
            adminListele();
        }

        private void AdminEkleSil_Load(object sender, EventArgs e)
        {
            adminListele();
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
        
        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulamadan Çıkmak İstermisiniz", "UYARI!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void silButton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count==0)
            {
                MessageBox.Show("Silinecek admini seçiniz");
                return;
            }

            sqlİslemler.degisiklikYap($"delete Admin where id={dataGridView1.SelectedRows[0].Cells[0].Value}");
            adminListele();
        }
    }
}
