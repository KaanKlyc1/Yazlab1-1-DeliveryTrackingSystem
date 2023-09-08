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
    public partial class Login : Form
    {
        public Şifre şifre;
        public Kayıt kayıt;
        public Arayüz arayüz;

        public Login()
        {
            InitializeComponent();
        }
        static Bağlantı con = new Bağlantı();

        private void btnGiriş_Click(object sender, EventArgs e)
        {
            try
            {
                con.client = new FireSharp.FirebaseClient(con.config);
                con.response = con.client.Get("Kullanıcılar/" + txtKullanıcı.Text);
                Kullanıcı kullanıcı = con.response.ResultAs<Kullanıcı>();
                if (txtKullanıcı.Text == kullanıcı.kAdı && txtŞifre.Text == kullanıcı.şifre)
                {
                   
                    arayüz = new Arayüz();
                    arayüz.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Kullanıcı adı veya şifre doğru değil!");
            }
            catch
            {
                MessageBox.Show("Bağlantı kurulamadı.");
            }
            
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            kayıt = new Kayıt();
            kayıt.Show();
            this.Hide();
        }

        private void btnŞifre_Click(object sender, EventArgs e)
        {
            şifre = new Şifre();
            şifre.Show();
            this.Hide();
        }
    }
}
