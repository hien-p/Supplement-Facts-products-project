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
        public String price { get; set; }
        public String quanity { get; set; }


        public create_delivery()
        {
            InitializeComponent();
            

            /*this.Controls.Add(dataGridView1);
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Release Date";
            dataGridView1.Columns[1].Name = "Track";
            *//* dataGridView1.Columns[1].DefaultCellStyle.Alignment =
                 DataGridViewContentAlignment.MiddleCenter;*//*
            dataGridView1.Columns[2].Name = "Title";
            dataGridView1.Columns[3].Name = "Artist";
            dataGridView1.Columns[4].Name = "Album";



            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = true;

            dataGridView1.BackgroundColor = Color.Honeydew;*/

            this.IsMdiContainer = true;
            productss = new Product_list();
            loaddata();
            DataTable table = productss.orders();
            dataGridView1.DataSource = table;
            dataGridView1.MultiSelect = true;
        }


        private void loaddata()
        {
            productss.loaddata();

            


          /*  foreach (Dictionary<string, string> column in productss.rows)
            {
                //MessageBox.Show(column["order_id"]);
                DateTime myDate = DateTime.Parse(column["order_date"]);
                MessageBox.Show(myDate.ToString("MM/dd/yyyy"));
            }*/

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



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*int index = e.RowIndex;


            DataTable data = new DataTable();
            DataGridViewRow selectrow = dataGridView1.Rows[index];

            this.ProductID = selectrow.Cells[0].Value.ToString();
            MessageBox.Show(ProductID);*/
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
                agent_id = selectrow.Cells[3].Value.ToString();
                agent_tel = selectrow.Cells[4].Value.ToString();
                price = selectrow.Cells[5].Value.ToString();
                quanity = selectrow.Cells[6].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            ordertab.SelectTab("tabPage2");
            /* MessageBox.Show(produc_id);*/
            
            dataGridView2.ColumnCount = 5;
            dataGridView2.Columns[0].Name = "Order ID";
            dataGridView2.Columns[1].Name = "Product ID";
            dataGridView2.Columns[2].Name = "Agent ID ";
            dataGridView2.Columns[3].Name = "Agent Phone ";
            dataGridView2.Columns[4].Name = "Price";

            var index = this.dataGridView2.Rows.Add();
            this.dataGridView2.Rows[index].Cells[0].Value = order_id;
            this.dataGridView2.Rows[index].Cells[1].Value = produc_id; 

            // agentid -> agentname 
            this.dataGridView2.Rows[index].Cells[2].Value = agent_id;
            this.dataGridView2.Rows[index].Cells[3].Value = agent_tel;


            //price
            this.dataGridView2.Rows[index].Cells[4].Value = price;

            int total = Int32.Parse(quanity) * Int32.Parse(price);
            totalbox.Text = total.ToString();
        }

        private void totalbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            date = dateTime.Value.ToString("dd-MM-yyyy");
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
    }


}
