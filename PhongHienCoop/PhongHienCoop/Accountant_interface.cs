using PhongHienCoop.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        public Accountant_interface()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            models = new Dashboard();
            Loaddata();
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
            long TotalRevenue = models.TotalRevenue;
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            string yourValue = (TotalRevenue).ToString("#,###",cul.NumberFormat);

            Label Revenue = new Label();
           
            Revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            Revenue.Text = String.Format("{0:0,0 vnđ}", models.TotalRevenue); 
            Revenue.Location = new System.Drawing.Point(57, 32);
            Revenue.Size = new System.Drawing.Size(297, 31);
            NumberofRevenue.Controls.Add(Revenue);


            Label pro2 = new Label();
            pro2.Text = models.Numberofagents.ToString();
            pro2.Location = new System.Drawing.Point(47, 12);
            panel5.Controls.Add(pro2);

            Label pro = new Label();
            pro.Text = models.Numberofproducts.ToString();
            pro.Location = new System.Drawing.Point(47, 12);

            panel_prod.Controls.Add(pro);


            Label pro4 = new Label();

            var value = 8012.34m;

           
            
            
            
            
            pro4.Location = new System.Drawing.Point(67, 32);
            Numberofprofits_box.Controls.Add(pro4);


            // model.GrossRevenuelist
        }
        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void button_sign_out_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("This will sign out account. Confirm?", "Close Application", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                this.Hide();
                Accountant_interface acc = new Accountant_interface();
                acc.ShowDialog();
            }
            else
            {
                MessageBox.Show("The application has been signed out successfully.", "Goodbye!", MessageBoxButtons.OK);
                
                this.Hide();
                LoginForm acc = new LoginForm();
                acc.StartPosition = FormStartPosition.Manual;
                acc.Left = 100;
                acc.Top = 100;
                acc.ShowDialog();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 
            this.Hide();
            Products pro = new Products();
            pro.StartPosition = FormStartPosition.Manual;
            pro.Left = 250;
            pro.Top = 250;
            pro.ShowDialog();
        }

        private void numberofproduct_Click(object sender, EventArgs e)
        {

        }

        private void NumberofRevenue_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel_prod_Paint(object sender, PaintEventArgs e)
        {

        }

        private void name_user_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Numberofprofits_Paint(object sender, PaintEventArgs e)
        {
                
        }
    }
}
