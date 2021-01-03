using Medicalshop.BusinessLogic_Layer;
using Medicalshop.Entity;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text=="" || textBox2.Text=="")
            {
                MessageBox.Show("UserName & Password Must Be Filled!");

            }
            else
            {
                UserLoginServices userLoginServices = new UserLoginServices();
                bool result=userLoginServices.UsersLogin(textBox1.Text, textBox2.Text);
                if((textBox1.Text=="Admin"|| textBox1.Text == "admin"|| textBox1.Text == "ADMIN") && result)
                {
                    Admin_Home home = new Admin_Home();
                    home.Show();
                    this.Hide();

                }
                else if((textBox1.Text=="SalesMan"|| textBox1.Text == "salesman"|| textBox1.Text == "SALESMAN") && result)
                {
                    Home_Sales home = new Home_Sales();
                    home.Show();
                    this.Hide();
                }
                else if ((textBox1.Text == "InventoryManager"|| textBox1.Text == "inventorymanager"|| textBox1.Text == "INVENTORYMANAGER" )&& result)
                {
                    InventoryManage home = new InventoryManage();
                    home.Show();
                    this.Hide();
                }
                else if((textBox1.Text=="Accountant"|| textBox1.Text == "accountant"|| textBox1.Text == "ACCOUNTANT" )&& result)
                {
                    Accountant_Panel home = new Accountant_Panel();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid User Or Password!");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
