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
    public partial class fMedical : Form
    {

        //kết nối cơ sở dữ liệu
        SqlConnection conn = new SqlConnection(SourceString.connectionString);

        void LoadData()
        {
            string sql = "SELECT * FROM LOAITHUOC";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridViewThuoc.DataSource = dt;
        }
        public fMedical()
        {
            InitializeComponent();
            LoadData();
        }

        //thêm loại thuốc
        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = @"INSERT INTO LOAITHUOC (MaLoaiThuoc, TenLoaiThuoc, MaDonVi, DonGia) values ('" + MaLoaiThuoc.Text + "', N'" + TenLoaiThuoc.Text + "', '"+MaDonVi.Text+"', '"+DonGia.Text+"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }

        private void fMedical_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet21.DONVI' table. You can move, or remove it, as needed.
            this.dONVITableAdapter1.Fill(this.dataSet21.DONVI);
            // TODO: This line of code loads data into the 'dataSet2.DONVI' table. You can move, or remove it, as needed.
            this.dONVITableAdapter1.Fill(this.dataSet2.DONVI);
            // TODO: This line of code loads data into the 'qLPhongMachTuDataSet.DONVI' table. You can move, or remove it, as needed.
            this.dONVITableAdapter.Fill(this.qLPhongMachTuDataSet.DONVI);

        }

        //đọc dữ liệu
        private void gridViewThuoc_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            /*MaLoaiThuoc.ReadOnly = true;*/
            int i;
            i = gridViewThuoc.CurrentRow.Index;
            MaLoaiThuoc.Text = gridViewThuoc.Rows[i].Cells[0].Value.ToString();
            TenLoaiThuoc.Text = gridViewThuoc.Rows[i].Cells[1].Value.ToString();
            MaDonVi.Text = gridViewThuoc.Rows[i].Cells[2].Value.ToString();
            //TenDonVi.Text = gridViewThuoc.Rows[i].Cells[3].Value.ToString();
            DonGia.Text = gridViewThuoc.Rows[i].Cells[3].Value.ToString();
        }
    

        
        private void label5_Click(object sender, EventArgs e)
        {
          
        }

        string sql;

        //button xóa thuốc
        private void Xoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = @"DELETE FROM LOAITHUOC WHERE (MaLoaiThuoc='" + MaLoaiThuoc.Text + @"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }

        //button sửa thuốc
        private void Sua_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = @"UPDATE LOAITHUOC SET MaLoaiThuoc='" + MaLoaiThuoc.Text + @"', TenLoaiThuoc=N'" + TenLoaiThuoc.Text + @"', MaDonVi='"+MaDonVi.Text+@"', DonGia='"+DonGia.Text+@"' WHERE MaLoaiThuoc='" + MaLoaiThuoc.Text + @"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }

        // button thoát
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                this.Close();
               // Application.Exit();
            }
        }

        private void MaDonVi_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void DonGia_TextChanged(object sender, EventArgs e)
        {
            if (DonGia.Text != "")
            {
                try
                {
                    float check = float.Parse(DonGia.Text.ToString());
                }
                catch
                {
                    MessageBox.Show(" Đơn giá thuốc chưa đúng định dạng, vui lòng nhập lại !", "Cảnh báo");
                    DonGia.Focus();
                }
            }
        }

        private void TenDonVi_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridViewThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
