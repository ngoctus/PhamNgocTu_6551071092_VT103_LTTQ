namespace QuanLyThuVien
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
            components = new System.ComponentModel.Container();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            groupBox1 = new GroupBox();
            txtGiaTien = new TextBox();
            txtTenSach = new TextBox();
            txtMaSach = new TextBox();
            lblGiaTien = new Label();
            lblTenSach = new Label();
            lblMaSach = new Label();
            groupBox2 = new GroupBox();
            dgvSach = new DataGridView();
            congViecBindingSource = new BindingSource(components);
            colMaSach = new DataGridViewTextBoxColumn();
            colTenSach = new DataGridViewTextBoxColumn();
            colGiaTien = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)congViecBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Location = new Point(298, 35);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(127, 57);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(636, 35);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(127, 57);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(467, 35);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(127, 57);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(795, 35);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(127, 57);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGiaTien);
            groupBox1.Controls.Add(txtTenSach);
            groupBox1.Controls.Add(txtMaSach);
            groupBox1.Controls.Add(lblGiaTien);
            groupBox1.Controls.Add(lblTenSach);
            groupBox1.Controls.Add(lblMaSach);
            groupBox1.Location = new Point(12, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 418);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
            // 
            // txtGiaTien
            // 
            txtGiaTien.Location = new Point(21, 297);
            txtGiaTien.Name = "txtGiaTien";
            txtGiaTien.Size = new Size(191, 27);
            txtGiaTien.TabIndex = 5;
            txtGiaTien.KeyPress += txtGiaTien_KeyPress;
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(21, 178);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(191, 27);
            txtTenSach.TabIndex = 4;
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(21, 73);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(191, 27);
            txtMaSach.TabIndex = 3;
            // 
            // lblGiaTien
            // 
            lblGiaTien.AutoSize = true;
            lblGiaTien.Location = new Point(21, 274);
            lblGiaTien.Name = "lblGiaTien";
            lblGiaTien.Size = new Size(60, 20);
            lblGiaTien.TabIndex = 2;
            lblGiaTien.Text = "Giá tiền";
            // 
            // lblTenSach
            // 
            lblTenSach.AutoSize = true;
            lblTenSach.Location = new Point(21, 155);
            lblTenSach.Name = "lblTenSach";
            lblTenSach.Size = new Size(65, 20);
            lblTenSach.TabIndex = 1;
            lblTenSach.Text = "Tên sách";
            // 
            // lblMaSach
            // 
            lblMaSach.AutoSize = true;
            lblMaSach.Location = new Point(21, 50);
            lblMaSach.Name = "lblMaSach";
            lblMaSach.Size = new Size(63, 20);
            lblMaSach.TabIndex = 0;
            lblMaSach.Text = "Mã sách";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvSach);
            groupBox2.Location = new Point(297, 129);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(625, 324);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sách";
            // 
            // dgvSach
            // 
            dgvSach.AutoGenerateColumns = false;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Columns.AddRange(new DataGridViewColumn[] { colMaSach, colTenSach, colGiaTien });
            dgvSach.DataSource = congViecBindingSource;
            dgvSach.Location = new Point(17, 30);
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersWidth = 51;
            dgvSach.Size = new Size(595, 283);
            dgvSach.TabIndex = 0;
            dgvSach.CellClick += dgvSach_CellClick;
            // 
            // congViecBindingSource
            // 
            congViecBindingSource.DataSource = typeof(Models.CongViec);
            // 
            // colMaSach
            // 
            colMaSach.DataPropertyName = "MaSach";
            colMaSach.HeaderText = "Mã sách";
            colMaSach.MinimumWidth = 6;
            colMaSach.Name = "colMaSach";
            colMaSach.Width = 125;
            // 
            // colTenSach
            // 
            colTenSach.DataPropertyName = "TenSach";
            colTenSach.HeaderText = "Tên sách";
            colTenSach.MinimumWidth = 6;
            colTenSach.Name = "colTenSach";
            colTenSach.Width = 125;
            // 
            // colGiaTien
            // 
            colGiaTien.DataPropertyName = "GiaTien";
            colGiaTien.HeaderText = "Giá tiền";
            colGiaTien.MinimumWidth = 6;
            colGiaTien.Name = "colGiaTien";
            colGiaTien.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 478);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnThoat);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Thư Viện - VP103";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)congViecBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThoat;
        private GroupBox groupBox1;
        private TextBox txtGiaTien;
        private TextBox txtTenSach;
        private TextBox txtMaSach;
        private Label lblGiaTien;
        private Label lblTenSach;
        private Label lblMaSach;
        private GroupBox groupBox2;
        private DataGridView dgvSach;
        private DataGridViewTextBoxColumn colMaSach;
        private DataGridViewTextBoxColumn colTenSach;
        private DataGridViewTextBoxColumn colGiaTien;
        private BindingSource congViecBindingSource;
    }
}
