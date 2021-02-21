using Login_Process.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Process
{

    public partial class AnaGirisEkrani : Form
    {
        SignInDal loginDal = new SignInDal();

        public AnaGirisEkrani()
        {
            InitializeComponent();

        }

     

        int hak = 2, sayi;
        Random rastgele = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            textKod.Clear();
            var usernameresult = loginDal.GetSign(t => t.UserName == textUserName.Text);
            var passwordresult = loginDal.GetSign(t => t.UserPassword == textPassword.Text);

            if (passwordresult == null || usernameresult == null)
            {

                MessageBox.Show("Bilgileriniz uyuşmuyor.Lütfen kullanıcı adı veya parolanızı tekrar giriniz!!!");

                label4.Visible = true;
                label4.ForeColor = Color.Red;
                hak -= 1;
                label4.Text = "Giriş Hakkınız:" + hak;
            }
            if (hak == 0)
            {
                btnSignIn.Enabled = false;
                label3.ForeColor = Color.Red;
                label3.Visible = true;
                groupUI.Visible = false;
                groupKod.Location = new Point(34, 12);
                groupKod.Visible = true;        
                textPassword.Clear();
                textUserName.Clear();
            }

            if(passwordresult != null && usernameresult != null)
            {
                AnaSayfa anaSayfa = new AnaSayfa();
                anaSayfa.Show();
                this.Hide();
            }


          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textUserName.Focus();
            label4.Visible = false;
            label3.Visible = false;

            sayi = rastgele.Next(1000, 9000);
            lblKod.Text = "" + sayi;
            groupKod.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            KullanıcıBilgileri form2 = new KullanıcıBilgileri();
            form2.Show();
            this.Hide();
        }

        private void btnKod_Click(object sender, EventArgs e)
        {
            try
            {
                if (sayi != Convert.ToInt32(textKod.Text))
                {
                    MessageBox.Show("Doğrulama Kodunu Yanlış Lütfen Tekrar Deneyiniz!!!");
                    sayi = rastgele.Next(1000, 9000);
                    lblKod.Text = "" + sayi;
                    textKod.Clear();
                }
                else
                {
                    MessageBox.Show("Kodunuz Doğru Lütfen Şifrenizi Tekrar Deneyiniz!!!");
                    groupKod.Visible = false;
                    groupUI.Visible = true;
                    btnSignIn.Enabled = true;
                    label3.Visible = false;
                    hak = 5;
                    label4.Visible = true;
                }
               
            }
            catch
            {
                if (String.IsNullOrEmpty(textKod.Text))
                {
                    MessageBox.Show("Kod Alanını Boş Bırakmayınız!!!");
                }
              
            }


        }
    }
}
