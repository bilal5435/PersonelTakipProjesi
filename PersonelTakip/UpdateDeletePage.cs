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
    public partial class UpdateDeletePage : Form
    {
        EmployeDBEntities employeDBEntities = new EmployeDBEntities();
       
        public UpdateDeletePage()
        {
            InitializeComponent();
        }

        private void UpdateDeletePage_Load(object sender, EventArgs e)
        {
           

            txtAd.Text = MainPage._TxtAd;
            txtSoyad.Text = MainPage._TxtSoyad;
            txtDogumTarihi.Text = MainPage._TxtDogumTarihi;
            txtTc.Text = MainPage._TxtTc;
            txtGorev.Text = MainPage._TxtGorev;
            txtId.Text = MainPage._TxtId;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            Employe kayit = employeDBEntities.Employe.Find(id);
            employeDBEntities.Employe.Remove(kayit);
            employeDBEntities.SaveChanges();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            Employe kayit = employeDBEntities.Employe.Find(id);
            kayit.Ad = txtAd.Text;
            kayit.Soyad = txtSoyad.Text;
            kayit.Tc = txtTc.Text;
            kayit.DogumTarihi = Convert.ToDateTime(txtDogumTarihi.Text);
            kayit.Gorev = txtGorev.Text;
            employeDBEntities.SaveChanges();
        }
    }
}
