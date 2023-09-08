
namespace YazLab1
{
    partial class Kayıt
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtŞifre = new System.Windows.Forms.TextBox();
            this.txtKullanıcı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtŞifre2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // txtŞifre
            // 
            this.txtŞifre.Location = new System.Drawing.Point(321, 200);
            this.txtŞifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.Size = new System.Drawing.Size(132, 22);
            this.txtŞifre.TabIndex = 7;
            this.txtŞifre.UseSystemPasswordChar = true;
            // 
            // txtKullanıcı
            // 
            this.txtKullanıcı.Location = new System.Drawing.Point(321, 150);
            this.txtKullanıcı.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullanıcı.Name = "txtKullanıcı";
            this.txtKullanıcı.Size = new System.Drawing.Size(132, 22);
            this.txtKullanıcı.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(318, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "ULAŞTIR KARGO";
            // 
            // btnTamamla
            // 
            this.btnTamamla.Location = new System.Drawing.Point(200, 337);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(130, 28);
            this.btnTamamla.TabIndex = 10;
            this.btnTamamla.Text = "Kaydı Tamamla";
            this.btnTamamla.UseVisualStyleBackColor = true;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(428, 342);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(114, 23);
            this.btnGeri.TabIndex = 11;
            this.btnGeri.Text = "Geri Dön";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tekrar Şifre:";
            // 
            // txtŞifre2
            // 
            this.txtŞifre2.Location = new System.Drawing.Point(321, 247);
            this.txtŞifre2.Margin = new System.Windows.Forms.Padding(4);
            this.txtŞifre2.Name = "txtŞifre2";
            this.txtŞifre2.Size = new System.Drawing.Size(132, 22);
            this.txtŞifre2.TabIndex = 12;
            this.txtŞifre2.UseSystemPasswordChar = true;
            // 
            // Kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtŞifre2);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtŞifre);
            this.Controls.Add(this.txtKullanıcı);
            this.Controls.Add(this.label1);
            this.Name = "Kayıt";
            this.Text = "Kayıt";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtŞifre;
        private System.Windows.Forms.TextBox txtKullanıcı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtŞifre2;
    }
}