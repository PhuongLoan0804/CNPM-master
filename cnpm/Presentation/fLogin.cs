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

namespace cnpm.Presentation
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //kết nối cơ sở dữ liệu
            SqlConnection conn = new SqlConnection(SourceString.connectionString);
            try
            {
                conn.Open();
                string tk = txbUserName.Text;
                string mk = txbPassword.Text;
                string sql = "select * from TAIKHOAN where TaiKhoan='"+tk+"' and MatKhau='"+mk+"'" ;
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read()==true)
                {
                 
                    MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG");
                    fHome f = new fHome();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }    
                else
                {
                    MessageBox.Show("ĐĂNG NHẬP THẤT BẠI");
                }    
            }
            catch (Exception EX)
            {
                MessageBox.Show("LỖI KẾT NỐI");
            }

     
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) 
                != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel =true;
            }    
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
