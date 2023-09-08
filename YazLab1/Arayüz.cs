using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace YazLab1
{
    public partial class Arayüz : Form
    {
        public Arayüz()
        {
            InitializeComponent();
        }
        static Bağlantı con = new Bağlantı();
        public Form1 harita; 
        Dictionary<string, Sipariş> siparişler;
        

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                con.client = new FireSharp.FirebaseClient(con.config);
            }
            catch
            {
                MessageBox.Show("Bağlantı kurulamadı.");
            }
            Sipariş sipariş = new Sipariş()
            {
                TelNo = txtTel.Text,
                MüşteriAd = txtMüşteriAd.Text,
                MüşteriEnlem = Convert.ToDouble(txtMüşteriEn.Text),
                MüşteriBoylam = Convert.ToDouble(txtMüşteriBoy.Text),
                TeslimDurum = "Teslim Edilmedi"
            };
            var setter = con.client.Set("Siparişler/" + txtTel.Text, sipariş);
            txtTel.Text = "";
            txtMüşteriAd.Text = "";
            txtMüşteriBoy.Text = "";
            txtMüşteriEn.Text = "";
            güncelle();
        }

        private void Arayüz_Load(object sender, EventArgs e)
        {
            harita = new Form1();
            harita.Show();
            try
            {
                con.client = new FireSharp.FirebaseClient(con.config); 
            }
            catch
            {
                MessageBox.Show("Bağlantı kurulamadı.");
            }
            
            güncelle();
            
        }
        
        private async void güncelle()
        {
            
            try
            {
                tablo.Rows.Clear();
                var response = await con.client.GetAsync("Siparişler");
                siparişler = response.ResultAs<Dictionary<string, Sipariş>>();
                if (siparişler != null)
                {
                    foreach (var sipariş in siparişler)
                    {
                        tablo.Rows.Add(
                            sipariş.Value.TelNo,
                            sipariş.Value.MüşteriAd,
                            sipariş.Value.MüşteriEnlem,
                            sipariş.Value.MüşteriBoylam,
                            sipariş.Value.TeslimDurum
                        );
                    }
                }

            }
            catch
            {
                MessageBox.Show("Hata");
            }
            harita.Close();
            harita = new Form1();
            harita.Show();
        }

        private void btnTeslim_Click(object sender, EventArgs e)
        {
            try
            {
                con.client = new FireSharp.FirebaseClient(con.config);
            }
            catch
            {
                MessageBox.Show("Bağlantı kurulamadı.");
            }
            
            Sipariş sipariş1 = new Sipariş()
            {
                TelNo = txtTel.Text,
                MüşteriAd = txtMüşteriAd.Text,
                MüşteriEnlem = Convert.ToDouble(txtMüşteriEn.Text),
                MüşteriBoylam = Convert.ToDouble(txtMüşteriBoy.Text),
                TeslimDurum = "Teslim Edildi"
            };
            
            var setter = con.client.Update("Siparişler/" + txtTel.Text, sipariş1);
            MessageBox.Show("Kargo teslim edildi.");
            txtTel.Text = ""; 
            txtMüşteriAd.Text = "";
            txtMüşteriBoy.Text = "";
            txtMüşteriEn.Text = "";
            güncelle();
        }

        private void tablo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTel.Text = Convert.ToString(tablo.Rows[e.RowIndex].Cells[0].Value);
            txtMüşteriAd.Text = Convert.ToString(tablo.Rows[e.RowIndex].Cells[1].Value);
            txtMüşteriEn.Text = Convert.ToString(tablo.Rows[e.RowIndex].Cells[2].Value);
            txtMüşteriBoy.Text = Convert.ToString(tablo.Rows[e.RowIndex].Cells[3].Value);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            con.response = con.client.Delete("Siparişler/" + txtTel.Text);
            MessageBox.Show("Sipariş silindi.");
            txtTel.Text = "";
            txtMüşteriAd.Text = "";
            txtMüşteriBoy.Text = "";
            txtMüşteriEn.Text = "";
            güncelle();
        }
    }
}
