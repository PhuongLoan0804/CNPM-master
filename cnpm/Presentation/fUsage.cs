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
    public partial class fUsage : Form
    {
        //kết nối cơ sở dữ liệu
        SqlConnection conn = new SqlConnection(SourceString.connectionString);

        void LoadData()
        {
            string sql = "SELECT * FROM CACHDUNG";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridViewCD.DataSource = dt;
        }

        public fUsage()
        {
            InitializeComponent();
            LoadData();
        }

        private void gridViewCD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*textBox1.ReadOnly = true;*/ 
            int i;
            i = gridViewCD.CurrentRow.Index;
            MaCD.Text = gridViewCD.Rows[i].Cells[0].Value.ToString();
            TenCD.Text = gridViewCD.Rows[i].Cells[1].Value.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        string sql;

        //button thêm cách dùng
        private void Them_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = @"INSERT INTO CACHDUNG (MaCachDung, TenCachDung) values ('" + MaCD.Text + "', N'" + TenCD.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = @"UPDATE CACHDUNG SET MaCachDung='" + MaCD.Text + @"', TenCachDung=N'" + TenCD.Text + @"' WHERE MaCachDung='" + MaCD.Text + @"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = @"DELETE FROM CACHDUNG WHERE (MaCachDung='" + MaCD.Text + @"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }

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
