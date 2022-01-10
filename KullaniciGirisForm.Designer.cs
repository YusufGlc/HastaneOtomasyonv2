
namespace HastaneOtomasyon
{
    partial class KullaniciGirisForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.hastaGiris = new System.Windows.Forms.TabPage();
            this.check_hastaSifre = new System.Windows.Forms.CheckBox();
            this.hastaKayıt_Button = new System.Windows.Forms.Button();
            this.hastaGirisButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hastaTextBox2 = new System.Windows.Forms.TextBox();
            this.hastaTextBox1 = new System.Windows.Forms.TextBox();
            this.doktorGiris = new System.Windows.Forms.TabPage();
            this.check_doktorSifre = new System.Windows.Forms.CheckBox();
            this.doktorGirisButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.doktorTextBox2 = new System.Windows.Forms.TextBox();
            this.doktorTextBox1 = new System.Windows.Forms.TextBox();
            this.adminGiris = new System.Windows.Forms.TabPage();
            this.check_adminSifre = new System.Windows.Forms.CheckBox();
            this.adminGirisButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.adminTextBox2 = new System.Windows.Forms.TextBox();
            this.adminTextBox1 = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.hastaGiris.SuspendLayout();
            this.doktorGiris.SuspendLayout();
            this.adminGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.hastaGiris);
            this.tabControl1.Controls.Add(this.doktorGiris);
            this.tabControl1.Controls.Add(this.adminGiris);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 50);
            this.tabControl1.Location = new System.Drawing.Point(0, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(603, 433);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // hastaGiris
            // 
            this.hastaGiris.BackColor = System.Drawing.Color.DarkCyan;
            this.hastaGiris.Controls.Add(this.check_hastaSifre);
            this.hastaGiris.Controls.Add(this.hastaKayıt_Button);
            this.hastaGiris.Controls.Add(this.hastaGirisButton);
            this.hastaGiris.Controls.Add(this.label2);
            this.hastaGiris.Controls.Add(this.label1);
            this.hastaGiris.Controls.Add(this.hastaTextBox2);
            this.hastaGiris.Controls.Add(this.hastaTextBox1);
            this.hastaGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaGiris.Location = new System.Drawing.Point(4, 54);
            this.hastaGiris.Name = "hastaGiris";
            this.hastaGiris.Size = new System.Drawing.Size(595, 375);
            this.hastaGiris.TabIndex = 0;
            this.hastaGiris.Text = "Hasta Giriş";
            // 
            // check_hastaSifre
            // 
            this.check_hastaSifre.AutoSize = true;
            this.check_hastaSifre.Location = new System.Drawing.Point(467, 161);
            this.check_hastaSifre.Name = "check_hastaSifre";
            this.check_hastaSifre.Size = new System.Drawing.Size(70, 21);
            this.check_hastaSifre.TabIndex = 15;
            this.check_hastaSifre.Text = "Göster";
            this.check_hastaSifre.UseVisualStyleBackColor = true;
            this.check_hastaSifre.CheckedChanged += new System.EventHandler(this.check_hastaSifre_CheckedChanged);
            // 
            // hastaKayıt_Button
            // 
            this.hastaKayıt_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.hastaKayıt_Button.FlatAppearance.BorderSize = 0;
            this.hastaKayıt_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.hastaKayıt_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hastaKayıt_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaKayıt_Button.Location = new System.Drawing.Point(265, 277);
            this.hastaKayıt_Button.Name = "hastaKayıt_Button";
            this.hastaKayıt_Button.Size = new System.Drawing.Size(155, 35);
            this.hastaKayıt_Button.TabIndex = 5;
            this.hastaKayıt_Button.Text = "Kayıt Ol";
            this.hastaKayıt_Button.UseVisualStyleBackColor = false;
            this.hastaKayıt_Button.Click += new System.EventHandler(this.hastaKayıt_Button_Click);
            // 
            // hastaGirisButton
            // 
            this.hastaGirisButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.hastaGirisButton.FlatAppearance.BorderSize = 0;
            this.hastaGirisButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.hastaGirisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hastaGirisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaGirisButton.Location = new System.Drawing.Point(265, 221);
            this.hastaGirisButton.Name = "hastaGirisButton";
            this.hastaGirisButton.Size = new System.Drawing.Size(155, 35);
            this.hastaGirisButton.TabIndex = 4;
            this.hastaGirisButton.Text = "Giriş Yap";
            this.hastaGirisButton.UseVisualStyleBackColor = false;
            this.hastaGirisButton.Click += new System.EventHandler(this.hastaGirisButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(100, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(100, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tc No";
            // 
            // hastaTextBox2
            // 
            this.hastaTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaTextBox2.Location = new System.Drawing.Point(241, 159);
            this.hastaTextBox2.MaxLength = 30;
            this.hastaTextBox2.Name = "hastaTextBox2";
            this.hastaTextBox2.Size = new System.Drawing.Size(196, 23);
            this.hastaTextBox2.TabIndex = 1;
            this.hastaTextBox2.UseSystemPasswordChar = true;
            // 
            // hastaTextBox1
            // 
            this.hastaTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaTextBox1.Location = new System.Drawing.Point(241, 107);
            this.hastaTextBox1.MaxLength = 11;
            this.hastaTextBox1.Name = "hastaTextBox1";
            this.hastaTextBox1.Size = new System.Drawing.Size(196, 23);
            this.hastaTextBox1.TabIndex = 0;
            // 
            // doktorGiris
            // 
            this.doktorGiris.BackColor = System.Drawing.Color.DarkCyan;
            this.doktorGiris.Controls.Add(this.check_doktorSifre);
            this.doktorGiris.Controls.Add(this.doktorGirisButton);
            this.doktorGiris.Controls.Add(this.label3);
            this.doktorGiris.Controls.Add(this.label4);
            this.doktorGiris.Controls.Add(this.doktorTextBox2);
            this.doktorGiris.Controls.Add(this.doktorTextBox1);
            this.doktorGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktorGiris.Location = new System.Drawing.Point(4, 54);
            this.doktorGiris.Name = "doktorGiris";
            this.doktorGiris.Size = new System.Drawing.Size(595, 375);
            this.doktorGiris.TabIndex = 1;
            this.doktorGiris.Text = "Doktor Giriş";
            // 
            // check_doktorSifre
            // 
            this.check_doktorSifre.AutoSize = true;
            this.check_doktorSifre.Location = new System.Drawing.Point(467, 161);
            this.check_doktorSifre.Name = "check_doktorSifre";
            this.check_doktorSifre.Size = new System.Drawing.Size(70, 21);
            this.check_doktorSifre.TabIndex = 15;
            this.check_doktorSifre.Text = "Göster";
            this.check_doktorSifre.UseVisualStyleBackColor = true;
            this.check_doktorSifre.CheckedChanged += new System.EventHandler(this.check_doktorSifre_CheckedChanged);
            // 
            // doktorGirisButton
            // 
            this.doktorGirisButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.doktorGirisButton.FlatAppearance.BorderSize = 0;
            this.doktorGirisButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.doktorGirisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doktorGirisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktorGirisButton.Location = new System.Drawing.Point(265, 221);
            this.doktorGirisButton.Name = "doktorGirisButton";
            this.doktorGirisButton.Size = new System.Drawing.Size(155, 35);
            this.doktorGirisButton.TabIndex = 9;
            this.doktorGirisButton.Text = "Giriş Yap";
            this.doktorGirisButton.UseVisualStyleBackColor = false;
            this.doktorGirisButton.Click += new System.EventHandler(this.doktorGirisButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(100, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(100, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // doktorTextBox2
            // 
            this.doktorTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktorTextBox2.Location = new System.Drawing.Point(241, 159);
            this.doktorTextBox2.MaxLength = 30;
            this.doktorTextBox2.Name = "doktorTextBox2";
            this.doktorTextBox2.Size = new System.Drawing.Size(196, 23);
            this.doktorTextBox2.TabIndex = 6;
            this.doktorTextBox2.UseSystemPasswordChar = true;
            // 
            // doktorTextBox1
            // 
            this.doktorTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doktorTextBox1.Location = new System.Drawing.Point(241, 107);
            this.doktorTextBox1.MaxLength = 20;
            this.doktorTextBox1.Name = "doktorTextBox1";
            this.doktorTextBox1.Size = new System.Drawing.Size(196, 23);
            this.doktorTextBox1.TabIndex = 5;
            // 
            // adminGiris
            // 
            this.adminGiris.BackColor = System.Drawing.Color.DarkCyan;
            this.adminGiris.Controls.Add(this.check_adminSifre);
            this.adminGiris.Controls.Add(this.adminGirisButton);
            this.adminGiris.Controls.Add(this.label5);
            this.adminGiris.Controls.Add(this.label6);
            this.adminGiris.Controls.Add(this.adminTextBox2);
            this.adminGiris.Controls.Add(this.adminTextBox1);
            this.adminGiris.Location = new System.Drawing.Point(4, 54);
            this.adminGiris.Name = "adminGiris";
            this.adminGiris.Size = new System.Drawing.Size(595, 375);
            this.adminGiris.TabIndex = 2;
            this.adminGiris.Text = "Admin Giriş";
            // 
            // check_adminSifre
            // 
            this.check_adminSifre.AutoSize = true;
            this.check_adminSifre.Location = new System.Drawing.Point(467, 161);
            this.check_adminSifre.Name = "check_adminSifre";
            this.check_adminSifre.Size = new System.Drawing.Size(70, 21);
            this.check_adminSifre.TabIndex = 15;
            this.check_adminSifre.Text = "Göster";
            this.check_adminSifre.UseVisualStyleBackColor = true;
            this.check_adminSifre.CheckedChanged += new System.EventHandler(this.check_adminSifre_CheckedChanged);
            // 
            // adminGirisButton
            // 
            this.adminGirisButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.adminGirisButton.FlatAppearance.BorderSize = 0;
            this.adminGirisButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.adminGirisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminGirisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminGirisButton.Location = new System.Drawing.Point(265, 221);
            this.adminGirisButton.Name = "adminGirisButton";
            this.adminGirisButton.Size = new System.Drawing.Size(155, 35);
            this.adminGirisButton.TabIndex = 14;
            this.adminGirisButton.Text = "Giriş Yap";
            this.adminGirisButton.UseVisualStyleBackColor = false;
            this.adminGirisButton.Click += new System.EventHandler(this.adminGirisButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(100, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Şifre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(100, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kullanıcı Adı";
            // 
            // adminTextBox2
            // 
            this.adminTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminTextBox2.Location = new System.Drawing.Point(241, 159);
            this.adminTextBox2.MaxLength = 30;
            this.adminTextBox2.Name = "adminTextBox2";
            this.adminTextBox2.Size = new System.Drawing.Size(196, 23);
            this.adminTextBox2.TabIndex = 11;
            this.adminTextBox2.UseSystemPasswordChar = true;
            // 
            // adminTextBox1
            // 
            this.adminTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminTextBox1.Location = new System.Drawing.Point(241, 107);
            this.adminTextBox1.MaxLength = 20;
            this.adminTextBox1.Name = "adminTextBox1";
            this.adminTextBox1.Size = new System.Drawing.Size(196, 23);
            this.adminTextBox1.TabIndex = 10;
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = global::HastaneOtomasyon.Properties.Resources.close;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(540, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(42, 33);
            this.exitButton.TabIndex = 1;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // KullaniciGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 477);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "KullaniciGirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş";
            this.Load += new System.EventHandler(this.KullaniciGirisForm_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.hastaGiris.ResumeLayout(false);
            this.hastaGiris.PerformLayout();
            this.doktorGiris.ResumeLayout(false);
            this.doktorGiris.PerformLayout();
            this.adminGiris.ResumeLayout(false);
            this.adminGiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage hastaGiris;
        private System.Windows.Forms.TabPage doktorGiris;
        private System.Windows.Forms.Button hastaKayıt_Button;
        private System.Windows.Forms.Button hastaGirisButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hastaTextBox2;
        private System.Windows.Forms.TextBox hastaTextBox1;
        private System.Windows.Forms.Button doktorGirisButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox doktorTextBox2;
        private System.Windows.Forms.TextBox doktorTextBox1;
        private System.Windows.Forms.TabPage adminGiris;
        private System.Windows.Forms.Button adminGirisButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adminTextBox2;
        private System.Windows.Forms.TextBox adminTextBox1;
        private System.Windows.Forms.CheckBox check_hastaSifre;
        private System.Windows.Forms.CheckBox check_doktorSifre;
        private System.Windows.Forms.CheckBox check_adminSifre;
        private System.Windows.Forms.Button exitButton;
    }
}

