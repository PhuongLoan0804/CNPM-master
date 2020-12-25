namespace cnpm.Presentation
{
    partial class fprescription
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
            this.TimKiemTenBN = new System.Windows.Forms.Button();
            this.TimKiemMaBN = new System.Windows.Forms.Button();
            this.NgayKham = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TimMaBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TimHoTen = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.gridViewDonThuoc = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Xoa = new System.Windows.Forms.Button();
            this.gridViewTTDT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDonThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTTDT)).BeginInit();
            this.SuspendLayout();
            // 
            // TimKiemTenBN
            // 
            this.TimKiemTenBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(251)))));
            this.TimKiemTenBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimKiemTenBN.Location = new System.Drawing.Point(364, 119);
            this.TimKiemTenBN.Name = "TimKiemTenBN";
            this.TimKiemTenBN.Size = new System.Drawing.Size(191, 29);
            this.TimKiemTenBN.TabIndex = 45;
            this.TimKiemTenBN.Text = "Tìm kiếm theo Tên BN";
            this.TimKiemTenBN.UseVisualStyleBackColor = false;
            // 
            // TimKiemMaBN
            // 
            this.TimKiemMaBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(251)))));
            this.TimKiemMaBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimKiemMaBN.Location = new System.Drawing.Point(364, 82);
            this.TimKiemMaBN.Name = "TimKiemMaBN";
            this.TimKiemMaBN.Size = new System.Drawing.Size(176, 29);
            this.TimKiemMaBN.TabIndex = 44;
            this.TimKiemMaBN.Text = "Tìm kiếm theo Mã BN";
            this.TimKiemMaBN.UseVisualStyleBackColor = false;
            // 
            // NgayKham
            // 
            this.NgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayKham.Location = new System.Drawing.Point(206, 57);
            this.NgayKham.Name = "NgayKham";
            this.NgayKham.Size = new System.Drawing.Size(114, 22);
            this.NgayKham.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(713, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = "THÔNG TIN ĐƠN THUỐC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-119, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Họ và tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, -47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "DANH SÁCH KHÁM BỆNH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-119, -5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ngày khám bệnh";
            // 
            // TimMaBN
            // 
            this.TimMaBN.Location = new System.Drawing.Point(164, 89);
            this.TimMaBN.Name = "TimMaBN";
            this.TimMaBN.Size = new System.Drawing.Size(168, 22);
            this.TimMaBN.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-119, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã bệnh nhân:";
            // 
            // TimHoTen
            // 
            this.TimHoTen.Location = new System.Drawing.Point(164, 122);
            this.TimHoTen.Name = "TimHoTen";
            this.TimHoTen.Size = new System.Drawing.Size(168, 22);
            this.TimHoTen.TabIndex = 32;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(970, 513);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 29);
            this.button7.TabIndex = 31;
            this.button7.Text = "Thoát";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // gridViewDonThuoc
            // 
            this.gridViewDonThuoc.BackgroundColor = System.Drawing.Color.Azure;
            this.gridViewDonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDonThuoc.Location = new System.Drawing.Point(8, 161);
            this.gridViewDonThuoc.Name = "gridViewDonThuoc";
            this.gridViewDonThuoc.RowHeadersWidth = 51;
            this.gridViewDonThuoc.RowTemplate.Height = 24;
            this.gridViewDonThuoc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridViewDonThuoc.Size = new System.Drawing.Size(581, 395);
            this.gridViewDonThuoc.TabIndex = 25;
            this.gridViewDonThuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewDonThuoc_CellContentClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(61, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(456, 29);
            this.label13.TabIndex = 53;
            this.label13.Text = "DANH SÁCH ĐƠN THUỐC BỆNH NHÂN";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(106, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 17);
            this.label14.TabIndex = 54;
            this.label14.Text = "Ngày khám ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(48, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 17);
            this.label15.TabIndex = 55;
            this.label15.Text = "Mã bệnh nhân";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(48, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 17);
            this.label16.TabIndex = 56;
            this.label16.Text = "Tên bệnh nhân";
            // 
            // Xoa
            // 
            this.Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(251)))));
            this.Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Xoa.Location = new System.Drawing.Point(773, 513);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(109, 29);
            this.Xoa.TabIndex = 28;
            this.Xoa.Text = "In đơn thuốc";
            this.Xoa.UseVisualStyleBackColor = false;
            // 
            // gridViewTTDT
            // 
            this.gridViewTTDT.BackgroundColor = System.Drawing.Color.Azure;
            this.gridViewTTDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTTDT.Location = new System.Drawing.Point(612, 82);
            this.gridViewTTDT.Name = "gridViewTTDT";
            this.gridViewTTDT.RowHeadersWidth = 51;
            this.gridViewTTDT.RowTemplate.Height = 24;
            this.gridViewTTDT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridViewTTDT.Size = new System.Drawing.Size(455, 410);
            this.gridViewTTDT.TabIndex = 57;
            // 
            // fprescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 564);
            this.Controls.Add(this.gridViewTTDT);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TimKiemTenBN);
            this.Controls.Add(this.TimKiemMaBN);
            this.Controls.Add(this.NgayKham);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TimMaBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimHoTen);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.gridViewDonThuoc);
            this.Controls.Add(this.Xoa);
            this.Name = "fprescription";
            this.Text = "fprescription";
            this.Load += new System.EventHandler(this.fprescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDonThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTTDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TimKiemTenBN;
        private System.Windows.Forms.Button TimKiemMaBN;
        private System.Windows.Forms.DateTimePicker NgayKham;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TimMaBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TimHoTen;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView gridViewDonThuoc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.DataGridView gridViewTTDT;
    }
}