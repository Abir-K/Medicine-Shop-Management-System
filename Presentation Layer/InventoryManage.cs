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
    public partial class InventoryManage : Form
    {
        public InventoryManage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedicineInfoServices medicineInfoServices = new MedicineInfoServices();
            dataGridView1.DataSource = medicineInfoServices.GetAllMedicineInfo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangePassword home = new ChangePassword();
            home.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SalesInfoService salesInfoService = new SalesInfoService();
            dataGridView1.DataSource = salesInfoService.GetAllInfo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SalesInfoService salesInfoService = new SalesInfoService();
            dataGridView1.DataSource = salesInfoService.GetAllInfo();
        }

        private void InventoryManage_Load(object sender, EventArgs e)
        {
            SalesInfoService salesInfoService = new SalesInfoService();
            dataGridView1.DataSource = salesInfoService.GetAllInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InventoryManager_AddSection home = new InventoryManager_AddSection();
            home.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
        
  
}
