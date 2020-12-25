
namespace cnpm.Presentation
{
    partial class fListMediExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fListMediExam));
            this.TimMaBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridViewDSK = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.Them = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TimHoTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MaBN = new System.Windows.Forms.TextBox();
            this.TenBN = new System.Windows.Forms.TextBox();
            this.GioiTinh = new System.Windows.Forms.TextBox();
            this.DiaChi = new System.Windows.Forms.TextBox();
            this.NgayKham = new System.Windows.Forms.DateTimePicker();
            this.TimKiemMaBN = new System.Windows.Forms.Button();
            this.TimKiemTenBN = new System.Windows.Forms.Button();
            this.NamSinh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDSK)).BeginInit();
            this.SuspendLayout();
            // 
            // TimMaBN
            // 
            this.TimMaBN.Location = new System.Drawing.Point(183, 96);
            this.TimMaBN.Name = "TimMaBN";
            this.TimMaBN.Size = new System.Drawing.Size(168, 27);
            this.TimMaBN.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ và tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã bệnh nhân:";
            // 
            // gridViewDSK
            // 
            this.gridViewDSK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewDSK.BackgroundColor = System.Drawing.Color.Azure;
            this.gridViewDSK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDSK.Location = new System.Drawing.Point(12, 172);
            this.gridViewDSK.Name = "gridViewDSK";
            this.gridViewDSK.RowHeadersWidth = 51;
            this.gridViewDSK.RowTemplate.Height = 24;
            this.gridViewDSK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridViewDSK.Size = new System.Drawing.Size(561, 395);
            this.gridViewDSK.TabIndex = 1;
            this.gridViewDSK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewDSK_CellClick);
            this.gridViewDSK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewDSK_CellContentClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(996, 529);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 29);
            this.button7.TabIndex = 5;
            this.button7.Text = "Thoát";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Them
            // 
            this.Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(251)))));
            this.Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Them.Location = new System.Drawing.Point(801, 362);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(84, 29);
            this.Them.TabIndex = 0;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = false;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // Xoa
            // 
            this.Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(251)))));
            this.Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Xoa.Location = new System.Drawing.Point(948, 362);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(89, 29);
            this.Xoa.TabIndex = 2;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = false;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH KHÁM BỆNH TRONG NGÀY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày khám bệnh";
            // 
            // TimHoTen
            // 
            this.TimHoTen.Location = new System.Drawing.Point(183, 139);
            this.TimHoTen.Name = "TimHoTen";
            this.TimHoTen.Size = new System.Drawing.Size(168, 27);
            this.TimHoTen.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(725, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "THÔNG TIN BỆNH NHÂN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã bệnh nhân";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(594, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Họ tên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(883, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Giới tính";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(594, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Năm sinh";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(594, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Địa chỉ";
            // 
            // MaBN
            // 
            this.MaBN.Location = new System.Drawing.Point(718, 146);
            this.MaBN.Name = "MaBN";
            this.MaBN.Size = new System.Drawing.Size(362, 27);
            this.MaBN.TabIndex = 13;
            // 
            // TenBN
            // 
            this.TenBN.Location = new System.Drawing.Point(718, 190);
            this.TenBN.Name = "TenBN";
            this.TenBN.Size = new System.Drawing.Size(362, 27);
            this.TenBN.TabIndex = 14;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Location = new System.Drawing.Point(961, 236);
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Size = new System.Drawing.Size(119, 27);
            this.GioiTinh.TabIndex = 15;
            // 
            // DiaChi
            // 
            this.DiaChi.Location = new System.Drawing.Point(718, 283);
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(362, 27);
            this.DiaChi.TabIndex = 17;
            // 
            // NgayKham
            // 
            this.NgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayKham.Location = new System.Drawing.Point(184, 58);
            this.NgayKham.Name = "NgayKham";
            this.NgayKham.Size = new System.Drawing.Size(134, 27);
            this.NgayKham.TabIndex = 19;
            // 
            // TimKiemMaBN
            // 
            this.TimKiemMaBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(251)))));
            this.TimKiemMaBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimKiemMaBN.Location = new System.Drawing.Point(382, 94);
            this.TimKiemMaBN.Name = "TimKiemMaBN";
            this.TimKiemMaBN.Size = new System.Drawing.Size(176, 29);
            this.TimKiemMaBN.TabIndex = 20;
            this.TimKiemMaBN.Text = "Tìm kiếm theo Mã BN";
            this.TimKiemMaBN.UseVisualStyleBackColor = false;
            this.TimKiemMaBN.Click += new System.EventHandler(this.TimKiemMaBN_Click);
            // 
            // TimKiemTenBN
            // 
            this.TimKiemTenBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(251)))));
            this.TimKiemTenBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimKiemTenBN.Location = new System.Drawing.Point(382, 137);
            this.TimKiemTenBN.Name = "TimKiemTenBN";
            this.TimKiemTenBN.Size = new System.Drawing.Size(191, 29);
            this.TimKiemTenBN.TabIndex = 21;
            this.TimKiemTenBN.Text = "Tìm kiếm theo Tên BN";
            this.TimKiemTenBN.UseVisualStyleBackColor = false;
            this.TimKiemTenBN.Click += new System.EventHandler(this.TimKiemTenBN_Click);
            // 
            // NamSinh
            // 
            this.NamSinh.Location = new System.Drawing.Point(718, 236);
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.Size = new System.Drawing.Size(119, 27);
            this.NamSinh.TabIndex = 22;
            // 
            // fListMediExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1102, 579);
            this.Controls.Add(this.NamSinh);
            this.Controls.Add(this.TimKiemTenBN);
            this.Controls.Add(this.TimKiemMaBN);
            this.Controls.Add(this.NgayKham);
            this.Controls.Add(this.DiaChi);
            this.Controls.Add(this.GioiTinh);
            this.Controls.Add(this.TenBN);
            this.Controls.Add(this.MaBN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TimMaBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimHoTen);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.gridViewDSK);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.Xoa);
            this.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fListMediExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH KHÁM BỆNH";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDSK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TimMaBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridViewDSK;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TimHoTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MaBN;
        private System.Windows.Forms.TextBox TenBN;
        private System.Windows.Forms.TextBox GioiTinh;
        private System.Windows.Forms.TextBox DiaChi;
        private System.Windows.Forms.DateTimePicker NgayKham;
        private System.Windows.Forms.Button TimKiemMaBN;
        private System.Windows.Forms.Button TimKiemTenBN;
        private System.Windows.Forms.TextBox NamSinh;
    }
}