using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhongHienCoop
{
    public partial class Products : Form
    {
        public List<string> lstproductNumber;
        public DataTable table;
        public class product_details
        {
            public int product_id;
            public string product_name;
            public int price; 
            public int quantity;
        }



        public List<Products> results { get; set; } 

        private bool view = false;


        public Products()
        {
            InitializeComponent();
            table = new DataTable();
            
        }

       


        private void Products_Load(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Come back to Dashboard 

            this.Hide();
            Accountant_interface p = new Accountant_interface("Hien");
            p.StartPosition = FormStartPosition.Manual;
            p.Left = 250;
            p.Top = 250;
            p.ShowDialog();

        }

        private void panel_datawarehouse(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void gridview()
        {
            
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            create_receipts cr = new create_receipts();
            cr.StartPosition = FormStartPosition.Manual;
            cr .Left = 250;
            cr.Top = 250;
            cr.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void views_Click(object sender, EventArgs e)
        {
            if (view == false)
            {
                string strCon = @"server=VIP-045\SQLEXPRESS;database=PhongHienCoop;integrated security=true;";
                String query = " select P.product_id, P.product_name, P.price ,W.quantity from Products P , Warehouse W " +
                    "  where P.product_id = W.product_id";
                var connection = new SqlConnection(strCon);
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = query;

                SqlDataAdapter sqldat = new SqlDataAdapter(query, connection);
                sqldat.Fill(table);

                dataGrid.DataSource = table;

                view = true;
            }
        }

        private void button_delivery_Click(object sender, EventArgs e)
        {
            this.Hide();
            create_delivery cd = new create_delivery();
            cd.StartPosition = FormStartPosition.Manual;
            cd.Left = 350;
            cd.Top = 250;
            cd.ShowDialog();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Todo: display details product (images, info) 
            Product_list.SelectTab("tabPage2");
            MessageBox.Show(e.RowIndex.ToString());

        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            product_details pro = new product_details();
            lstproductNumber = new List<string>();

            List<product_details> prolist = new List<product_details>();
            foreach (DataRow row in table.Rows)
            {
                object[] array = row.ItemArray;
                lstproductNumber.Append(array[1].ToString());
                pro.product_id = (int)array[0];
                pro.product_name = array[1].ToString();
                pro.price = (int)array[2];
                pro.quantity = (int)array[3];
                prolist.Add(pro);
               
            }
            //MessageBox.Show(prolist[1].ToString());
                

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
