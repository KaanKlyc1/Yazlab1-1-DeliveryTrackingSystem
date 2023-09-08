
namespace YazLab1
{
    partial class Arayüz
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTeslim = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMüşteriAd = new System.Windows.Forms.TextBox();
            this.txtMüşteriEn = new System.Windows.Forms.TextBox();
            this.txtMüşteriBoy = new System.Windows.Forms.TextBox();
            this.tablo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(94, 261);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(98, 31);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Sipariş Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTeslim
            // 
            this.btnTeslim.Location = new System.Drawing.Point(94, 319);
            this.btnTeslim.Name = "btnTeslim";
            this.btnTeslim.Size = new System.Drawing.Size(98, 29);
            this.btnTeslim.TabIndex = 3;
            this.btnTeslim.Text = "Teslim Et";
            this.btnTeslim.UseVisualStyleBackColor = true;
            this.btnTeslim.Click += new System.EventHandler(this.btnTeslim_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(94, 384);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(98, 29);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sipariş Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Müşteri Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Müşteri Enlem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Müşteri Boylam:";
            // 
            // txtMüşteriAd
            // 
            this.txtMüşteriAd.Location = new System.Drawing.Point(149, 113);
            this.txtMüşteriAd.Name = "txtMüşteriAd";
            this.txtMüşteriAd.Size = new System.Drawing.Size(100, 22);
            this.txtMüşteriAd.TabIndex = 8;
            // 
            // txtMüşteriEn
            // 
            this.txtMüşteriEn.Location = new System.Drawing.Point(149, 154);
            this.txtMüşteriEn.Name = "txtMüşteriEn";
            this.txtMüşteriEn.Size = new System.Drawing.Size(100, 22);
            this.txtMüşteriEn.TabIndex = 9;
            // 
            // txtMüşteriBoy
            // 
            this.txtMüşteriBoy.Location = new System.Drawing.Point(149, 200);
            this.txtMüşteriBoy.Name = "txtMüşteriBoy";
            this.txtMüşteriBoy.Size = new System.Drawing.Size(100, 22);
            this.txtMüşteriBoy.TabIndex = 10;
            // 
            // tablo
            // 
            this.tablo.AllowUserToAddRows = false;
            this.tablo.AllowUserToDeleteRows = false;
            this.tablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.tablo.Location = new System.Drawing.Point(294, 48);
            this.tablo.Name = "tablo";
            this.tablo.ReadOnly = true;
            this.tablo.RowHeadersWidth = 51;
            this.tablo.RowTemplate.Height = 24;
            this.tablo.Size = new System.Drawing.Size(468, 325);
            this.tablo.TabIndex = 11;
            this.tablo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablo_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TelNo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "MüşteriAd";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "MüşteriEnlem";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "MüşteriBoylam";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TeslimDurum";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tel No:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(149, 72);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 22);
            this.txtTel.TabIndex = 13;
            // 
            // Arayüz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tablo);
            this.Controls.Add(this.txtMüşteriBoy);
            this.Controls.Add(this.txtMüşteriEn);
            this.Controls.Add(this.txtMüşteriAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnTeslim);
            this.Controls.Add(this.btnEkle);
            this.Name = "Arayüz";
            this.Text = "Teslimat Ekranı";
            this.Load += new System.EventHandler(this.Arayüz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTeslim;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMüşteriAd;
        private System.Windows.Forms.TextBox txtMüşteriEn;
        private System.Windows.Forms.TextBox txtMüşteriBoy;
        private System.Windows.Forms.DataGridView tablo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTel;
    }
}