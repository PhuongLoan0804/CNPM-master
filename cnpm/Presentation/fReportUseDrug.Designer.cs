
namespace cnpm.Presentation
{
    partial class fReportUseDrug
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReportUseDrug));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dpkTodate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLanDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 60);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(413, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO SỬ DỤNG THUỐC";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.dtpFromDate);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(315, 89);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 49);
            this.panel4.TabIndex = 9;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpFromDate.CalendarFont = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(80, 12);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.RightToLeftLayout = true;
            this.dtpFromDate.Size = new System.Drawing.Size(126, 26);
            this.dtpFromDate.TabIndex = 1;
            this.dtpFromDate.Value = new System.DateTime(2020, 11, 29, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ ngày:";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.dpkTodate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(600, 89);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 49);
            this.panel2.TabIndex = 10;
            // 
            // dpkTodate
            // 
            this.dpkTodate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dpkTodate.CalendarFont = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkTodate.CustomFormat = "dd/MM/yyyy";
            this.dpkTodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkTodate.Location = new System.Drawing.Point(84, 12);
            this.dpkTodate.Name = "dpkTodate";
            this.dpkTodate.RightToLeftLayout = true;
            this.dpkTodate.Size = new System.Drawing.Size(126, 26);
            this.dpkTodate.TabIndex = 1;
            this.dpkTodate.Value = new System.DateTime(2020, 12, 3, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đến ngày:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Ngay,
            this.MaThuoc,
            this.tenThuoc,
            this.DonVi,
            this.SoLuong,
            this.SoLanDung});
            this.dataGridView1.Location = new System.Drawing.Point(68, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 49;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(961, 316);
            this.dataGridView1.TabIndex = 11;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 120;
            // 
            // Ngay
            // 
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            this.Ngay.Width = 125;
            // 
            // MaThuoc
            // 
            this.MaThuoc.HeaderText = "Mã thuốc";
            this.MaThuoc.MinimumWidth = 6;
            this.MaThuoc.Name = "MaThuoc";
            this.MaThuoc.Width = 125;
            // 
            // tenThuoc
            // 
            this.tenThuoc.HeaderText = "Tên thuốc";
            this.tenThuoc.MinimumWidth = 6;
            this.tenThuoc.Name = "tenThuoc";
            this.tenThuoc.Width = 180;
            // 
            // DonVi
            // 
            this.DonVi.HeaderText = "Đơn vị";
            this.DonVi.MinimumWidth = 6;
            this.DonVi.Name = "DonVi";
            this.DonVi.Width = 120;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 120;
            // 
            // SoLanDung
            // 
            this.SoLanDung.HeaderText = "Số lần dùng";
            this.SoLanDung.MinimumWidth = 6;
            this.SoLanDung.Name = "SoLanDung";
            this.SoLanDung.Width = 120;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(251)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(68, 516);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(77, 31);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(251)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(952, 516);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 31);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(251)))));
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(195, 516);
            this.btnView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(77, 31);
            this.btnView.TabIndex = 16;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = false;
            // 
            // fReportUseDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1102, 579);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fReportUseDrug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÁO CÁO SỬ DỤNG THUỐC";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dpkTodate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLanDung;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnView;
    }
}