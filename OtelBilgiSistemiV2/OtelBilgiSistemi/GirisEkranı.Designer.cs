﻿namespace OtelBilgiSistemi
{
    partial class GirisEkranı
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
            this.labelKadı = new System.Windows.Forms.Label();
            this.labelSifre = new System.Windows.Forms.Label();
            this.textBoxKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelKadı
            // 
            this.labelKadı.AutoSize = true;
            this.labelKadı.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKadı.Location = new System.Drawing.Point(89, 176);
            this.labelKadı.Name = "labelKadı";
            this.labelKadı.Size = new System.Drawing.Size(113, 22);
            this.labelKadı.TabIndex = 0;
            this.labelKadı.Text = "Kullanıcı Adı:";
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSifre.Location = new System.Drawing.Point(108, 230);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(57, 22);
            this.labelSifre.TabIndex = 1;
            this.labelSifre.Text = "Şifre: ";
            // 
            // textBoxKullanıcıAdı
            // 
            this.textBoxKullanıcıAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKullanıcıAdı.Location = new System.Drawing.Point(208, 176);
            this.textBoxKullanıcıAdı.Name = "textBoxKullanıcıAdı";
            this.textBoxKullanıcıAdı.Size = new System.Drawing.Size(148, 27);
            this.textBoxKullanıcıAdı.TabIndex = 2;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSifre.Location = new System.Drawing.Point(208, 227);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(148, 27);
            this.textBoxSifre.TabIndex = 3;
            this.textBoxSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(108, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "xx Oteline Hoşgeldiniz..";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(152, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(448, 382);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxKullanıcıAdı);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.labelKadı);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Kullanıcı Girişi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKadı;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.TextBox textBoxKullanıcıAdı;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

