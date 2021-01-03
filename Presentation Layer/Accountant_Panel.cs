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
    public partial class Accountant_Panel : Form
    {
        public object SalesInfoServices { get; private set; }

        public Accountant_Panel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Accountant_Panel_Load(object sender, EventArgs e)
        {
            SalesInfoService salesInfoService = new SalesInfoService();
            dataGridView1.DataSource = salesInfoService.GetAllInfo();
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
            SalesInfoService salesInfoService = new SalesInfoService();
            dataGridView1.DataSource = salesInfoService.GetAllInfo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SalesInfoService salesInfoService = new SalesInfoService();
            dataGridView1.DataSource = salesInfoService.GetAllInfo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangePassword home = new ChangePassword();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalesInfoService salesInfoService = new SalesInfoService();
            int result = salesInfoService.UpdateExistingSalesInfo(textBox2.Text, textBox1.Text);
            if(result>0)
            {
                MessageBox.Show("Confirmed");
                textBox1.Text = textBox2.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        Bitmap bitmap;

        private void button2_Click(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dataGridView1.Height = height;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
