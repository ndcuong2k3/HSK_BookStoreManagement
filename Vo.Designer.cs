namespace HSK_BookStoreManagement
{
    partial class Vo
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
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgdVo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSoLuong = new System.Windows.Forms.CheckBox();
            this.cbKieuDongKe = new System.Windows.Forms.CheckBox();
            this.txtKieuDongKe = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSoTrang = new System.Windows.Forms.CheckBox();
            this.txtSoTrang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGiaNhap = new System.Windows.Forms.CheckBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbNhaSX = new System.Windows.Forms.CheckBox();
            this.cbGiaBan = new System.Windows.Forms.CheckBox();
            this.cbTenSP = new System.Windows.Forms.CheckBox();
            this.cbMaSP = new System.Windows.Forms.CheckBox();
            this.cbbDVSX = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgdVo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(351, 318);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(100, 29);
            this.btnTimkiem.TabIndex = 33;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(909, 318);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(143, 29);
            this.btnLuu.TabIndex = 32;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuuVo_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(724, 318);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(143, 29);
            this.btnLammoi.TabIndex = 31;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(245, 318);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 29);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(139, 318);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 29);
            this.btnSua.TabIndex = 29;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgdVo
            // 
            this.dgdVo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdVo.Location = new System.Drawing.Point(465, 28);
            this.dgdVo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgdVo.Name = "dgdVo";
            this.dgdVo.RowHeadersWidth = 51;
            this.dgdVo.Size = new System.Drawing.Size(587, 282);
            this.dgdVo.TabIndex = 27;
            this.dgdVo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdSach_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSoLuong);
            this.groupBox1.Controls.Add(this.cbKieuDongKe);
            this.groupBox1.Controls.Add(this.txtKieuDongKe);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbSoTrang);
            this.groupBox1.Controls.Add(this.txtSoTrang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbGiaNhap);
            this.groupBox1.Controls.Add(this.txtGiaNhap);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbNhaSX);
            this.groupBox1.Controls.Add(this.cbGiaBan);
            this.groupBox1.Controls.Add(this.cbTenSP);
            this.groupBox1.Controls.Add(this.cbMaSP);
            this.groupBox1.Controls.Add(this.cbbDVSX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(417, 297);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin vở";
            // 
            // cbSoLuong
            // 
            this.cbSoLuong.AutoSize = true;
            this.cbSoLuong.Location = new System.Drawing.Point(367, 102);
            this.cbSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSoLuong.Name = "cbSoLuong";
            this.cbSoLuong.Size = new System.Drawing.Size(18, 17);
            this.cbSoLuong.TabIndex = 35;
            this.cbSoLuong.UseVisualStyleBackColor = true;
            // 
            // cbKieuDongKe
            // 
            this.cbKieuDongKe.AutoSize = true;
            this.cbKieuDongKe.Location = new System.Drawing.Point(367, 165);
            this.cbKieuDongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKieuDongKe.Name = "cbKieuDongKe";
            this.cbKieuDongKe.Size = new System.Drawing.Size(18, 17);
            this.cbKieuDongKe.TabIndex = 32;
            this.cbKieuDongKe.UseVisualStyleBackColor = true;
            // 
            // txtKieuDongKe
            // 
            this.txtKieuDongKe.Location = new System.Drawing.Point(136, 160);
            this.txtKieuDongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKieuDongKe.Name = "txtKieuDongKe";
            this.txtKieuDongKe.Size = new System.Drawing.Size(198, 22);
            this.txtKieuDongKe.TabIndex = 31;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(136, 97);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(198, 22);
            this.txtSoLuong.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Kiểu dòng kẻ";
            // 
            // cbSoTrang
            // 
            this.cbSoTrang.AutoSize = true;
            this.cbSoTrang.Location = new System.Drawing.Point(367, 133);
            this.cbSoTrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSoTrang.Name = "cbSoTrang";
            this.cbSoTrang.Size = new System.Drawing.Size(18, 17);
            this.cbSoTrang.TabIndex = 29;
            this.cbSoTrang.UseVisualStyleBackColor = true;
            // 
            // txtSoTrang
            // 
            this.txtSoTrang.Location = new System.Drawing.Point(136, 128);
            this.txtSoTrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoTrang.Name = "txtSoTrang";
            this.txtSoTrang.Size = new System.Drawing.Size(198, 22);
            this.txtSoTrang.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Số trang";
            // 
            // cbGiaNhap
            // 
            this.cbGiaNhap.AutoSize = true;
            this.cbGiaNhap.Location = new System.Drawing.Point(367, 197);
            this.cbGiaNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGiaNhap.Name = "cbGiaNhap";
            this.cbGiaNhap.Size = new System.Drawing.Size(18, 17);
            this.cbGiaNhap.TabIndex = 26;
            this.cbGiaNhap.UseVisualStyleBackColor = true;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(136, 191);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(198, 22);
            this.txtGiaNhap.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Giá bán";
            // 
            // cbNhaSX
            // 
            this.cbNhaSX.AutoSize = true;
            this.cbNhaSX.Location = new System.Drawing.Point(367, 258);
            this.cbNhaSX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNhaSX.Name = "cbNhaSX";
            this.cbNhaSX.Size = new System.Drawing.Size(18, 17);
            this.cbNhaSX.TabIndex = 23;
            this.cbNhaSX.UseVisualStyleBackColor = true;
            // 
            // cbGiaBan
            // 
            this.cbGiaBan.AutoSize = true;
            this.cbGiaBan.Location = new System.Drawing.Point(367, 228);
            this.cbGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGiaBan.Name = "cbGiaBan";
            this.cbGiaBan.Size = new System.Drawing.Size(18, 17);
            this.cbGiaBan.TabIndex = 22;
            this.cbGiaBan.UseVisualStyleBackColor = true;
            // 
            // cbTenSP
            // 
            this.cbTenSP.AutoSize = true;
            this.cbTenSP.Location = new System.Drawing.Point(367, 71);
            this.cbTenSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTenSP.Name = "cbTenSP";
            this.cbTenSP.Size = new System.Drawing.Size(18, 17);
            this.cbTenSP.TabIndex = 17;
            this.cbTenSP.UseVisualStyleBackColor = true;
            // 
            // cbMaSP
            // 
            this.cbMaSP.AutoSize = true;
            this.cbMaSP.Location = new System.Drawing.Point(367, 39);
            this.cbMaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaSP.Name = "cbMaSP";
            this.cbMaSP.Size = new System.Drawing.Size(18, 17);
            this.cbMaSP.TabIndex = 16;
            this.cbMaSP.UseVisualStyleBackColor = true;
            // 
            // cbbDVSX
            // 
            this.cbbDVSX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDVSX.FormattingEnabled = true;
            this.cbbDVSX.Location = new System.Drawing.Point(136, 256);
            this.cbbDVSX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDVSX.Name = "cbbDVSX";
            this.cbbDVSX.Size = new System.Drawing.Size(198, 24);
            this.cbbDVSX.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhà sản xuất";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(136, 224);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(198, 22);
            this.txtGiaBan.TabIndex = 15;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(136, 66);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(198, 22);
            this.txtTenSP.TabIndex = 10;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Location = new System.Drawing.Point(136, 34);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(198, 22);
            this.txtMaSP.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Giá nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên vở";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã vở";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(34, 318);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 29);
            this.btnThem.TabIndex = 34;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Vo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 362);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgdVo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Vo";
            this.Text = "Vo";
            this.Load += new System.EventHandler(this.Vo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdVo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgdVo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbNhaSX;
        private System.Windows.Forms.CheckBox cbGiaBan;
        private System.Windows.Forms.CheckBox cbTenSP;
        private System.Windows.Forms.CheckBox cbMaSP;
        private System.Windows.Forms.ComboBox cbbDVSX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbGiaNhap;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.CheckBox cbSoTrang;
        private System.Windows.Forms.TextBox txtSoTrang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbKieuDongKe;
        private System.Windows.Forms.TextBox txtKieuDongKe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThem;
    }
}