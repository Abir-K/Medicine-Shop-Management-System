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

namespace Medicalshop.Presentation_Layer
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLoginServices userLoginServices = new UserLoginServices();
            int result = userLoginServices.UpdateUsersPassword(textBox2.Text, textBox3.Text);
            if(result>0)
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox3.Text=="SalesMan")
            {
                Home_Sales home = new Home_Sales();
                home.Show();
                this.Hide();
            }
            else if(textBox3.Text == "InventoryManager")
            {
                InventoryManage home = new InventoryManage();
                home.Show();
                this.Hide();
            }
            else
            {
                Accountant_Panel home = new Accountant_Panel();
                home.Show();
                this.Hide();
            }
        }
    }
}
