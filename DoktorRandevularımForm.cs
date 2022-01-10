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
    public partial class DoktorRandevularıForm : Form
    {
        public DoktorRandevularıForm()
        {
            InitializeComponent();
        }

        string doktorİd=DoktorForm.doktorİd;

        Sqlİslemler sqlİslemler = new Sqlİslemler();

        private void DoktorRandevularıForm_Load(object sender, EventArgs e)
        {

            randevuListele();

           
        }

        private void randevuListele()
        {
            sqlİslemler.goruntule($"select randevu_id,hasta_tcno,tarih,saat from Randevu where doktor_id = '{doktorİd}' ", dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count==0)
            {
                MessageBox.Show("Reçete yazılacak randevuyu Seçiniz");
                return;
            }

            string HastaTcno = dataGridView1.SelectedRows[0].Cells["hasta_tcno"].Value.ToString();

            sqlİslemler.degisiklikYap($"insert into Recete values ('{HastaTcno}','{doktorİd}','{DateTime.Now.Date}','{richTextBox1.Text}') ");

            sqlİslemler.degisiklikYap($"delete Randevu where randevu_id = '{dataGridView1.SelectedRows[0].Cells[0].Value}' ");

            MessageBox.Show("Reçete Yazıldı");

            richTextBox1.Clear();

            randevuListele();

        }

        private void geriDon_Button_Click(object sender, EventArgs e)
        {
            Application.OpenForms["DoktorForm"].Show();
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulamadan Çıkmak İstermisiniz", "UYARI!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private const int cCaption = 40;
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

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
