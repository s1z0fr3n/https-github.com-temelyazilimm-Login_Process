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
    public partial class KullanıcıBilgileri : Form
    {
        public KullanıcıBilgileri()
        {
            InitializeComponent();
        }
        SignInDal loginDal = new SignInDal();
        private void KullanıcıBilgileri_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = loginDal.GetAll().ToList();
        }

        private void btnForm1Don_Click(object sender, EventArgs e)
        {
            AnaGirisEkrani anaGirisEkrani = new AnaGirisEkrani();
            anaGirisEkrani.Show();
            this.Hide();
        }
    }
}
