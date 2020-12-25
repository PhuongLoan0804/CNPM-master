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
    public partial class fUnit : Form
    {

        //kết nối cơ sở dữ liệu
        SqlConnection conn = new SqlConnection(SourceString.connectionString);

        void LoadData()
        {
            string sql = "SELECT * FROM DONVI";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridViewDV.DataSource = dt;
        }

        public fUnit()
        {
            InitializeComponent();
            LoadData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridViewDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*MaDonVi.ReadOnly = true;*/
            int i;
            i = gridViewDV.CurrentRow.Index;
            MaDonVi.Text = gridViewDV.Rows[i].Cells[0].Value.ToString();
            TenDonVi.Text = gridViewDV.Rows[i].Cells[1].Value.ToString();
        }

        string sql;

        //button thêm đơn vị
        private void Them_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = @"INSERT INTO DONVI (MaDonVi, TenDonVi) values ('" + MaDonVi.Text + "', N'" + TenDonVi.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }

        //button xóa đơn vị
        private void Xoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = @"DELETE FROM DONVI WHERE (MaDonVi='" + MaDonVi.Text + @"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }

        //button sửa đơn vị
        private void Sua_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = @"UPDATE DONVI SET MaDonVi='" + MaDonVi.Text + @"', TenDonVi=N'" + TenDonVi.Text + @"' WHERE MaDonVi='" + MaDonVi.Text + @"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }

        //button thoát
        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                this.Close();
                //Application.Exit();
            }
        }
    }
}
