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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        
        private void CıkısButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoktorEkleSilForm doktorEkleSil = new DoktorEkleSilForm();
            this.Hide();
            doktorEkleSil.Show();
        }

        private void randevu_Sil_Button_Click(object sender, EventArgs e)
        {
            RandevuSilForm randevuSilForm = new RandevuSilForm();
            this.Hide();
            randevuSilForm.Show();
        }

        private void hastaSil_Button_Click(object sender, EventArgs e)
        {
            HastaSilForm hastaSilForm = new HastaSilForm();
            this.Hide();
            hastaSilForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReceteSilForm receteSilForm = new ReceteSilForm();
            receteSilForm.Show();
            this.Hide();
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

        private void button6_Click(object sender, EventArgs e)
        {
            BolumEkleSil bolumEkleSil = new BolumEkleSil();
            bolumEkleSil.Show();
            this.Hide();
        }

        private void adminEkle_Button_Click(object sender, EventArgs e)
        {
            AdminEkleSil adminEkleSil = new AdminEkleSil();
            adminEkleSil.Show();
            this.Hide();
        }
    }
}
