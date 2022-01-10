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
    public partial class HastaForm : Form
    {
        
        public HastaForm(string tcno)
        {
            InitializeComponent();
            this.tcno=tcno;
        }

        bool randevuListelendimi = false;
        public string tcno;
        Sqlİslemler sqlİslemler = new Sqlİslemler();

        private void CıkısButton_Click(object sender, EventArgs e)
        {
            CıkısYap(); 
        }

        private void CıkısYap()
        {
            this.Close();
            Application.OpenForms[0].Show();
        }

        private void HastaForm_Load(object sender, EventArgs e)
        {
            adSoyad_label.Text = sqlİslemler.goruntule($"select trim(ad)+space(2)+trim(soyad) from Hasta where tcno = '{tcno}' ");
            randevuListele();
        }

        private void randevuAl_Button_Click(object sender, EventArgs e)
        {
            RandevuAlForm randevuAlForm = new RandevuAlForm(tcno);
            randevuAlForm.Show();
            randevuListelendimi = false;
            this.Hide();
        }

        private void randevuListele()
        {
            sqlİslemler.goruntule("select r.randevu_id,r.hasta_tcno,d.ad as 'doktor ad',d.soyad as 'doktor soyad',r.tarih,r.saat from Randevu as r " +
                "inner join Doktor as d on r.doktor_id=d.id " +
                $"where hasta_tcno = '{tcno}' ", dataGridView1);
            randevuListelendimi = true;
        }

        private void HastaForm_Activated(object sender, EventArgs e)
        {
            if (!randevuListelendimi)
            {
                randevuListele();
            }
        }

        private void recetelerim_Button_Click(object sender, EventArgs e)
        {
            recetelerimForm recetelerimForm = new recetelerimForm(tcno);
            recetelerimForm.Show();
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

    }
}
