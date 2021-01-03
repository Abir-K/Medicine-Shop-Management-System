using Medicalshop.BusinessLogic_Layer;
using Medicalshop.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicalshop
{
    public partial class Home_Sales : Form
    {
        public Home_Sales()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sales_PickOrder home = new Sales_PickOrder();
            home.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangePassword home = new ChangePassword();
            home.Show();
            this.Hide();
        }

        private void homeSalesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MedicineInfoServices medicineInfoServices = new MedicineInfoServices();
            homeSalesDataGridView.DataSource = medicineInfoServices.GetAllMedicineInfo();
        }

        private void Home_Sales_Load(object sender, EventArgs e)
        {
            MedicineInfoServices medicineInfoServices = new MedicineInfoServices();
            homeSalesDataGridView.DataSource = medicineInfoServices.GetAllMedicineInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MedicineInfoServices medicineInfoServices = new MedicineInfoServices();
           homeSalesDataGridView.DataSource= medicineInfoServices.GetAllMedicineInfo(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
