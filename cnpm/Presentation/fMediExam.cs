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
    public partial class fMediExam : Form
    {
        //kết nối cơ sở dữ liệu
        SqlConnection conn = new SqlConnection(SourceString.connectionString);

        void LoadData()
        {
            string sql = "SELECT  PHIEUKHAM.MaPhieuKham, PHIEUKHAM.NgayKham, PHIEUKHAM.MaBN,PHIEUKHAM.MaDonThuoc, PHIEUKHAM.TrieuChung, LOAIBENH.MaLB, LOAIBENH.TenLB, BENHNHAN.HoTen, BENHNHAN.GioiTinh, BENHNHAN.NamSinh, BENHNHAN.DiaChi FROM PHIEUKHAM, BENHNHAN, LOAIBENH WHERE PHIEUKHAM.MaBN=BENHNHAN.MaBN AND PHIEUKHAM.MaLB=LOAIBENH.MaLB";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridViewPKB.DataSource = dt;
        }

        public fMediExam()
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

        private void fMediExam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.LOAIBENH' table. You can move, or remove it, as needed.
            this.lOAIBENHTableAdapter.Fill(this.dataSet1.LOAIBENH);

        }

        string sql;

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = @"INSERT INTO PHIEUKHAM (MaPhieuKham, MaBN, MaDonThuoc, TrieuChung, MaLB) values ('" + MaPhieuKham.Text + "', '" + MaBenhNhan.Text + "', '" + MaDonThuoc.Text + "', N'" + TrieuChung.Text + "', '" + MaLoaiBenh.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = @"UPDATE PHIEUKHAM SET MaPhieuKham='" + MaPhieuKham.Text + @"', TrieuChung=N'" + TrieuChung.Text + @"', MaLB=N'" + MaLoaiBenh.Text + @"', MaDonThuoc='" + MaDonThuoc.Text + @"', MaBN=N'" + MaBenhNhan.Text + @"' WHERE MaPhieuKham='" + MaPhieuKham.Text + @"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }

        private void gridViewPKB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MaPhieuKham.ReadOnly = true; 
            //MaBenhNhan.ReadOnly = true;
            //MaDonThuoc.ReadOnly = true;
      
            int i;
            i = gridViewPKB.CurrentRow.Index;
            MaPhieuKham.Text = gridViewPKB.Rows[i].Cells[0].Value.ToString();
            MaBenhNhan.Text = gridViewPKB.Rows[i].Cells[2].Value.ToString();
            MaDonThuoc.Text = gridViewPKB.Rows[i].Cells[3].Value.ToString();
            TrieuChung.Text = gridViewPKB.Rows[i].Cells[4].Value.ToString();
            MaLoaiBenh.Text = gridViewPKB.Rows[i].Cells[5].Value.ToString();
            
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //button xóa
        private void Xoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = @"DELETE FROM PHIEUKHAM WHERE (MaPhieuKham='" + MaPhieuKham.Text + @"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }

        private void gridViewThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
