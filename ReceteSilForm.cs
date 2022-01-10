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
    public partial class ReceteSilForm : Form
    {
        public ReceteSilForm()
        {
            InitializeComponent();
        }

        Sqlİslemler sqlİslemler = new Sqlİslemler();

        private void ara_Button_Click(object sender, EventArgs e)
        {

            sqlİslemler.goruntule($"select * from Recete where recete_id like '{txt_receteNo.Text}' and hasta_tcno like '{txt_tcno.Text}%' ", dataGridView1);

        }

        private void sil_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                sqlİslemler.degisiklikYap($"delete Recete where recete_id = '{id}' ");
                receteListele();
            }
            else
            {
                MessageBox.Show("Reçete seçiniz");
            }
        }

        private void receteListele()
        {
            sqlİslemler.goruntule("select * from Recete", dataGridView1);
        }

        private void listele_button_Click(object sender, EventArgs e)
        {
            receteListele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.OpenForms["AdminForm"].Show();
            this.Close();
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

        private void ReceteSilForm_Load(object sender, EventArgs e)
        {
            receteListele();
        }
    }
}
