﻿
namespace Proje_Hastane_Yonetim_Otomasyon_Sistemi
{
    partial class HastaUyeOl
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
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.MskKimlikNo = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonKayitOl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(210, 46);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(225, 31);
            this.textBoxAd.TabIndex = 1;
            // 
            // MskKimlikNo
            // 
            this.MskKimlikNo.Location = new System.Drawing.Point(210, 119);
            this.MskKimlikNo.Mask = "00000000000";
            this.MskKimlikNo.Name = "MskKimlikNo";
            this.MskKimlikNo.Size = new System.Drawing.Size(225, 31);
            this.MskKimlikNo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "TC Kimlik No:";
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(210, 82);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(225, 31);
            this.textBoxSoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Soyad:";
            // 
            // maskedTextBoxTelefon
            // 
            this.maskedTextBoxTelefon.Location = new System.Drawing.Point(210, 157);
            this.maskedTextBoxTelefon.Mask = "00000000000";
            this.maskedTextBoxTelefon.Name = "maskedTextBoxTelefon";
            this.maskedTextBoxTelefon.Size = new System.Drawing.Size(225, 31);
            this.maskedTextBoxTelefon.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Telefon:";
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(210, 191);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(225, 31);
            this.textBoxSifre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Şifre:";
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(210, 228);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(225, 33);
            this.comboBoxCinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cinsiyet";
            // 
            // buttonKayitOl
            // 
            this.buttonKayitOl.Location = new System.Drawing.Point(226, 287);
            this.buttonKayitOl.Name = "buttonKayitOl";
            this.buttonKayitOl.Size = new System.Drawing.Size(142, 57);
            this.buttonKayitOl.TabIndex = 7;
            this.buttonKayitOl.Text = "Kayıt Ol";
            this.buttonKayitOl.UseVisualStyleBackColor = true;
            this.buttonKayitOl.Click += new System.EventHandler(this.buttonKayitOl_Click);
            // 
            // HastaUyeOl
            // 
            this.AcceptButton = this.buttonKayitOl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(565, 433);
            this.Controls.Add(this.buttonKayitOl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxCinsiyet);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBoxTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.MskKimlikNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.Name = "HastaUyeOl";
            this.Text = "HastaUyeOl";
            this.Load += new System.EventHandler(this.HastaUyeOl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.MaskedTextBox MskKimlikNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonKayitOl;
    }
}