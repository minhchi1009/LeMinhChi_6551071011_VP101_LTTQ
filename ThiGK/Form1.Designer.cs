namespace ThiGK
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbThongTin = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtLuongThang = new TextBox();
            txtTenCV = new TextBox();
            txtMaCV = new TextBox();
            lblTitle = new Label();
            label2 = new Label();
            dgvDSCV = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSCV).BeginInit();
            SuspendLayout();
            // 
            // grbThongTin
            // 
            grbThongTin.Controls.Add(label4);
            grbThongTin.Controls.Add(label3);
            grbThongTin.Controls.Add(label1);
            grbThongTin.Controls.Add(txtLuongThang);
            grbThongTin.Controls.Add(txtTenCV);
            grbThongTin.Controls.Add(txtMaCV);
            grbThongTin.Location = new Point(41, 91);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Size = new Size(698, 207);
            grbThongTin.TabIndex = 0;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông tin công việc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 141);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 2;
            label4.Text = "Lương tháng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 95);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên công việc:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 50);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã công việc:";
            // 
            // txtLuongThang
            // 
            txtLuongThang.Location = new Point(365, 141);
            txtLuongThang.Name = "txtLuongThang";
            txtLuongThang.Size = new Size(241, 27);
            txtLuongThang.TabIndex = 0;
            // 
            // txtTenCV
            // 
            txtTenCV.Location = new Point(365, 92);
            txtTenCV.Name = "txtTenCV";
            txtTenCV.Size = new Size(241, 27);
            txtTenCV.TabIndex = 0;
            // 
            // txtMaCV
            // 
            txtMaCV.Location = new Point(365, 43);
            txtMaCV.Name = "txtMaCV";
            txtMaCV.Size = new Size(241, 27);
            txtMaCV.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(229, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(328, 38);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "DANH MỤC CÔNG VIỆC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 310);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 2;
            label2.Text = "Danh sách công việc";
            label2.Click += label2_Click;
            // 
            // dgvDSCV
            // 
            dgvDSCV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSCV.Location = new Point(41, 333);
            dgvDSCV.Name = "dgvDSCV";
            dgvDSCV.RowHeadersWidth = 51;
            dgvDSCV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSCV.Size = new Size(698, 147);
            dgvDSCV.TabIndex = 3;
            dgvDSCV.CellClick += dgvDSCV_CellClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(41, 506);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 64);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(188, 506);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(114, 64);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(371, 506);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 64);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(540, 506);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 64);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 582);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvDSCV);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Controls.Add(grbThongTin);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSCV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbThongTin;
        private Label label3;
        private Label label1;
        private TextBox txtLuongThang;
        private TextBox txtTenCV;
        private TextBox txtMaCV;
        private Label lblTitle;
        private Label label2;
        private DataGridView dgvDSCV;
        private Label label4;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
    }
}
