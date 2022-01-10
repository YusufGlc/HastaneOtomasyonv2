
namespace HastaneOtomasyon
{
    partial class DoktorForm
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
            this.RandevularımButton = new System.Windows.Forms.Button();
            this.CıkısButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RandevularımButton
            // 
            this.RandevularımButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RandevularımButton.FlatAppearance.BorderSize = 0;
            this.RandevularımButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.RandevularımButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandevularımButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RandevularımButton.Location = new System.Drawing.Point(43, 99);
            this.RandevularımButton.Name = "RandevularımButton";
            this.RandevularımButton.Size = new System.Drawing.Size(176, 41);
            this.RandevularımButton.TabIndex = 0;
            this.RandevularımButton.Text = "Randevularım";
            this.RandevularımButton.UseVisualStyleBackColor = false;
            this.RandevularımButton.Click += new System.EventHandler(this.RandevularımButton_Click);
            // 
            // CıkısButton
            // 
            this.CıkısButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CıkısButton.FlatAppearance.BorderSize = 0;
            this.CıkısButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.CıkısButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CıkısButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CıkısButton.Location = new System.Drawing.Point(43, 201);
            this.CıkısButton.Name = "CıkısButton";
            this.CıkısButton.Size = new System.Drawing.Size(176, 41);
            this.CıkısButton.TabIndex = 1;
            this.CıkısButton.Text = "Çıkış Yap";
            this.CıkısButton.UseVisualStyleBackColor = false;
            this.CıkısButton.Click += new System.EventHandler(this.CıkısButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = global::HastaneOtomasyon.Properties.Resources.close;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(201, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(42, 33);
            this.exitButton.TabIndex = 2;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // DoktorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(255, 335);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.CıkısButton);
            this.Controls.Add(this.RandevularımButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoktorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RandevularımButton;
        private System.Windows.Forms.Button CıkısButton;
        private System.Windows.Forms.Button exitButton;
    }
}