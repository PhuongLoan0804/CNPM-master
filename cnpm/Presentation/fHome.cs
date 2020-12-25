using cnpm.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cnpm
{
    public partial class fHome : Form
    {
        public fHome()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void fHome_Load(object sender, EventArgs e)
        {

        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acount acc = new Acount();
            acc.Show();
        }



        private void càiĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSetting st = new fSetting();
            st.Show();
        }

        private void báoCáoSửDụngThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fReportUseDrug rptDrug = new fReportUseDrug();
            rptDrug.Show();
        }

        private void báoCáoĐoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDalyReport rptDaily = new fDalyReport();
            rptDaily.Show();
        }

        private void hóaĐơnThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBill bl = new fBill();
            bl.Show();
        }

        private void hóaĐơnPhòngMạchToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void danhSáchThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fMedical lofmed = new fMedical();
            lofmed.Show();
        }

        private void thêmThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fUsage usage = new fUsage();
            usage.Show();
        }

        private void xuấtBánThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fUnit unit = new fUnit();
            unit.Show();
        }

        private void danhSáchBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPatients lofPatie = new fPatients();
            lofPatie.Show();
        }

        private void lậpPhiếuKhámBệnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fMediExam medex = new fMediExam();
            medex.Show();
        }

        private void traCứuBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fListMediExam lofPatie = new fListMediExam();
            lofPatie.Show();
        }

        private void loạiBệnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDisease lofdise = new fDisease();
            lofdise.Show();
        }

        private void danhSáchBệnhNhânToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fPatients lofPati = new fPatients();
            lofPati.Show();
        }

        private void đơnThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fprescription lofpres = new fprescription();
            lofpres.Show();
        }
    }
}
