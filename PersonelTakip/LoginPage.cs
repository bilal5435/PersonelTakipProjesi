using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakip
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            EmployeDBEntities employeDBEntities = new EmployeDBEntities();

            string kullanici_adi = employeDBEntities.Login.Select(x => x.KullaniciAdi).First();
            string sifre = employeDBEntities.Login.Select(x => x.Sifre).First();

            if (txtUserName.Text == kullanici_adi && txtPassword.Text == sifre)
            {
                
                mainPage.Show();
                lblAlert.Text = "";
            }
            else
            {
                lblAlert.Text = "Kullanıcı adı ya da şifre hatalı !";
            }
        }
    }
}
