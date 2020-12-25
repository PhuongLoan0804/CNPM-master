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
    public partial class fListMediExam : Form
    {

        System.Data.SqlClient.SqlConnection conn = new SqlConnection(SourceString.connectionString);

        void LoadData()
        {
            string sql = "SELECT DS_KHAMBENH.MaBN, BENHNHAN.HoTen, BENHNHAN.GioiTinh, BENHNHAN.NamSinh, BENHNHAN.DiaChi FROM DS_KHAMBENH, BENHNHAN WHERE DS_KHAMBENH.MaBN = BENHNHAN.MaBN";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridViewDSK.DataSource = dt;
        }
        void LoadDataFromSqlString(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridViewDSK.DataSource = dt;
        }
        public fListMediExam()
        {
            InitializeComponent();
            LoadData();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                this.Close();
                //Application.Exit();
            }
        }

        // đọc dữ liệu
        private void gridViewDSK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MaBN.ReadOnly = true;
            int i;
            i = gridViewDSK.CurrentRow.Index;
            MaBN.Text = gridViewDSK.Rows[i].Cells[0].Value.ToString();
            TenBN.Text = gridViewDSK.Rows[i].Cells[1].Value.ToString();
            GioiTinh.Text = gridViewDSK.Rows[i].Cells[2].Value.ToString();
            NamSinh.Text = gridViewDSK.Rows[i].Cells[3].Value.ToString();
            DiaChi.Text = gridViewDSK.Rows[i].Cells[4].Value.ToString();
        }

        // tìm kiếm theo mã bệnh nhân
        private void TimKiemMaBN_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"SELECT  DS_KHAMBENH.MaBN, BENHNHAN.HoTen, BENHNHAN.GioiTinh, BENHNHAN.NamSinh, BENHNHAN.DiaChi FROM DS_KHAMBENH, BENHNHAN WHERE DS_KHAMBENH.MaBN = BENHNHAN.MaBN AND BENHNHAN.MaBN like '%" + TimMaBN.Text + "%'";
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

        string sql;

        //button thêm bệnh nhân
        private void Them_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "INSERT INTO BENHNHAN values ('" + MaBN.Text + "', N'" + TenBN.Text + "', N'" + GioiTinh.Text + "', '" + NamSinh.Text + "', N'"+DiaChi.Text+"')";
            sql = sql + " INSERT INTO DS_KHAMBENH values ('" + MaBN.Text + "1','" + DateTime.Now.ToString("yyyy/MM/dd") + "','" + MaBN.Text + "')"; 
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }

        private void Sua_Click(object sender, EventArgs e)
        {

        }

        //button xóa bệnh nhân
        private void Xoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = @"DELETE FROM DS_KHAMBENH WHERE (MaBN='" + MaBN.Text + @"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }

        //tìm kiếm bệnh nhân theo tên
        private void TimKiemTenBN_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"SELECT  DS_KHAMBENH.MaBN, BENHNHAN.HoTen, BENHNHAN.GioiTinh, BENHNHAN.NamSinh, BENHNHAN.DiaChi FROM DS_KHAMBENH, BENHNHAN WHERE DS_KHAMBENH.MaBN = BENHNHAN.MaBN AND BENHNHAN.HoTen like '%" + TimHoTen.Text + "%'";
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

        private void gridViewDSK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
