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
    public partial class MainPage : Form
    {
        public static string _TxtId = "";
        public static string _TxtAd = "";
        public static string _TxtSoyad = "";
        public static string _TxtDogumTarihi = "";
        public static string _TxtTc = "";
        public static string _TxtGorev = "";
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            EmployeDBEntities employeDBEntities = new EmployeDBEntities();
            dtgrdList.DataSource = employeDBEntities.Employe.ToList();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InsertPage insertPage = new InsertPage();
            insertPage.Show();


        }

        private void dtgrdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
                {
                 DataGridViewRow row = dtgrdList.Rows[e.RowIndex];
                _TxtId = row.Cells[0].Value.ToString();
                _TxtAd = row.Cells[1].Value.ToString();
                _TxtSoyad = row.Cells[2].Value.ToString();
                _TxtDogumTarihi = row.Cells[3].Value.ToString();
                _TxtTc = row.Cells[4].Value.ToString();

                _TxtGorev = row.Cells[5].Value.ToString();
            }
            UpdateDeletePage updateDeletePage = new UpdateDeletePage();
            updateDeletePage.Show();




            //UpdateDeletePage updateDeletePage = new UpdateDeletePage();
            //foreach (DataGridViewRow row in dtgrdList.SelectedRows[0])
            //{
            //    _TxtAd = row.Cells[1].Value.ToString();
            //    _TxtSoyad = row.Cells[2].Value.ToString();
            //    _TxtDogumTarihi = row.Cells[3].Value.ToString();
            //    _TxtTc= row.Cells[4].Value.ToString();
            //    _TxtGorev = row.Cells[5].Value.ToString();
            //}
            //updateDeletePage.Show();
        }
    }
}
