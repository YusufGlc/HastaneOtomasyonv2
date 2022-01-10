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
    public partial class HastaSilForm : Form
    {
        public HastaSilForm()
        {
            InitializeComponent();
        }

        Sqlİslemler sqlİslemler = new Sqlİslemler();

        private void ara_Button_Click(object sender, EventArgs e)
        {
            sqlİslemler.goruntule("select tcno,ad,soyad from Hasta " +
                $"where tcno like '{txt_tcno.Text}%' and ad like '{txt_ad.Text}%' and soyad like '{txt_soyad.Text}%' "
                , dataGridView1);
        }

        private void hastaListele()
        {
            sqlİslemler.goruntule("select tcno,ad,soyad from Hasta ",dataGridView1);
        }

        private void listele_Button_Click(object sender, EventArgs e)
        {
            hastaListele();
        }

        private void sil_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0) 
            {
                string tcno = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                sqlİslemler.degisiklikYap($"delete Hasta where tcno = '{tcno}' ");
                hastaListele();
            }
            else
            {
                MessageBox.Show("Hasta seçiniz");
            }
        }

        private void geriDon_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[1].Show();
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

        private void HastaSilForm_Load(object sender, EventArgs e)
        {
            hastaListele();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
