
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

    public partial class fBill : Form
    {

        SqlConnection conn = new SqlConnection(SourceString.connectionString);

        void LoadData()
        {
            //string sql = "SELECT * FROM HOADON";
            string sql = "SELECT HOADON.NgayHD, PHIEUKHAM.MaPhieuKham, BENHNHAN.MaBN, BENHNHAN.HoTen, BENHNHAN.GioiTinh, BENHNHAN.NamSinh, BENHNHAN.DiaChi, HOADON.TienKham, HOADON.TiemThuoc FROM HOADON, PHIEUKHAM, BENHNHAN WHERE HOADON.MaPhieuKham = PHIEUKHAM.MaPhieuKham AND PHIEUKHAM.MaBN = BENHNHAN.MaBN";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridViewHD.DataSource = dt;
        }

        public fBill()
        {
            InitializeComponent();
            LoadData();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        //thoát
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                this.Close();
                // Application.Exit();
            }
        }

        private void fBill_Load(object sender, EventArgs e)
        {

        }

        // kiểm tra hóa đơn có bao gồm tiền thuốc hay không
        private void checkMuathuoc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMuathuoc.Checked == false)
            {
                //TienThuoc.Text = "0";
                TongTien.Text = TienKham.Text;
            }
            else
            {
                int TotalMoney = Int32.Parse(TienKham.Text) + Int32.Parse(TienThuoc.Text);
                TongTien.Text = TotalMoney.ToString();
            }
        }

        //đọc dữ liệu
        private void gridViewBN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //SoHD.ReadOnly = true;
            int i;
            i = gridViewHD.CurrentRow.Index;
            NgayHD.Text = gridViewHD.Rows[i].Cells[0].Value.ToString();
            MaPK.Text = gridViewHD.Rows[i].Cells[1].Value.ToString();
            MaBN.Text = gridViewHD.Rows[i].Cells[2].Value.ToString();
            TienKham.Text = gridViewHD.Rows[i].Cells[7].Value.ToString();
            TienThuoc.Text = gridViewHD.Rows[i].Cells[8].Value.ToString();
        }

        string sql;

        //lập hóa đơn
        private void LapHD_Click(object sender, EventArgs e)
        {
            conn.Open();
            //viết lại câu lệnh SQL
            sql = @"INSERT INTO HOADON (SoHD, MaPhieuKham, NgayHD, TienKham, TienThuoc) values ('" + NgayHD.Text + "', N'" + MaPK.Text + "', '" + NgayHD.Text + "', '" + TienKham.Text + "', '"+TienThuoc.Text+"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData();
        }
    }
}
