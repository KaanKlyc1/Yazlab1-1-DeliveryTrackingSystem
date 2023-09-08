
namespace YazLab1
{
    partial class Şifre
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
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnDeğiş = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtŞifre1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtŞifre2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtŞifre3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullanıcı = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(410, 308);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(121, 25);
            this.btnGeri.TabIndex = 18;
            this.btnGeri.Text = "Geri Dön";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnDeğiş
            // 
            this.btnDeğiş.Location = new System.Drawing.Point(207, 305);
            this.btnDeğiş.Name = "btnDeğiş";
            this.btnDeğiş.Size = new System.Drawing.Size(130, 28);
            this.btnDeğiş.TabIndex = 17;
            this.btnDeğiş.Text = "Şifre Değiştir";
            this.btnDeğiş.UseVisualStyleBackColor = true;
            this.btnDeğiş.Click += new System.EventHandler(this.btnDeğiş_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Eski Şifre:";
            // 
            // txtŞifre1
            // 
            this.txtŞifre1.Location = new System.Drawing.Point(330, 162);
            this.txtŞifre1.Margin = new System.Windows.Forms.Padding(4);
            this.txtŞifre1.Name = "txtŞifre1";
            this.txtŞifre1.Size = new System.Drawing.Size(132, 22);
            this.txtŞifre1.TabIndex = 14;
            this.txtŞifre1.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(325, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "ULAŞTIR KARGO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Yeni Şifre:";
            // 
            // txtŞifre2
            // 
            this.txtŞifre2.Location = new System.Drawing.Point(330, 199);
            this.txtŞifre2.Margin = new System.Windows.Forms.Padding(4);
            this.txtŞifre2.Name = "txtŞifre2";
            this.txtŞifre2.Size = new System.Drawing.Size(132, 22);
            this.txtŞifre2.TabIndex = 19;
            this.txtŞifre2.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tekrar Yeni Şifre:";
            // 
            // txtŞifre3
            // 
            this.txtŞifre3.Location = new System.Drawing.Point(330, 229);
            this.txtŞifre3.Margin = new System.Windows.Forms.Padding(4);
            this.txtŞifre3.Name = "txtŞifre3";
            this.txtŞifre3.Size = new System.Drawing.Size(132, 22);
            this.txtŞifre3.TabIndex = 21;
            this.txtŞifre3.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(206, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // txtKullanıcı
            // 
            this.txtKullanıcı.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanıcı.Location = new System.Drawing.Point(330, 123);
            this.txtKullanıcı.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullanıcı.Name = "txtKullanıcı";
            this.txtKullanıcı.Size = new System.Drawing.Size(132, 22);
            this.txtKullanıcı.TabIndex = 23;
            // 
            // Şifre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKullanıcı);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtŞifre3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtŞifre2);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnDeğiş);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtŞifre1);
            this.Controls.Add(this.label1);
            this.Name = "Şifre";
            this.Text = "Şifre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnDeğiş;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtŞifre1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtŞifre2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtŞifre3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullanıcı;
    }
}