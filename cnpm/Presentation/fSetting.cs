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

namespace cnpm.Presentation
{
    public partial class fSetting : Form
    {

        SqlConnection conn = new SqlConnection(SourceString.connectionString);

       

        public fSetting()
        {
            InitializeComponent();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        //đưa dữ liệu lên
        private void fSetting_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM THAMSO";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    BN_ToiDa.Text = dta.GetString(0);
                    TienKham.Text = dta.GetString(1);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                conn.Close();
            }
            


        }

        private void Huy_Click(object sender, EventArgs e)
        {
            
        }

        private void BN_ToiDa_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Sua_Click(object sender, EventArgs e)
        { 
            try
            {
                conn.Open();
                string sql = "UPDATE THAMSO SET BN_ToiDa = ' " + BN_ToiDa.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công số bệnh nhân tối đa: " + BN_ToiDa.Text);
            }
            catch
            {
                MessageBox.Show("Lỗi!! Sửa số bệnh nhân tối đa thất bại");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Sua2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "UPDATE THAMSO SET TienKham = ' " + TienKham.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công số bệnh nhân tối đa: " + TienKham.Text);
            }
            catch
            {
                MessageBox.Show("Lỗi!! Sửa tiền khám không thành công");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
