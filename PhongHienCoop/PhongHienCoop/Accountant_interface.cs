using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PhongHienCoop
{
    public partial class Accountant_interface : Form
    {
        public Accountant_interface(String name)
        {
            InitializeComponent();
            this.IsMdiContainer = true; 
            this.user_name.Text = name;
        }

        private void Accountant_interface_Load(object sender, EventArgs e)
        {
           
        }

        private void ToolStripMenuItemInventory_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PaneBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void NumberOfoerders(object sender, PaintEventArgs e)
        {

            Label lbl = new Label();
            lbl.Text = "100";
            lbl.Location = new System.Drawing.Point(67, 32);
            NumberOfoerder.Controls.Add(lbl);
        }

        private void Numberoforders_Click(object sender, EventArgs e)
        {

        }

        private void NumberofRevenues(object sender, PaintEventArgs e)
        {
            Label orders = new Label();
            orders.Text = "100";
            orders.Location = new System.Drawing.Point(47, 32);
            NumberofRevenue.Controls.Add(orders);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        

        private void label10_Click(object sender, EventArgs e)
        {
            //Form frm2 = new Form(this.user_name.text);

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Numberofprofit(object sender, PaintEventArgs e)
        {
            Label lbl = new Label();
            lbl.Text = "100";
            lbl.Location = new System.Drawing.Point(67, 32);
            Numberofprofits.Controls.Add(lbl);
        }
    }
}
