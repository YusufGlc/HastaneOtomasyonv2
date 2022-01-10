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
    public partial class RandevuSilForm : Form
    {

        Sqlİslemler sqlİslemler = new Sqlİslemler();

        public RandevuSilForm()
        {
            InitializeComponent();
        }

        private void ara_Button_Click(object sender, EventArgs e)
        {
            sqlİslemler.goruntule("select * from Randevu " +
                $"where randevu_id like '{txt_randevuNo.Text}%' and hasta_tcno like '{txt_tcno.Text}%' "
                , dataGridView1);
        }

        private void sil_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                sqlİslemler.degisiklikYap($"delete Randevu where randevu_id='{id}' ");
                randevuListele();
            }
            else
            {
                MessageBox.Show("Randevu seçiniz");
            }
        }

        private void geriDon_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[1].Show();
        }

        private void randevuListele()
        {
            sqlİslemler.goruntule("select * from Randevu " , dataGridView1);

        }

        private void listele_Button_Click(object sender, EventArgs e)
        {
            randevuListele();
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

        private void RandevuSilForm_Load(object sender, EventArgs e)
        {
            randevuListele();
        }
    }
}
