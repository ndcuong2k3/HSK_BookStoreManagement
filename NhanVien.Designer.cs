using System.Drawing;
using System.Windows.Forms;

namespace HSK_BookStoreManagement
{
    partial class NhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.cb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.txt_QueQuan = new System.Windows.Forms.TextBox();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.btn_In = new System.Windows.Forms.Button();
            this.cbb_ChucVu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quê quán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chức vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(670, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày vào làm";
            // 
            // dtgv_NhanVien
            // 
            this.dtgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_NhanVien.Location = new System.Drawing.Point(33, 186);
            this.dtgv_NhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_NhanVien.Name = "dtgv_NhanVien";
            this.dtgv_NhanVien.RowHeadersWidth = 51;
            this.dtgv_NhanVien.Size = new System.Drawing.Size(892, 185);
            this.dtgv_NhanVien.TabIndex = 7;
            this.dtgv_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_NhanVien_CellClick);
            // 
            // cb_GioiTinh
            // 
            this.cb_GioiTinh.FormattingEnabled = true;
            this.cb_GioiTinh.Location = new System.Drawing.Point(331, 34);
            this.cb_GioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_GioiTinh.Name = "cb_GioiTinh";
            this.cb_GioiTinh.Size = new System.Drawing.Size(114, 24);
            this.cb_GioiTinh.TabIndex = 8;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(67, 108);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(100, 29);
            this.btn_Them.TabIndex = 9;
            this.btn_Them.Text = "Thêm ";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(331, 108);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(100, 29);
            this.btn_Sua.TabIndex = 10;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(564, 108);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(100, 29);
            this.btn_Xoa.TabIndex = 11;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(527, 149);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(100, 29);
            this.btn_TimKiem.TabIndex = 12;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Location = new System.Drawing.Point(114, 30);
            this.txt_TenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(125, 22);
            this.txt_TenNV.TabIndex = 13;
            // 
            // txt_QueQuan
            // 
            this.txt_QueQuan.Location = new System.Drawing.Point(331, 70);
            this.txt_QueQuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_QueQuan.Name = "txt_QueQuan";
            this.txt_QueQuan.Size = new System.Drawing.Size(114, 22);
            this.txt_QueQuan.TabIndex = 15;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(248, 156);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(248, 22);
            this.txt_TimKiem.TabIndex = 16;
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Location = new System.Drawing.Point(114, 70);
            this.dtp_NgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(125, 22);
            this.dtp_NgaySinh.TabIndex = 17;
            // 
            // dtp_NgayVaoLam
            // 
            this.dtp_NgayVaoLam.Location = new System.Drawing.Point(786, 32);
            this.dtp_NgayVaoLam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_NgayVaoLam.Name = "dtp_NgayVaoLam";
            this.dtp_NgayVaoLam.Size = new System.Drawing.Size(139, 22);
            this.dtp_NgayVaoLam.TabIndex = 18;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(550, 34);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(114, 22);
            this.txt_SDT.TabIndex = 19;
            // 
            // btn_In
            // 
            this.btn_In.Location = new System.Drawing.Point(786, 108);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(100, 29);
            this.btn_In.TabIndex = 21;
            this.btn_In.Text = "IN";
            this.btn_In.UseVisualStyleBackColor = true;
            this.btn_In.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // cbb_ChucVu
            // 
            this.cbb_ChucVu.FormattingEnabled = true;
            this.cbb_ChucVu.Location = new System.Drawing.Point(550, 72);
            this.cbb_ChucVu.Name = "cbb_ChucVu";
            this.cbb_ChucVu.Size = new System.Drawing.Size(114, 24);
            this.cbb_ChucVu.TabIndex = 22;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 382);
            this.Controls.Add(this.cbb_ChucVu);
            this.Controls.Add(this.btn_In);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.dtp_NgayVaoLam);
            this.Controls.Add(this.dtp_NgaySinh);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.txt_QueQuan);
            this.Controls.Add(this.txt_TenNV);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.cb_GioiTinh);
            this.Controls.Add(this.dtgv_NhanVien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_NhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dtgv_NhanVien;
        private ComboBox cb_GioiTinh;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Xoa;
        private Button btn_TimKiem;
        private TextBox txt_TenNV;
        private TextBox txt_QueQuan;
        private TextBox txt_TimKiem;
        private DateTimePicker dtp_NgaySinh;
        private DateTimePicker dtp_NgayVaoLam;
        private TextBox txt_SDT;
        private Button btn_In;
        private ComboBox cbb_ChucVu;
    }
}