
namespace cnpm.Presentation
{
    partial class fMedical
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMedical));
            this.Sua = new System.Windows.Forms.Button();
            this.MaDonVi = new System.Windows.Forms.ComboBox();
            this.dONVIBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet21 = new cnpm.DataSet2();
            this.qLPhongMachTuDataSet = new cnpm.QLPhongMachTuDataSet();
            this.DonGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Xoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TenLoaiThuoc = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Thoat = new System.Windows.Forms.Button();
            this.TenDonVi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MaLoaiThuoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Them = new System.Windows.Forms.Button();
            this.dataSet1 = new cnpm.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new cnpm.DataSet2();
            this.dataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLPhongMachTuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLPhongMachTuDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLPhongMachTuDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qLPhongMachTuDataSetBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dONVIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dONVITableAdapter = new cnpm.QLPhongMachTuDataSetTableAdapters.DONVITableAdapter();
            this.tableAdapterManager = new cnpm.QLPhongMachTuDataSetTableAdapters.TableAdapterManager();
            this.dONVIBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dONVITableAdapter1 = new cnpm.DataSet2TableAdapters.DONVITableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridViewThuoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dONVIBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongMachTuDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongMachTuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongMachTuDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongMachTuDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongMachTuDataSetBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONVIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONVIBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // Sua
            // 
            this.Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(251)))));
            this.Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sua.Location = new System.Drawing.Point(179, 370);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(78, 27);
            this.Sua.TabIndex = 24;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = false;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // MaDonVi
            // 
            this.MaDonVi.DataSource = this.dONVIBindingSource2;
            this.MaDonVi.DisplayMember = "MaDonVi";
            this.MaDonVi.FormattingEnabled = true;
            this.MaDonVi.Location = new System.Drawing.Point(123, 196);
            this.MaDonVi.Name = "MaDonVi";
            this.MaDonVi.Size = new System.Drawing.Size(272, 27);
            this.MaDonVi.TabIndex = 22;
            this.MaDonVi.SelectedIndexChanged += new System.EventHandler(this.MaDonVi_SelectedIndexChanged);
            // 
            // dONVIBindingSource2
            // 
            this.dONVIBindingSource2.DataMember = "DONVI";
            this.dONVIBindingSource2.DataSource = this.dataSet21;
            // 
            // dataSet21
            // 
            this.dataSet21.DataSetName = "DataSet2";
            this.dataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLPhongMachTuDataSet
            // 
            this.qLPhongMachTuDataSet.DataSetName = "QLPhongMachTuDataSet";
            this.qLPhongMachTuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DonGia
            // 
            this.DonGia.Location = new System.Drawing.Point(123, 291);
            this.DonGia.Name = "DonGia";
            this.DonGia.Size = new System.Drawing.Size(272, 27);
            this.DonGia.TabIndex = 16;
            this.DonGia.TextChanged += new System.EventHandler(this.DonGia_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Đơn vị tính:";
            // 
            // Xoa
            // 
            this.Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(251)))));
            this.Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Xoa.Location = new System.Drawing.Point(296, 370);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(78, 27);
            this.Xoa.TabIndex = 7;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = false;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đơn giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên thuốc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN THUỐC";
            // 
            // TenLoaiThuoc
            // 
            this.TenLoaiThuoc.Location = new System.Drawing.Point(123, 145);
            this.TenLoaiThuoc.Name = "TenLoaiThuoc";
            this.TenLoaiThuoc.Size = new System.Drawing.Size(272, 27);
            this.TenLoaiThuoc.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Thoat);
            this.panel2.Controls.Add(this.TenDonVi);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.MaLoaiThuoc);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Them);
            this.panel2.Controls.Add(this.Sua);
            this.panel2.Controls.Add(this.MaDonVi);
            this.panel2.Controls.Add(this.DonGia);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Xoa);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TenLoaiThuoc);
            this.panel2.Location = new System.Drawing.Point(683, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 561);
            this.panel2.TabIndex = 38;
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Thoat.Location = new System.Drawing.Point(303, 508);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(71, 32);
            this.Thoat.TabIndex = 29;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = false;
            this.Thoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // TenDonVi
            // 
            this.TenDonVi.Location = new System.Drawing.Point(123, 244);
            this.TenDonVi.Name = "TenDonVi";
            this.TenDonVi.Size = new System.Drawing.Size(272, 27);
            this.TenDonVi.TabIndex = 28;
            this.TenDonVi.TextChanged += new System.EventHandler(this.TenDonVi_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Mã đơn vị ";
            // 
            // MaLoaiThuoc
            // 
            this.MaLoaiThuoc.Location = new System.Drawing.Point(123, 97);
            this.MaLoaiThuoc.Name = "MaLoaiThuoc";
            this.MaLoaiThuoc.Size = new System.Drawing.Size(272, 27);
            this.MaLoaiThuoc.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Mã thuốc";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Them
            // 
            this.Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(251)))));
            this.Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Them.Location = new System.Drawing.Point(64, 370);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(78, 27);
            this.Them.TabIndex = 24;
            this.Them.Text = "Thêm ";
            this.Them.UseVisualStyleBackColor = false;
            this.Them.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet2BindingSource
            // 
            this.dataSet2BindingSource.DataSource = this.dataSet2;
            this.dataSet2BindingSource.Position = 0;
            // 
            // qLPhongMachTuDataSetBindingSource
            // 
            this.qLPhongMachTuDataSetBindingSource.DataSource = this.qLPhongMachTuDataSet;
            this.qLPhongMachTuDataSetBindingSource.Position = 0;
            // 
            // qLPhongMachTuDataSetBindingSource1
            // 
            this.qLPhongMachTuDataSetBindingSource1.DataSource = this.qLPhongMachTuDataSet;
            this.qLPhongMachTuDataSetBindingSource1.Position = 0;
            // 
            // qLPhongMachTuDataSetBindingSource2
            // 
            this.qLPhongMachTuDataSetBindingSource2.DataSource = this.qLPhongMachTuDataSet;
            this.qLPhongMachTuDataSetBindingSource2.Position = 0;
            // 
            // qLPhongMachTuDataSetBindingSource3
            // 
            this.qLPhongMachTuDataSetBindingSource3.DataSource = this.qLPhongMachTuDataSet;
            this.qLPhongMachTuDataSetBindingSource3.Position = 0;
            // 
            // dONVIBindingSource
            // 
            this.dONVIBindingSource.DataMember = "DONVI";
            this.dONVIBindingSource.DataSource = this.qLPhongMachTuDataSet;
            // 
            // dONVITableAdapter
            // 
            this.dONVITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BENHNHANTableAdapter = null;
            this.tableAdapterManager.CACHDUNGTableAdapter = null;
            this.tableAdapterManager.DONTHUOCTableAdapter = null;
            this.tableAdapterManager.DONVITableAdapter = this.dONVITableAdapter;
            this.tableAdapterManager.DS_KHAMBENHTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.LOAIBENHTableAdapter = null;
            this.tableAdapterManager.LOAITHUOCTableAdapter = null;
            this.tableAdapterManager.PHIEUKHAMTableAdapter = null;
            this.tableAdapterManager.THAMSOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = cnpm.QLPhongMachTuDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dONVIBindingSource1
            // 
            this.dONVIBindingSource1.DataMember = "DONVI";
            this.dONVIBindingSource1.DataSource = this.dataSet2;
            // 
            // dONVITableAdapter1
            // 
            this.dONVITableAdapter1.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(207, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "DANH SÁCH THUỐC";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridViewThuoc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(11, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 562);
            this.panel1.TabIndex = 37;
            // 
            // gridViewThuoc
            // 
            this.gridViewThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewThuoc.Location = new System.Drawing.Point(3, 82);
            this.gridViewThuoc.Name = "gridViewThuoc";
            this.gridViewThuoc.RowHeadersWidth = 51;
            this.gridViewThuoc.RowTemplate.Height = 24;
            this.gridViewThuoc.Size = new System.Drawing.Size(660, 477);
            this.gridViewThuoc.TabIndex = 14;
            this.gridViewThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewThuoc_CellClick_1);
            this.gridViewThuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewThuoc_CellContentClick);
            // 
            // fMedical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1102, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMedical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH THUỐC";
            this.Load += new System.EventHandler(this.fMedical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dONVIBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongMachTuDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongMachTuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongMachTuDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongMachTuDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongMachTuDataSetBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONVIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONVIBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.ComboBox MaDonVi;
        private System.Windows.Forms.TextBox DonGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TenLoaiThuoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MaLoaiThuoc;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.TextBox TenDonVi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource qLPhongMachTuDataSetBindingSource1;
        private QLPhongMachTuDataSet qLPhongMachTuDataSet;
        private System.Windows.Forms.BindingSource qLPhongMachTuDataSetBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource dataSet2BindingSource;
        private System.Windows.Forms.BindingSource qLPhongMachTuDataSetBindingSource2;
        private System.Windows.Forms.BindingSource qLPhongMachTuDataSetBindingSource3;
        private System.Windows.Forms.BindingSource dONVIBindingSource;
        private QLPhongMachTuDataSetTableAdapters.DONVITableAdapter dONVITableAdapter;
        private QLPhongMachTuDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource dONVIBindingSource1;
        private DataSet2TableAdapters.DONVITableAdapter dONVITableAdapter1;
        private DataSet2 dataSet21;
        private System.Windows.Forms.BindingSource dONVIBindingSource2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridViewThuoc;
    }
}