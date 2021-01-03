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
    public partial class Admin_InventoryManage : Form
    {
        public Admin_InventoryManage()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Admin_Home home = new Admin_Home();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MedicineInfoServices medicineInfoServices = new MedicineInfoServices();
            dataGridView1.DataSource = medicineInfoServices.GetAllMedicineInfo();
        }

        private void Admin_InventoryManage_Load(object sender, EventArgs e)
        {
            MedicineInfoServices medicineInfoServices = new MedicineInfoServices();
            dataGridView1.DataSource = medicineInfoServices.GetAllMedicineInfo();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MedicineInfoServices medicineInfoServices = new MedicineInfoServices();
            int quantity = Convert.ToInt32(textBox9.Text);
            double price = Convert.ToDouble(textBox1.Text);
            int result = medicineInfoServices.AddnewMedicines(textBox4.Text, textBox5.Text, quantity, dateTimePicker4.Text, price);
            if(result>0)
            {
                MessageBox.Show("Medicine Added");
                textBox4.Text = textBox5.Text = textBox9.Text = dateTimePicker4.Text = textBox1.Text = textBox10.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MedicineInfoServices medicineInfoServices = new MedicineInfoServices();
            int id = Convert.ToInt32(textBox10.Text);
            int result=medicineInfoServices.DeleteMedicine(id);
            if(result>0)
            {
                MessageBox.Show("Deleted");
                textBox10.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Error While Deleting");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedicineInfoServices medicineInfoServices = new MedicineInfoServices();
            dataGridView1.DataSource = medicineInfoServices.GetAllMedicineInfo();
        }
    }
}
