
namespace cnpm.Presentation
{
    partial class fDisease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDisease));
            this.Sua = new System.Windows.Forms.Button();
            this.TenLoaiBenh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Xoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridViewLB = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Them = new System.Windows.Forms.Button();
            this.MaLoaiBenh = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLB)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sua
            // 
            this.Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(251)))));
            this.Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sua.Location = new System.Drawing.Point(168, 297);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(60, 27);
            this.Sua.TabIndex = 12;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = false;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // TenLoaiBenh
            // 
            this.TenLoaiBenh.Location = new System.Drawing.Point(136, 201);
            this.TenLoaiBenh.Name = "TenLoaiBenh";
            this.TenLoaiBenh.Size = new System.Drawing.Size(239, 27);
            this.TenLoaiBenh.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mã loại bệnh:";
            // 
            // Xoa
            // 
            this.Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(251)))));
            this.Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Xoa.Location = new System.Drawing.Point(272, 297);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(60, 27);
            this.Xoa.TabIndex = 7;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = false;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên loại bệnh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN LOẠI BỆNH";
            // 
            // gridViewLB
            // 
            this.gridViewLB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewLB.BackgroundColor = System.Drawing.Color.Azure;
            this.gridViewLB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewLB.Location = new System.Drawing.Point(27, 77);
            this.gridViewLB.Name = "gridViewLB";
            this.gridViewLB.RowHeadersWidth = 51;
            this.gridViewLB.RowTemplate.Height = 24;
            this.gridViewLB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridViewLB.Size = new System.Drawing.Size(639, 477);
            this.gridViewLB.TabIndex = 12;
            this.gridViewLB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewLB_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.gridViewLB);
            this.panel1.Location = new System.Drawing.Point(11, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 562);
            this.panel1.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(211, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "DANH SÁCH LOẠI BỆNH";
            // 
            // Them
            // 
            this.Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(251)))));
            this.Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Them.Location = new System.Drawing.Point(53, 297);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(75, 27);
            this.Them.TabIndex = 9;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = false;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // MaLoaiBenh
            // 
            this.MaLoaiBenh.Location = new System.Drawing.Point(136, 156);
            this.MaLoaiBenh.Name = "MaLoaiBenh";
            this.MaLoaiBenh.Size = new System.Drawing.Size(239, 27);
            this.MaLoaiBenh.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Thoat);
            this.panel2.Controls.Add(this.Sua);
            this.panel2.Controls.Add(this.TenLoaiBenh);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Them);
            this.panel2.Controls.Add(this.Xoa);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.MaLoaiBenh);
            this.panel2.Location = new System.Drawing.Point(701, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 561);
            this.panel2.TabIndex = 32;
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Thoat.Location = new System.Drawing.Point(298, 505);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(65, 28);
            this.Thoat.TabIndex = 13;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = false;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // fDisease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1102, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fDisease";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOẠI BỆNH";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.TextBox TenLoaiBenh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridViewLB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.TextBox MaLoaiBenh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Thoat;
    }
}