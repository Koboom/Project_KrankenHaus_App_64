
namespace Proje_Hastane_Yonetim_Otomasyon_Sistemi
{
    partial class FormGirisler
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGirisler));
            this.buttonHastaGİris = new System.Windows.Forms.Button();
            this.buttonDoktorGiris = new System.Windows.Forms.Button();
            this.buttonSekreterGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHastaGİris
            // 
            this.buttonHastaGİris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHastaGİris.BackgroundImage")));
            this.buttonHastaGİris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHastaGİris.Location = new System.Drawing.Point(82, 272);
            this.buttonHastaGİris.Name = "buttonHastaGİris";
            this.buttonHastaGİris.Size = new System.Drawing.Size(290, 174);
            this.buttonHastaGİris.TabIndex = 1;
            this.buttonHastaGİris.UseVisualStyleBackColor = true;
            this.buttonHastaGİris.Click += new System.EventHandler(this.buttonHastaGİris_Click);
            // 
            // buttonDoktorGiris
            // 
            this.buttonDoktorGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDoktorGiris.BackgroundImage")));
            this.buttonDoktorGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDoktorGiris.Location = new System.Drawing.Point(413, 272);
            this.buttonDoktorGiris.Name = "buttonDoktorGiris";
            this.buttonDoktorGiris.Size = new System.Drawing.Size(290, 174);
            this.buttonDoktorGiris.TabIndex = 2;
            this.buttonDoktorGiris.UseVisualStyleBackColor = true;
            this.buttonDoktorGiris.Click += new System.EventHandler(this.buttonDoktorGiris_Click);
            // 
            // buttonSekreterGiris
            // 
            this.buttonSekreterGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSekreterGiris.BackgroundImage")));
            this.buttonSekreterGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSekreterGiris.Location = new System.Drawing.Point(746, 272);
            this.buttonSekreterGiris.Name = "buttonSekreterGiris";
            this.buttonSekreterGiris.Size = new System.Drawing.Size(290, 174);
            this.buttonSekreterGiris.TabIndex = 3;
            this.buttonSekreterGiris.UseVisualStyleBackColor = true;
            this.buttonSekreterGiris.Click += new System.EventHandler(this.buttonSekreterGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(851, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(567, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(44, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(318, 209);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // FormGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1085, 554);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSekreterGiris);
            this.Controls.Add(this.buttonDoktorGiris);
            this.Controls.Add(this.buttonHastaGİris);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FormGirisler";
            this.Text = "ANA MENÜ";
            this.Load += new System.EventHandler(this.FormGirisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHastaGİris;
        private System.Windows.Forms.Button buttonDoktorGiris;
        private System.Windows.Forms.Button buttonSekreterGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

