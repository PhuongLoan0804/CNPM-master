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
    public partial class fprescription : Form
    {

        SqlConnection conn = new SqlConnection(SourceString.connectionString);

        void LoadData()
        {
            string sql = "SELECT BENHNHAN.MaBN, BENHNHAN.HoTen, BENHNHAN.GioiTinh, BENHNHAN.NamSinh, BENHNHAN.DiaChi, PHIEUKHAM.MaPhieuKham, DONTHUOC.MaDonThuoc, DONTHUOC.MaLoaiThuoc, DONTHUOC.MaCachDung FROM BENHNHAN, PHIEUKHAM, DONTHUOC  WHERE BENHNHAN.MaBN=PHIEUKHAM.MaBN AND PHIEUKHAM.MaDonThuoc=DONTHUOC.MaDonThuoc";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridViewDonThuoc.DataSource = dt;
        }

        public fprescription()
        {
            InitializeComponent();
            LoadData();
        }

        private void fprescription_Load(object sender, EventArgs e)
        {

        }

        private void gridViewDonThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
