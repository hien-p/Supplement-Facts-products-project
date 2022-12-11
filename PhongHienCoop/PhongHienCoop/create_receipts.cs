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







        /* private void label1_Click(object sender, EventArgs e)
         {

         }*/
    }
}
