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
    public partial class Admin_Home : Form
    {
        public Admin_Home()
        {
            InitializeComponent();
        }

        public void RefreshGridView(object sender, EventArgs e)
        {
            SalesInfoService salesInfoService = new SalesInfoService();
            dataGridView1.DataSource = salesInfoService.GetAllInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SalesInfoService salesInfoService = new SalesInfoService();
            dataGridView1.DataSource = salesInfoService.GetAllInfo();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_ManageUsers admin_ManageUsers = new Admin_ManageUsers();
            admin_ManageUsers.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_InventoryManage admin_InventoryManage = new Admin_InventoryManage();
            admin_InventoryManage.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SalesInfoService salesInfoService = new SalesInfoService();
            dataGridView1.DataSource = salesInfoService.GetAllInfo();
        }

        private void Admin_Home_Load(object sender, EventArgs e)
        {
            SalesInfoService salesInfoService = new SalesInfoService();
            dataGridView1.DataSource = salesInfoService.GetAllInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLoginServices userLoginServices = new UserLoginServices();
            int result=userLoginServices.UpdateAdminPassword(textBox2.Text);
            if (result > 0)
            {
                MessageBox.Show("Password Changed Successfully");
                textBox1.Text = textBox2.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
