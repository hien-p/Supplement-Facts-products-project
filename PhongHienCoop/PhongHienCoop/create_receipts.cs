using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PhongHienCoop
{
    public partial class create_receipts : Form
    {
        public string Boxdate{get; set;}


        public create_receipts()
        {
            InitializeComponent();

            DateTime today = DateTime.Today;
            label_date.Text = today.ToString("dd/MM/yyyy");
            name_emp.Text = "Hien";

            Total_box.Text = "0";
        }

        private void create_invoice_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel_tab_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_products(object sender, EventArgs e)
        {
            this.Hide();
            Products pr = new Products();
            pr.Left = 350;
            pr.Top = 350;
            pr.ShowDialog();
        }

        private void backtodashboard(object sender, EventArgs e)
        {
            this.Hide();
            Accountant_interface pr = new Accountant_interface("hien");
            pr.Left = 350;
            pr.Top = 350;
            pr.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
 
        
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_date_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Total_box_TextChanged(object sender, EventArgs e)
        {

        }







        /* private void label1_Click(object sender, EventArgs e)
         {

         }*/
    }
}
