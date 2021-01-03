using Medicalshop.BusinessLogic_Layer;
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
    public partial class InventoryManager_AddSection : Form
    {
        public InventoryManager_AddSection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedicineInfoServices medicineInfoServices = new MedicineInfoServices();
            int quantity = Convert.ToInt32(textBox2.Text);
            int id = Convert.ToInt32(textBox4.Text);
           int result= medicineInfoServices.UpdateExistingMedicine(textBox1.Text, textBox3.Text,quantity, dateTimePicker4.Text, id);
            if(result>0)
            {
                MessageBox.Show("Updated Successfully");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = dateTimePicker4.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MedicineInfoServices medicineInfoServices = new MedicineInfoServices();
            dataGridView1.DataSource = medicineInfoServices.GetAllMedicineInfo();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SalesInfoService salesInfoService = new SalesInfoService();
            dataGridView1.DataSource = salesInfoService.GetAllInfo();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InventoryManage home = new InventoryManage();
            home.Show();
            this.Hide();
        }
    }
}
