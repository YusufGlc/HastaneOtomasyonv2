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
    public partial class RandevuAlForm : Form
    {
        public RandevuAlForm(string tcno)
        {
            InitializeComponent();
            this.tcno = tcno;
        }

        Sqlİslemler sqlİslemler = new Sqlİslemler();

        string tcno;
        string secilenDoktorid;
        const int minRandevuSaat=0;
        const int maxRandevuSaat=23;

        int secilenSaat;
        int secilenDakika;

        private void RandevuAlForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now.AddYears(1);
            sqlİslemler.goruntule("select bolum_ad from Bolum", cbx_bolum);

            #region saat


            for (int i = 0; i <= maxRandevuSaat && i >= minRandevuSaat; i++) 
            {
                for (int k = 0; k < 60; k+=5)
                {
                    if (k==0 || k==5)
                    {
                        time_Combobox.Items.Add(i + ":0" + k);
                    }
                    else
                    {
                        time_Combobox.Items.Add(i + ":" + k);
                    }
                    
                }
            }

            #endregion

        }

        private void randevuAl_Button_Click(object sender, EventArgs e)
        {
            
            DateTime dateTime = dateTimePicker1.Value.Date;
            dateTime=dateTime.AddHours(secilenSaat);
            dateTime=dateTime.AddMinutes(secilenDakika);

            if (cbx_bolum.SelectedIndex != -1 && cbx_doktorAd.SelectedIndex != -1 && time_Combobox.SelectedIndex!=-1) 
            {
                if (dateTime >= DateTime.Now)
                {
                    string tarih = dateTime.Year + "-" + dateTime.Month + "-" + dateTime.Day;
                    sqlİslemler.degisiklikYap("insert into Randevu (hasta_tcno,doktor_id,tarih,saat) " +
                      $"values ('{tcno} ','{secilenDoktorid} ','{tarih}','{time_Combobox.SelectedItem}') ");
                    
                    MessageBox.Show("Randevu alındı");

                    GeriDon();
                }
                else
                {
                    MessageBox.Show("geçmiş bir tarihe Randevu alınamaz");
                }
            }
            else
            {
                MessageBox.Show("randevu bilgilerini doldurunuz"); 
            }
        }


        private void GeriDon()
        {
            this.Close();
            Application.OpenForms["HastaForm"].Show();
        }


        private void doktorİsimAl(object sender, EventArgs e)
        {
            cbx_doktorAd.Items.Clear();
            cbx_doktorAd.ResetText();
            sqlİslemler.goruntule($"select trim(ad)+space(1)+trim(soyad) from Doktor as d inner join Bolum as b on d.bolum_id=b.bolum_id where bolum_ad = '{cbx_bolum.SelectedItem}' ", cbx_doktorAd);
            cbx_doktorAd.Enabled = true;
        }

        private void hangiDoktorSecili(object sender, EventArgs e)
        {
            secilenDoktorid=sqlİslemler.goruntule($"select id from Doktor where trim(ad)+space(1)+trim(soyad)='{cbx_doktorAd.SelectedItem}' ");
        }

        private void GeriDon_Button_Click(object sender, EventArgs e)
        {
            GeriDon();
        }

        private void time_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region saat ve dakika ayır
            if (time_Combobox.SelectedItem.ToString().Length == 5)
            {
                secilenSaat = Convert.ToInt32(time_Combobox.SelectedItem.ToString().Substring(0, 2));
                secilenDakika = Convert.ToInt32(time_Combobox.SelectedItem.ToString().Substring(3, 2));
            }
            else
            {
                secilenSaat = Convert.ToInt32(time_Combobox.SelectedItem.ToString().Substring(0, 1));
                secilenDakika = Convert.ToInt32(time_Combobox.SelectedItem.ToString().Substring(2, 2));
            }
            #endregion
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
