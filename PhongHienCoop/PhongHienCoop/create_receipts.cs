using PhongHienCoop.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PhongHienCoop
{
    public partial class create_receipts : Form
    {



        public string Boxdate { get; set; }

        public string code;

        public List<string> myList;

        public create_receipts()
        {
            InitializeComponent();

            DateTime today = DateTime.Today;
            label_date.Text = today.ToString("dd/MM/yyyy");
            name_emp.Text = "Hien";

            Total_box.Text = "0";


            Random rnd = new Random();
            int dice = rnd.Next(100, 1000);


            code = dice.ToString();
            ID_re.Text = code;

           


            this.dataGridView1.DataSource = null;

            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void add_button_Click(object sender, EventArgs e)
        {
            
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {

                try
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
                catch (IOException error)
                {
                    MessageBox.Show("IOException source:", error.ToString());
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void pricebox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                String product_name = productbox.Text;
                int quantity = int.Parse(quantitybox.Text);
                int price = int.Parse(pricebox.Text);
                int total = quantity * price;


                int rowId = dataGridView1.Rows.Add();

                // Grab the new row!
                DataGridViewRow row = dataGridView1.Rows[rowId];

                //row.Cells["idDataGridViewTextBoxColumn"].Value = "XYZ";
                row.Cells["ID"].Value = code;
                //row.Cells["Nameagent"].Value = name_agents;
                row.Cells["productname"].Value = product_name;
                row.Cells["quantity"].Value = quantity;
                row.Cells["price"].Value = price;
                row.Cells["total"].Value = total;
                Total_box.Text = total.ToString();

                
                MessageBox.Show("Add SucessFul");
            }
        }




    }
}
