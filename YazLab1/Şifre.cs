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
    public partial class Şifre : Form
    {
        public Şifre()
        {
            InitializeComponent();
        }
        static Bağlantı con = new Bağlantı();

        private void btnDeğiş_Click(object sender, EventArgs e)
        {
            try
            {
                con.client = new FireSharp.FirebaseClient(con.config);
                con.response = con.client.Get("Kullanıcılar/" + txtKullanıcı.Text);
                Kullanıcı kullanıcı = con.response.ResultAs<Kullanıcı>();
                if (txtKullanıcı.Text != kullanıcı.kAdı || txtŞifre1.Text != kullanıcı.şifre)
                {
                    MessageBox.Show("Kullanıcı adı veya şifre doğru değil!");
                }
                else
                {
                    if (txtŞifre2.Text.Equals(txtŞifre3.Text))
                    {
                        Kullanıcı kullanıcı1 = new Kullanıcı()
                        {
                            kAdı = txtKullanıcı.Text,
                            şifre = txtŞifre2.Text
                        };
                        var setter = con.client.Update("Kullanıcılar/" + txtKullanıcı.Text, kullanıcı1);
                        txtKullanıcı.Text = "";
                        txtŞifre1.Text = "";
                        txtŞifre2.Text = "";
                        txtŞifre3.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Şifreler eşleşmiyor!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bağlantı kurulamadı.");
            }
           

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }
    }
}
