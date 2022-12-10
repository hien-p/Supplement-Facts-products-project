using PhongHienCoop.models;
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
        private Dashboard models;
        public Accountant_interface(String name)
        {
            InitializeComponent();
            this.IsMdiContainer = true; 
            this.user_name.Text = name;
            models = new Dashboard();
            Loaddata();
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

          
        }

        private void Numberoforders_Click(object sender, EventArgs e)
        {

        }

        private void NumberofRevenues(object sender, PaintEventArgs e)
        {
           
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
            
        }

        private void Loaddata()
        {
            models.loaddata();


            // number of order 
            Label lbl_NumberOfoerders = new Label();
            lbl_NumberOfoerders.Text = models.Numberoforders.ToString();
            lbl_NumberOfoerders.Location = new System.Drawing.Point(67, 32);
            NumberOfoerder.Controls.Add(lbl_NumberOfoerders);

            //  number of Revenue
            Label Revenue = new Label();
            Revenue.Text = models.TotalRevenue.ToString();
            Revenue.Location = new System.Drawing.Point(67, 32);
            NumberofRevenue.Controls.Add(Revenue);

        }
        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
