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
    public partial class Kayıt : Form
    {
        public Kayıt()
        {
            InitializeComponent();
        }
        static Bağlantı con = new Bağlantı();
        
        
        private void btnTamamla_Click(object sender, EventArgs e)
        {
            try
            {
                con.client = new FireSharp.FirebaseClient(con.config);
            }
            catch 
            {
                MessageBox.Show("Bağlantı kurulamadı.");
            }
            if (txtŞifre.Text.Equals(txtŞifre2.Text))
            {
                Kullanıcı kullanıcı = new Kullanıcı()
                {
                    kAdı = txtKullanıcı.Text,
                    şifre = txtŞifre.Text
                };
                var setter = con.client.Set("Kullanıcılar/" + txtKullanıcı.Text, kullanıcı);
               
                txtKullanıcı.Text = "";
                txtŞifre.Text = "";
                txtŞifre2.Text = "";
            }
            else
                MessageBox.Show("Şifreler eşleşmiyor!");
            
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            
        }

       
    }
}
