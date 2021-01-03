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
    public partial class Admin_ManageUsers : Form
    {
        public Admin_ManageUsers()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserInfoServices userInfoServices = new UserInfoServices();
            dataGridView1.DataSource = userInfoServices.GetAllInfo();
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

        private void button1_Click(object sender, EventArgs e)
        {
            UserInfoServices userInfoServices = new UserInfoServices();
            int result = userInfoServices.AddnewUser(textBox1.Text, textBox2.Text, textBox5.Text, textBox3.Text, dateTimePicker2.Text);
            if(result>0)
            {
                MessageBox.Show("User Added Successfully");
                textBox1.Text = textBox2.Text = textBox5.Text = textBox3.Text = dateTimePicker2.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserInfoServices userInfoServices = new UserInfoServices();
            int id = Convert.ToInt32(textBox4.Text);
            int result = userInfoServices.UpdateExistingUser(textBox1.Text, textBox2.Text, textBox5.Text, textBox3.Text, dateTimePicker2.Text, id);
            if (result>0)
            {
                MessageBox.Show("User Updated");
                textBox1.Text = textBox2.Text = textBox5.Text = textBox3.Text = dateTimePicker2.Text =textBox4.Text= string.Empty;

            }
            else
            {
                MessageBox.Show("Update Error!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserInfoServices userInfoServices = new UserInfoServices();
            int id = Convert.ToInt32(textBox4.Text);
            int result = userInfoServices.DeleteExitingUser(id);
            if(result>0)
            {
                MessageBox.Show("Deleted Succesfully");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Admin_ManageUsers_Load(object sender, EventArgs e)
        {
            UserInfoServices userInfoServices = new UserInfoServices();
            dataGridView1.DataSource = userInfoServices.GetAllInfo();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UserInfoServices userInfoServices = new UserInfoServices();
            dataGridView1.DataSource = userInfoServices.GetAllInfo();
        }
    }
}
