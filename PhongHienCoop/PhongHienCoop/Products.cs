using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhongHienCoop
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
               
     
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
            bool view = true;
            if (view == true)
            {
                string strCon = @"server=VIP-042\SQLEXPRESS;database=PhongHienCoop;integrated security=true;";
                String query = "select * from Products";
                var connection = new SqlConnection(strCon);
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = query;
                DataTable table = new DataTable();
                SqlDataAdapter sqldat = new SqlDataAdapter(query, connection);
                sqldat.Fill(table);

                

            }

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
            string strCon = @"server=VIP-042\SQLEXPRESS;database=PhongHienCoop;integrated security=true;";
            String query = "  select P.product_id, P.product_name, P.price ,W.quantity from Products P , Warehouse W " +
                "  where P.product_id = W.product_id";
            var connection = new SqlConnection(strCon);
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = query;
            DataTable table = new DataTable();
            SqlDataAdapter sqldat = new SqlDataAdapter(query, connection);
            sqldat.Fill(table);

            dataGrid.DataSource = table;
        }

        private void button_delivery_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // edit content 
            
        }
    }
}
