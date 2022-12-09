using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
namespace PhongHienCoop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void btn_login_Click(object sender, EventArgs e)
        {
            // steps by steps 

            /* 1. Lay thong tin tu giao dien    
             * Kiem tra thong tin co hop le khong   
             * kiem tra trong co so du lieu     
             * Chuyen toi giao dien chinh khi dang nhap thanh cong 
             * Hien thi thong tin dang nhap
             */


            String account = txt_name.Text.Trim();
            String password = txt_password.Text.Trim();
            String strErr = String.Empty;
            // test login account length    
            if(account == String.Empty)
            {
                strErr = "Bạn vui lòng nhập tên đăng nhập";
            }
            

            // Test password 
            if (password == String.Empty)
            {
                strErr = "Bạn chưa nhập mật khẩu";
            }

            if(strErr != string.Empty) {
                MessageBox.Show(strErr, "Error");
                return;
            }

            // 
            string strCon = @"server=VIP-044\SQLEXPRESS;database=PhongHienCoop;integrated security=true;";

            SqlParameter[] arrParam = new SqlParameter[2];

            arrParam[0] = new SqlParameter("accountant_name", account);
            arrParam[1] = new SqlParameter("acc_password", password);

            // CONNECT DATABASE 
            SqlDataReader reader = SqlHelper.ExecuteReader(strCon, "USERSYSTEM_CHECKLOGIN", arrParam);
           

            if (reader.Read() == true)
            {

                MessageBox.Show("Đăng nhập thành công ");
                this.Hide();
                Accountant_interface acc = new Accountant_interface(account);
                acc.ShowDialog();

                // Products pro = new Products();
                //pro.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công! Bạn hãy thử lại!");
            }
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
               
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           // this.Close();
        }
    }
}
