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
    public partial class recetelerimForm : Form
    {
        public recetelerimForm(string tcno)
        {
            InitializeComponent();
            this.tcno = tcno;
        }

        string tcno;

        Sqlİslemler sqlİslemler = new Sqlİslemler();

        private void recetelerimForm_Load(object sender, EventArgs e)
        {
            sqlİslemler.goruntule("select r.recete_id as 'Reçete İd' ,d.ad as 'Doktor ad' ,d.soyad as 'Doktor Soyad',r.verilen_tarih as 'Veilen Tarih' from Recete as r " +
                "full join Doktor as d on r.doktor_id=d.id " +
                $"where r.hasta_tcno = '{tcno}' " ,dataGridView1);

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count!=0)
            {
                string secilenRecete = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                richTextBox1.Text = sqlİslemler.goruntule($"select aciklama from Recete where recete_id = {secilenRecete} ");
            }
            
        }

        private void geriDon_Button_Click(object sender, EventArgs e)
        {
            Application.OpenForms["HastaForm"].Show();
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

    }
}
