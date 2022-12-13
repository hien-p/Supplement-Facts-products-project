using PhongHienCoop.models;
using PhongHienCoop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PhongHienCoop
{
    public partial class create_delivery : Form
    {

        private Product_list productss;

        public string order_id { get; private set; }
        public String date { get; set; }
        public String produc_id { get; set; }

        public String agent_id { get; set; }

        public String agent_tel { get; set; }

       

        // call 
        public String Product_name {get; set; }
        public String Agent_name { get; set; }
        public string Agent_tel { get; set; }
        //public String price { get; set; }
        public String quanity { get; set; }


        public string code_delivery { get; set; }
        public create_delivery()
        {
            InitializeComponent();
           
            this.IsMdiContainer = true;
            productss = new Product_list();
            loaddata();
            DataTable table = productss.orders();
            dataGridView1.DataSource = table;


            //this.ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //this.quanity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill   



        }


        private void loaddata()
        {
            productss.loaddata();            
        }



        private void backtoproduct(object sender, EventArgs e)
        {
            this.Close();
            Products p = new Products();
            p.StartPosition = FormStartPosition.Manual;
            p.Left = 250;
            p.Top = 250;
            p.ShowDialog();
        }



       

        private void button1_Click(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void create_delivery_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // dataGridView2
            
        }



        private void datagridkeydown(object sender, KeyEventArgs e)
        {
            if  (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show(dataGridView1.SelectedRows[0].Index.ToString());
                
                DataGridViewRow selectrow = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index];
                order_id = selectrow.Cells[0].Value.ToString();
                date = selectrow.Cells[1].Value.ToString();
                produc_id = selectrow.Cells[2].Value.ToString();
               // agent_id = selectrow.Cells[3].Value.ToString();
                agent_tel = selectrow.Cells[4].Value.ToString();
               // price = selectrow.Cells[5].Value.ToString();
                quanity = selectrow.Cells[6].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows[index].Selected = true;
            //MessageBox.Show(index.ToString());
            //MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString());
            DataGridViewRow row = dataGridView1.Rows[index];//Store the value of the current row in a variable
            

            // order_id
            order_id = row.Cells[0].Value.ToString();
            date = row.Cells[1].Value.ToString();


            // Get information 
            produc_id = row.Cells[2].Value.ToString();
            agent_id = row.Cells[3].Value.ToString();
            agent_tel = row.Cells[4].Value.ToString();
            
            // int 
           // price = row.Cells[5].Value.ToString();
            quanity = row.Cells[6].Value.ToString();


            ordertab.SelectTab("details_print");

            Random rnd = new Random();
            int dice = rnd.Next(100, 1000);


            code_delivery = dice.ToString();
            ID_delivery.Text = code_delivery;


        }

        private void totalbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
           // date = dateTime.Value.ToString("dd-MM-yyyy");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            // cancel
            this.Hide();
            Products cd = new Products();
            cd.StartPosition = FormStartPosition.Manual;
            cd.Left = 350;
            cd.Top = 250;
            cd.ShowDialog();
        }

        
      

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ordertab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Print_Click(object sender, EventArgs e)
        {
            PrintDialog p = new PrintDialog();
            p.Document = printDocument1;
            DialogResult res = p.ShowDialog();


            if (res == DialogResult.OK)
            {
                printDocument1.Print();
            }
            p.ShowDialog();
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image iamge = Resources.print;
            e.Graphics.DrawImage(iamge, 100, 100, iamge.Width, iamge.Height);
            

        }

        private void Agent_phone_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ID_delivery_TextChanged(object sender, EventArgs e)
        {
            
        }
    }


}
