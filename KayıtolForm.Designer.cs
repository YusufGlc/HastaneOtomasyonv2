
namespace HastaneOtomasyon
{
    partial class HastaKayitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.TextBox();
            this.Kayit_Button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.sifreTekrar = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tcno
            // 
            this.tcno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcno.ForeColor = System.Drawing.Color.Silver;
            this.tcno.Location = new System.Drawing.Point(124, 44);
            this.tcno.MaxLength = 11;
            this.tcno.Name = "tcno";
            this.tcno.Size = new System.Drawing.Size(156, 23);
            this.tcno.TabIndex = 0;
            this.tcno.Text = "Tc No";
            this.tcno.Enter += new System.EventHandler(this.tcno_Enter);
            this.tcno.Leave += new System.EventHandler(this.tcno_Leave);
            this.tcno.MouseEnter += new System.EventHandler(this.tcno_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tc No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(43, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad";
            // 
            // ad
            // 
            this.ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad.ForeColor = System.Drawing.Color.Silver;
            this.ad.Location = new System.Drawing.Point(124, 93);
            this.ad.MaxLength = 20;
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(156, 23);
            this.ad.TabIndex = 2;
            this.ad.Text = "Ad";
            this.ad.Enter += new System.EventHandler(this.ad_Enter);
            this.ad.Leave += new System.EventHandler(this.ad_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyad";
            // 
            // soyad
            // 
            this.soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyad.ForeColor = System.Drawing.Color.Silver;
            this.soyad.Location = new System.Drawing.Point(124, 141);
            this.soyad.MaxLength = 20;
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(156, 23);
            this.soyad.TabIndex = 4;
            this.soyad.Text = "Soyad";
            this.soyad.Enter += new System.EventHandler(this.soyad_Enter);
            this.soyad.Leave += new System.EventHandler(this.soyad_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şifre";
            // 
            // sifre
            // 
            this.sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.ForeColor = System.Drawing.Color.Silver;
            this.sifre.Location = new System.Drawing.Point(124, 192);
            this.sifre.MaxLength = 30;
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(156, 23);
            this.sifre.TabIndex = 6;
            this.sifre.Text = "****";
            this.sifre.UseSystemPasswordChar = true;
            this.sifre.Enter += new System.EventHandler(this.sifre_Enter);
            this.sifre.Leave += new System.EventHandler(this.sifre_Leave);
            // 
            // Kayit_Button
            // 
            this.Kayit_Button.BackColor = System.Drawing.Color.White;
            this.Kayit_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Kayit_Button.FlatAppearance.BorderSize = 0;
            this.Kayit_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Kayit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kayit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kayit_Button.Location = new System.Drawing.Point(124, 282);
            this.Kayit_Button.Name = "Kayit_Button";
            this.Kayit_Button.Size = new System.Drawing.Size(145, 49);
            this.Kayit_Button.TabIndex = 8;
            this.Kayit_Button.Text = "Kayıt Ol";
            this.Kayit_Button.UseVisualStyleBackColor = false;
            this.Kayit_Button.Click += new System.EventHandler(this.Kayit_Button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Şifre Tekrar";
            // 
            // sifreTekrar
            // 
            this.sifreTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTekrar.ForeColor = System.Drawing.Color.Silver;
            this.sifreTekrar.Location = new System.Drawing.Point(124, 232);
            this.sifreTekrar.MaxLength = 30;
            this.sifreTekrar.Name = "sifreTekrar";
            this.sifreTekrar.Size = new System.Drawing.Size(156, 23);
            this.sifreTekrar.TabIndex = 12;
            this.sifreTekrar.Text = "****";
            this.sifreTekrar.UseSystemPasswordChar = true;
            this.sifreTekrar.Enter += new System.EventHandler(this.sifreTekrar_Enter);
            this.sifreTekrar.Leave += new System.EventHandler(this.sifreTekrar_Leave);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(297, 214);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::HastaneOtomasyon.Properties.Resources.geri_don;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(16, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 46);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.geriDon_ButtonClick);
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = global::HastaneOtomasyon.Properties.Resources.close;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(327, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(42, 33);
            this.exitButton.TabIndex = 28;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImage = global::HastaneOtomasyon.Properties.Resources.minimize_icon_29;
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(284, 12);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(37, 33);
            this.minimizeButton.TabIndex = 45;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // HastaKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(381, 403);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sifreTekrar);
            this.Controls.Add(this.Kayit_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HastaKayitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tcno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Button Kayit_Button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sifreTekrar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minimizeButton;
    }
}