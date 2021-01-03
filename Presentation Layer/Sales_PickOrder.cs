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
    public partial class Sales_PickOrder : Form
    {
        public double sum = 0.0;
        public Sales_PickOrder()
        {
            InitializeComponent();
            button2.Click += RefreshGridView;
        }

        public void RefreshGridView(object sender, EventArgs e)
        {
            SalesInfoService salesInfoService = new SalesInfoService();
            dataGridView1.DataSource = salesInfoService.GetAllInfo();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {
            Home_Sales home = new Home_Sales();
            home.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sales_PickOrder_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalesInfoService salesInfoService = new SalesInfoService();
            int quantity = Convert.ToInt32(textBox2.Text);
            double price = Convert.ToDouble(textBox3.Text);
            this.sum= sum+ price;
            textBox6.Text = this.sum.ToString();
            int result = salesInfoService.AddSellingMedicines(textBox5.Text,textBox1.Text, quantity, price, dateTimePicker1.Text, textBox4.Text);
            if(result>0)
            {
                MessageBox.Show("Added to Queue");
                textBox1.Text =textBox5.Text= textBox2.Text = textBox3.Text = textBox4.Text = dateTimePicker1.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SalesInfoService salesInfoService = new SalesInfoService();
            dataGridView1.DataSource = salesInfoService.GetAllInfo();
        }
    }
}
