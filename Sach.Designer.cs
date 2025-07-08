using System.Drawing;
using System.Windows.Forms;

namespace HSK_BookStoreManagement
{
    partial class Sach
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGiaNhap = new System.Windows.Forms.CheckBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbNXB = new System.Windows.Forms.CheckBox();
            this.cbGiaBan = new System.Windows.Forms.CheckBox();
            this.cbTheLoai = new System.Windows.Forms.CheckBox();
            this.cbTacgia = new System.Windows.Forms.CheckBox();
            this.cbNamXB = new System.Windows.Forms.CheckBox();
            this.cbSoluong = new System.Windows.Forms.CheckBox();
            this.cbTensach = new System.Windows.Forms.CheckBox();
            this.cbMasach = new System.Windows.Forms.CheckBox();
            this.cbbNXB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtTheloai = new System.Windows.Forms.TextBox();
            this.txtTacgia = new System.Windows.Forms.TextBox();
            this.txtNamxuatban = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgdSach = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdSach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGiaNhap);
            this.groupBox1.Controls.Add(this.txtGiaNhap);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbNXB);
            this.groupBox1.Controls.Add(this.cbGiaBan);
            this.groupBox1.Controls.Add(this.cbTheLoai);
            this.groupBox1.Controls.Add(this.cbTacgia);
            this.groupBox1.Controls.Add(this.cbNamXB);
            this.groupBox1.Controls.Add(this.cbSoluong);
            this.groupBox1.Controls.Add(this.cbTensach);
            this.groupBox1.Controls.Add(this.cbMasach);
            this.groupBox1.Controls.Add(this.cbbNXB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.txtTheloai);
            this.groupBox1.Controls.Add(this.txtTacgia);
            this.groupBox1.Controls.Add(this.txtNamxuatban);
            this.groupBox1.Controls.Add(this.txtSoluong);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(417, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách";
            // 
            // cbGiaNhap
            // 
            this.cbGiaNhap.AutoSize = true;
            this.cbGiaNhap.Location = new System.Drawing.Point(359, 215);
            this.cbGiaNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGiaNhap.Name = "cbGiaNhap";
            this.cbGiaNhap.Size = new System.Drawing.Size(18, 17);
            this.cbGiaNhap.TabIndex = 26;
            this.cbGiaNhap.UseVisualStyleBackColor = true;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(128, 209);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(198, 22);
            this.txtGiaNhap.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Giá bán";
            // 
            // cbNXB
            // 
            this.cbNXB.AutoSize = true;
            this.cbNXB.Location = new System.Drawing.Point(359, 267);
            this.cbNXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNXB.Name = "cbNXB";
            this.cbNXB.Size = new System.Drawing.Size(18, 17);
            this.cbNXB.TabIndex = 23;
            this.cbNXB.UseVisualStyleBackColor = true;
            // 
            // cbGiaBan
            // 
            this.cbGiaBan.AutoSize = true;
            this.cbGiaBan.Location = new System.Drawing.Point(359, 240);
            this.cbGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGiaBan.Name = "cbGiaBan";
            this.cbGiaBan.Size = new System.Drawing.Size(18, 17);
            this.cbGiaBan.TabIndex = 22;
            this.cbGiaBan.UseVisualStyleBackColor = true;
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.AutoSize = true;
            this.cbTheLoai.Location = new System.Drawing.Point(359, 183);
            this.cbTheLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(18, 17);
            this.cbTheLoai.TabIndex = 21;
            this.cbTheLoai.UseVisualStyleBackColor = true;
            // 
            // cbTacgia
            // 
            this.cbTacgia.AutoSize = true;
            this.cbTacgia.Location = new System.Drawing.Point(359, 154);
            this.cbTacgia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTacgia.Name = "cbTacgia";
            this.cbTacgia.Size = new System.Drawing.Size(18, 17);
            this.cbTacgia.TabIndex = 20;
            this.cbTacgia.UseVisualStyleBackColor = true;
            // 
            // cbNamXB
            // 
            this.cbNamXB.AutoSize = true;
            this.cbNamXB.Location = new System.Drawing.Point(359, 123);
            this.cbNamXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNamXB.Name = "cbNamXB";
            this.cbNamXB.Size = new System.Drawing.Size(18, 17);
            this.cbNamXB.TabIndex = 19;
            this.cbNamXB.UseVisualStyleBackColor = true;
            // 
            // cbSoluong
            // 
            this.cbSoluong.AutoSize = true;
            this.cbSoluong.Location = new System.Drawing.Point(359, 89);
            this.cbSoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSoluong.Name = "cbSoluong";
            this.cbSoluong.Size = new System.Drawing.Size(18, 17);
            this.cbSoluong.TabIndex = 18;
            this.cbSoluong.UseVisualStyleBackColor = true;
            // 
            // cbTensach
            // 
            this.cbTensach.AutoSize = true;
            this.cbTensach.Location = new System.Drawing.Point(359, 60);
            this.cbTensach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTensach.Name = "cbTensach";
            this.cbTensach.Size = new System.Drawing.Size(18, 17);
            this.cbTensach.TabIndex = 17;
            this.cbTensach.UseVisualStyleBackColor = true;
            // 
            // cbMasach
            // 
            this.cbMasach.AutoSize = true;
            this.cbMasach.Location = new System.Drawing.Point(359, 29);
            this.cbMasach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMasach.Name = "cbMasach";
            this.cbMasach.Size = new System.Drawing.Size(18, 17);
            this.cbMasach.TabIndex = 16;
            this.cbMasach.UseVisualStyleBackColor = true;
            // 
            // cbbNXB
            // 
            this.cbbNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNXB.FormattingEnabled = true;
            this.cbbNXB.Location = new System.Drawing.Point(128, 265);
            this.cbbNXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbNXB.Name = "cbbNXB";
            this.cbbNXB.Size = new System.Drawing.Size(198, 24);
            this.cbbNXB.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhà xuất bản";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(128, 236);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(198, 22);
            this.txtGiaBan.TabIndex = 15;
            // 
            // txtTheloai
            // 
            this.txtTheloai.Location = new System.Drawing.Point(128, 180);
            this.txtTheloai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTheloai.Name = "txtTheloai";
            this.txtTheloai.Size = new System.Drawing.Size(198, 22);
            this.txtTheloai.TabIndex = 14;
            // 
            // txtTacgia
            // 
            this.txtTacgia.Location = new System.Drawing.Point(128, 149);
            this.txtTacgia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTacgia.Name = "txtTacgia";
            this.txtTacgia.Size = new System.Drawing.Size(198, 22);
            this.txtTacgia.TabIndex = 13;
            // 
            // txtNamxuatban
            // 
            this.txtNamxuatban.Location = new System.Drawing.Point(128, 118);
            this.txtNamxuatban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNamxuatban.Name = "txtNamxuatban";
            this.txtNamxuatban.Size = new System.Drawing.Size(198, 22);
            this.txtNamxuatban.TabIndex = 12;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(128, 87);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(198, 22);
            this.txtSoluong.TabIndex = 11;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(128, 55);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(198, 22);
            this.txtTenSP.TabIndex = 10;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Location = new System.Drawing.Point(128, 24);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(198, 22);
            this.txtMaSP.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Năm xuất bản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Giá nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Thể loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tác giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            // 
            // dgdSach
            // 
            this.dgdSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdSach.Location = new System.Drawing.Point(465, 26);
            this.dgdSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgdSach.Name = "dgdSach";
            this.dgdSach.RowHeadersWidth = 51;
            this.dgdSach.Size = new System.Drawing.Size(587, 282);
            this.dgdSach.TabIndex = 1;
            this.dgdSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdSach_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(34, 316);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 29);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(139, 316);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 29);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(245, 316);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 29);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(724, 316);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(143, 29);
            this.btnLammoi.TabIndex = 21;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(909, 316);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(143, 29);
            this.btnLuu.TabIndex = 24;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(351, 316);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(100, 29);
            this.btnTimkiem.TabIndex = 25;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 362);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgdSach);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Sach";
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.Sach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbbNXB;
        private TextBox txtGiaBan;
        private TextBox txtTheloai;
        private TextBox txtTacgia;
        private TextBox txtNamxuatban;
        private TextBox txtSoluong;
        private TextBox txtTenSP;
        private TextBox txtMaSP;
        private Label label9;
        private DataGridView dgdSach;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLammoi;
        private Button btnLuu;
        private CheckBox cbMasach;
        private Button btnTimkiem;
        private CheckBox cbNXB;
        private CheckBox cbGiaBan;
        private CheckBox cbTheLoai;
        private CheckBox cbTacgia;
        private CheckBox cbNamXB;
        private CheckBox cbSoluong;
        private CheckBox cbTensach;
        private CheckBox cbGiaNhap;
        private TextBox txtGiaNhap;
        private Label label8;
    }
}