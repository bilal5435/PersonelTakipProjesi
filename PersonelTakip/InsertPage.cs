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
    public partial class InsertPage : Form
    {
        public InsertPage()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            InsertPage insertPage = new InsertPage();
            EmployeDBEntities employeDBEntities = new EmployeDBEntities();
            Employe employe = new Employe();
            employe.Ad = txtAd.Text;
            employe.Soyad = txtSoyad.Text;
            employe.DogumTarihi =  Convert.ToDateTime(txtDogumTarihi.Text);
            employe.Tc = txtTc.Text;
            employe.Gorev = txtGorev.Text;
            employeDBEntities.Employe.Add(employe);
            employeDBEntities.SaveChanges();
            insertPage.Close();


        }
    }
}
