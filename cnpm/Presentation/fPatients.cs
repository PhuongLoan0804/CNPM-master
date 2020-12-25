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

    public partial class fPatients : Form
    {
        //kết nối cơ sở dữ liệu
        SqlConnection conn = new SqlConnection(SourceString.connectionString);

        void LoadData()
        {
            string sql = "SELECT * FROM BENHNHAN";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridViewBN.DataSource = dt;
        }

        void LoadDataFromSqlString(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridViewBN.DataSource = dt;
        }

        public fPatients()
        {
            InitializeComponent();
            LoadData();
        }

        //đọc dữ liệu
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*MaBN.ReadOnly = true;*/
            int i;
            i = gridViewBN.CurrentRow.Index;
            MaBN.Text = gridViewBN.Rows[i].Cells[0].Value.ToString();
            TenBN.Text = gridViewBN.Rows[i].Cells[1].Value.ToString();
            GioiTinh.Text = gridViewBN.Rows[i].Cells[2].Value.ToString();
            NgaySinh.Text = gridViewBN.Rows[i].Cells[3].Value.ToString();
            DiaChi.Text = gridViewBN.Rows[i].Cells[4].Value.ToString();
        }

        string sql;

        //button thêm bệnh nhân
        private void Them_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = @"INSERT INTO BENHNHAN (MaBN, HoTen, GioiTinh, NamSinh, DiaChi ) values ('" + MaBN.Text + "', N'" + TenBN.Text + "', N'"+GioiTinh.Text+"', '"+NgaySinh.Text+"', '"+DiaChi.Text+"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }

        private void textHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        //button sửa bệnh nhân
        private void Sua_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = @"UPDATE BENHNHAN SET MaBN='" + MaBN.Text + @"', HoTen=N'" + TenBN.Text + @"', GioiTinh=N'"+GioiTinh.Text+@"', NamSinh='"+NgaySinh.Text+@"', DiaChi=N'"+DiaChi.Text+@"' WHERE MaBN='" + MaBN.Text + @"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }

        //button xóa bệnh nhân
        private void Xoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = @"DELETE FROM BENHNHAN WHERE (MaBN='" + MaBN.Text + @"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }

        //button thoát
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                this.Close();
              //  Application.Exit();
            }
        }

        //tìm theo mã bệnh nhân
        private void TimtheoMaBN_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"SELECT MaBN, HoTen, GioiTinh, NamSinh, DiaChi FROM BENHNHAN WHERE (MaBN like '%" + TimMaBN.Text + "%')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Không tìm thấy");
            }
            finally
            {
                conn.Close();
            }
            LoadDataFromSqlString(sql);
        }

        //tìm theo tên bệnh nhân
        private void TimtheoTenBN_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"SELECT MaBN, HoTen, GioiTinh, NamSinh, DiaChi FROM BENHNHAN WHERE (HoTen like '%" + TimHoTen.Text + "%')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Không tìm thấy");
            }
            finally
            {
                conn.Close();
            }
            LoadDataFromSqlString(sql);
        }
    }
}
