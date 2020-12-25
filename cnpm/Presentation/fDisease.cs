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
    
    public partial class fDisease : Form
    {

        System.Data.SqlClient.SqlConnection conn = new SqlConnection(SourceString.connectionString);

        void LoadData()
        {
            
            string sql = "SELECT * FROM LOAIBENH";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridViewLB.DataSource = dt;
        }

        public fDisease()
        {
            InitializeComponent();
            LoadData();
        }

        

        private void gridViewLB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*MaLoaiBenh.ReadOnly = true;*/
            int i;
            i = gridViewLB.CurrentRow.Index;
            MaLoaiBenh.Text = gridViewLB.Rows[i].Cells[0].Value.ToString();
            TenLoaiBenh.Text = gridViewLB.Rows[i].Cells[1].Value.ToString();
        }

        string sql;

        //button thêm loại bệnh
        private void Them_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = @"INSERT INTO LOAIBENH (MaLB, TenLB) values ('"+MaLoaiBenh.Text+"', N'"+TenLoaiBenh.Text+"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }

        //button sửa loại bệnh
        private void Sua_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = @"UPDATE LOAIBENH SET MaLB='" + MaLoaiBenh.Text + @"', TenLB=N'"+TenLoaiBenh.Text+ @"' WHERE MaLB='" + MaLoaiBenh.Text + @"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }

        //button xóa loại bệnh
        private void Xoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = @"DELETE FROM LOAIBENH WHERE (MaLB='"+MaLoaiBenh.Text+@"')";
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
