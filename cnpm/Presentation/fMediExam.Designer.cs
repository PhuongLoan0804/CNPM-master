
namespace cnpm.Presentation
{
    partial class fMediExam
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMediExam));
            this.label1 = new System.Windows.Forms.Label();
            this.MaDonThuoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MaLoaiBenh = new System.Windows.Forms.ComboBox();
            this.lOAIBENHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new cnpm.DataSet1();
            this.NgayKham = new System.Windows.Forms.DateTimePicker();
            this.MaPhieuKham = new System.Windows.Forms.TextBox();
            this.MaBenhNhan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TrieuChung = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Sua = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.In = new System.Windows.Forms.Button();
            this.Them = new System.Windows.Forms.Button();
            this.gridViewPKB = new System.Windows.Forms.DataGridView();
            this.lOAIBENHTableAdapter = new cnpm.DataSet1TableAdapters.LOAIBENHTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gridViewThuoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIBENHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPKB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(783, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU KHÁM BỆNH";
            // 
            // MaDonThuoc
            // 
            this.MaDonThuoc.Location = new System.Drawing.Point(896, 196);
            this.MaDonThuoc.Name = "MaDonThuoc";
            this.MaDonThuoc.Size = new System.Drawing.Size(194, 27);
            this.MaDonThuoc.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(736, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mã đơn thuốc";
            // 
            // MaLoaiBenh
            // 
            this.MaLoaiBenh.DataSource = this.lOAIBENHBindingSource;
            this.MaLoaiBenh.DisplayMember = "MaLB";
            this.MaLoaiBenh.FormattingEnabled = true;
            this.MaLoaiBenh.Location = new System.Drawing.Point(896, 283);
            this.MaLoaiBenh.Name = "MaLoaiBenh";
            this.MaLoaiBenh.Size = new System.Drawing.Size(194, 27);
            this.MaLoaiBenh.TabIndex = 17;
            // 
            // lOAIBENHBindingSource
            // 
            this.lOAIBENHBindingSource.DataMember = "LOAIBENH";
            this.lOAIBENHBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NgayKham
            // 
            this.NgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayKham.Location = new System.Drawing.Point(280, 65);
            this.NgayKham.Name = "NgayKham";
            this.NgayKham.Size = new System.Drawing.Size(165, 27);
            this.NgayKham.TabIndex = 15;
            // 
            // MaPhieuKham
            // 
            this.MaPhieuKham.HideSelection = false;
            this.MaPhieuKham.Location = new System.Drawing.Point(896, 118);
            this.MaPhieuKham.Name = "MaPhieuKham";
            this.MaPhieuKham.Size = new System.Drawing.Size(194, 27);
            this.MaPhieuKham.TabIndex = 14;
            // 
            // MaBenhNhan
            // 
            this.MaBenhNhan.Location = new System.Drawing.Point(896, 157);
            this.MaBenhNhan.Name = "MaBenhNhan";
            this.MaBenhNhan.Size = new System.Drawing.Size(194, 27);
            this.MaBenhNhan.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(736, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã phiếu khám:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(169, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ngày khám:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(736, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã bệnh nhân:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(736, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã loại bệnh:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TrieuChung
            // 
            this.TrieuChung.Location = new System.Drawing.Point(896, 238);
            this.TrieuChung.Name = "TrieuChung";
            this.TrieuChung.Size = new System.Drawing.Size(194, 27);
            this.TrieuChung.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(736, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Triệu chứng:";
            // 
            // Sua
            // 
            this.Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(251)))));
            this.Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sua.Location = new System.Drawing.Point(995, 343);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(79, 29);
            this.Sua.TabIndex = 6;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = false;
            this.Sua.Click += new System.EventHandler(this.button1_Click);
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Thoat.Location = new System.Drawing.Point(1009, 538);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(81, 29);
            this.Thoat.TabIndex = 5;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = false;
            this.Thoat.Click += new System.EventHandler(this.button7_Click);
            // 
            // Xoa
            // 
            this.Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(251)))));
            this.Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Xoa.Location = new System.Drawing.Point(872, 343);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(100, 29);
            this.Xoa.TabIndex = 2;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = false;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // In
            // 
            this.In.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(251)))));
            this.In.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.In.Location = new System.Drawing.Point(882, 392);
            this.In.Name = "In";
            this.In.Size = new System.Drawing.Size(75, 29);
            this.In.TabIndex = 1;
            this.In.Text = "In";
            this.In.UseVisualStyleBackColor = false;
            // 
            // Them
            // 
            this.Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(251)))));
            this.Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Them.Location = new System.Drawing.Point(754, 343);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(100, 29);
            this.Them.TabIndex = 0;
            this.Them.Text = "Nhập mới";
            this.Them.UseVisualStyleBackColor = false;
            this.Them.Click += new System.EventHandler(this.button2_Click);
            // 
            // gridViewPKB
            // 
            this.gridViewPKB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.gridViewPKB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.gridViewPKB.BackgroundColor = System.Drawing.Color.Azure;
            this.gridViewPKB.ColumnHeadersHeight = 29;
            this.gridViewPKB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewPKB.ColumnHeadersVisible = false;
            this.gridViewPKB.Location = new System.Drawing.Point(12, 109);
            this.gridViewPKB.Name = "gridViewPKB";
            this.gridViewPKB.RowHeadersWidth = 51;
            this.gridViewPKB.RowTemplate.Height = 24;
            this.gridViewPKB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridViewPKB.Size = new System.Drawing.Size(718, 183);
            this.gridViewPKB.TabIndex = 0;
            this.gridViewPKB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewPKB_CellClick);
            // 
            // lOAIBENHTableAdapter
            // 
            this.lOAIBENHTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(134, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(453, 33);
            this.label8.TabIndex = 31;
            this.label8.Text = "DANH SÁCH PHIẾU KHÁM BỆNH";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(224, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(278, 33);
            this.label9.TabIndex = 32;
            this.label9.Text = "THÔNG TIN THUỐC";
            // 
            // gridViewThuoc
            // 
            this.gridViewThuoc.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridViewThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewThuoc.Location = new System.Drawing.Point(12, 361);
            this.gridViewThuoc.Name = "gridViewThuoc";
            this.gridViewThuoc.RowHeadersWidth = 51;
            this.gridViewThuoc.RowTemplate.Height = 24;
            this.gridViewThuoc.Size = new System.Drawing.Size(718, 206);
            this.gridViewThuoc.TabIndex = 33;
            this.gridViewThuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewThuoc_CellContentClick);
            // 
            // fMediExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1102, 579);
            this.Controls.Add(this.gridViewThuoc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.In);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gridViewPKB);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaDonThuoc);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaPhieuKham);
            this.Controls.Add(this.NgayKham);
            this.Controls.Add(this.MaLoaiBenh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MaBenhNhan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrieuChung);
            this.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMediExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHIẾU KHÁM BỆNH";
            this.Load += new System.EventHandler(this.fMediExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOAIBENHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPKB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MaLoaiBenh;
        private System.Windows.Forms.DateTimePicker NgayKham;
        private System.Windows.Forms.TextBox MaPhieuKham;
        private System.Windows.Forms.TextBox MaBenhNhan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TrieuChung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button In;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.DataGridView gridViewPKB;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.TextBox MaDonThuoc;
        private System.Windows.Forms.Label label3;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource lOAIBENHBindingSource;
        private DataSet1TableAdapters.LOAIBENHTableAdapter lOAIBENHTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView gridViewThuoc;
    }
}