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
    public partial class BolumEkleSil : Form
    {
        public BolumEkleSil()
        {
            InitializeComponent();
        }

        Sqlİslemler sqlİslemler = new Sqlİslemler();

        private void geriDon_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[1].Show();
        }

        private void listele_Button_Click(object sender, EventArgs e)
        {
            bolumListele();
        }

        private void sil_Button_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count==0)
            {
                MessageBox.Show("Bölümm seçiniz");
                return;
            }

            if (MessageBox.Show("Bölümü silmek istediğinize eminmisiniz","UYARI",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                int secilenBolum = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                if (sqlİslemler.goruntule($"select count(id) from Doktor where bolum_id={secilenBolum}") != "0") 
                {
                    MessageBox.Show("Bölümde doktor var silinemez");
                    return;
                }

                sqlİslemler.degisiklikYap($"delete Bolum where bolum_id={secilenBolum} ");
                bolumListele();
            }
        }

        private void ekle_Button_Click(object sender, EventArgs e)
        {

            if (txt_bolumad.Text==string.Empty)
            {
                MessageBox.Show("Bolum ismi giriniz");
                return;
            }

            if (sqlİslemler.goruntule($"select bolum_ad from Bolum where bolum_ad='{txt_bolumad.Text}'").ToUpper()==txt_bolumad.Text.ToUpper())
            {
                MessageBox.Show("Bu bölüm zaten ekli");
                return;
            }

            sqlİslemler.degisiklikYap($"insert into Bolum (bolum_ad) values ('{txt_bolumad.Text}')");
            bolumListele();
        }

        private void bolumListele()
        {
            sqlİslemler.goruntule("select * from Bolum",dataGridView1);
        }

        private void BolumEkleSil_Load(object sender, EventArgs e)
        {
            bolumListele();
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
    }
}
