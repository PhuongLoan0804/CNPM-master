
namespace cnpm.Presentation
{
    partial class fUsage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUsage));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.gridViewCD = new System.Windows.Forms.DataGridView();
            this.Xoa = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Them = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Thoat = new System.Windows.Forms.Button();
            this.TenCD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaCD = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCD)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "CÁCH DÙNG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.gridViewCD);
            this.panel1.Location = new System.Drawing.Point(9, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 562);
            this.panel1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(209, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "DANH SÁCH CÁCH DÙNG";
            // 
            // gridViewCD
            // 
            this.gridViewCD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewCD.BackgroundColor = System.Drawing.Color.Azure;
            this.gridViewCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCD.Location = new System.Drawing.Point(27, 77);
            this.gridViewCD.Name = "gridViewCD";
            this.gridViewCD.RowHeadersWidth = 51;
            this.gridViewCD.RowTemplate.Height = 24;
            this.gridViewCD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridViewCD.Size = new System.Drawing.Size(639, 477);
            this.gridViewCD.TabIndex = 12;
            this.gridViewCD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewCD_CellClick);
            // 
            // Xoa
            // 
            this.Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(251)))));
            this.Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Xoa.Location = new System.Drawing.Point(275, 333);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(75, 27);
            this.Xoa.TabIndex = 11;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = false;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Sua
            // 
            this.Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(251)))));
            this.Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sua.Location = new System.Drawing.Point(170, 333);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(75, 27);
            this.Sua.TabIndex = 10;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = false;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Them
            // 
            this.Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(251)))));
            this.Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Them.Location = new System.Drawing.Point(65, 333);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(75, 27);
            this.Them.TabIndex = 9;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = false;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Thoat);
            this.panel2.Controls.Add(this.TenCD);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.MaCD);
            this.panel2.Controls.Add(this.Xoa);
            this.panel2.Controls.Add(this.Them);
            this.panel2.Controls.Add(this.Sua);
            this.panel2.Location = new System.Drawing.Point(699, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 561);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Thoat.Location = new System.Drawing.Point(289, 507);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(61, 32);
            this.Thoat.TabIndex = 14;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = false;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // TenCD
            // 
            this.TenCD.Location = new System.Drawing.Point(22, 262);
            this.TenCD.Name = "TenCD";
            this.TenCD.Size = new System.Drawing.Size(349, 27);
            this.TenCD.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã cách dùng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên cách dùng:";
            // 
            // MaCD
            // 
            this.MaCD.Location = new System.Drawing.Point(22, 185);
            this.MaCD.Multiline = true;
            this.MaCD.Name = "MaCD";
            this.MaCD.Size = new System.Drawing.Size(349, 30);
            this.MaCD.TabIndex = 0;
            // 
            // fUsage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1102, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fUsage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CÁCH DÙNG";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCD)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridViewCD;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaCD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TenCD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Thoat;
    }
}