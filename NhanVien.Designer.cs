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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtgv_NhanVien = new DataGridView();
            cb_GioiTinh = new ComboBox();
            btn_Them = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            btn_TimKiem = new Button();
            txt_TenNV = new TextBox();
            txt_QueQuan = new TextBox();
            txt_TimKiem = new TextBox();
            dtp_NgaySinh = new DateTimePicker();
            dtp_NgayVaoLam = new DateTimePicker();
            txt_SDT = new TextBox();
            txt_ChucVu = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgv_NhanVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 45);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên NV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 90);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 45);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(245, 90);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 3;
            label4.Text = "Quê quán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(451, 45);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 4;
            label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(451, 90);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 5;
            label6.Text = "Chức vụ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(670, 45);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 6;
            label7.Text = "Ngày vào làm";
            // 
            // dtgv_NhanVien
            // 
            dtgv_NhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_NhanVien.Location = new Point(33, 232);
            dtgv_NhanVien.Name = "dtgv_NhanVien";
            dtgv_NhanVien.RowHeadersWidth = 51;
            dtgv_NhanVien.Size = new Size(892, 188);
            dtgv_NhanVien.TabIndex = 7;
            dtgv_NhanVien.CellClick += dtgv_NhanVien_CellClick;
            // 
            // cb_GioiTinh
            // 
            cb_GioiTinh.FormattingEnabled = true;
            cb_GioiTinh.Location = new Point(331, 42);
            cb_GioiTinh.Name = "cb_GioiTinh";
            cb_GioiTinh.Size = new Size(69, 28);
            cb_GioiTinh.TabIndex = 8;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(33, 136);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(94, 29);
            btn_Them.TabIndex = 9;
            btn_Them.Text = "Thêm ";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(245, 136);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(94, 29);
            btn_Sua.TabIndex = 10;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(467, 136);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(94, 29);
            btn_Xoa.TabIndex = 11;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.Location = new Point(33, 184);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(94, 29);
            btn_TimKiem.TabIndex = 12;
            btn_TimKiem.Text = "Tìm kiếm";
            btn_TimKiem.UseVisualStyleBackColor = true;
            btn_TimKiem.Click += btn_TimKiem_Click;
            // 
            // txt_TenNV
            // 
            txt_TenNV.Location = new Point(114, 38);
            txt_TenNV.Name = "txt_TenNV";
            txt_TenNV.Size = new Size(125, 27);
            txt_TenNV.TabIndex = 13;
            // 
            // txt_QueQuan
            // 
            txt_QueQuan.Location = new Point(331, 87);
            txt_QueQuan.Name = "txt_QueQuan";
            txt_QueQuan.Size = new Size(114, 27);
            txt_QueQuan.TabIndex = 15;
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(172, 186);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new Size(248, 27);
            txt_TimKiem.TabIndex = 16;
            // 
            // dtp_NgaySinh
            // 
            dtp_NgaySinh.Location = new Point(114, 87);
            dtp_NgaySinh.Name = "dtp_NgaySinh";
            dtp_NgaySinh.Size = new Size(125, 27);
            dtp_NgaySinh.TabIndex = 17;
            // 
            // dtp_NgayVaoLam
            // 
            dtp_NgayVaoLam.Location = new Point(786, 40);
            dtp_NgayVaoLam.Name = "dtp_NgayVaoLam";
            dtp_NgayVaoLam.Size = new Size(139, 27);
            dtp_NgayVaoLam.TabIndex = 18;
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new Point(550, 42);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(114, 27);
            txt_SDT.TabIndex = 19;
            // 
            // txt_ChucVu
            // 
            txt_ChucVu.Location = new Point(550, 83);
            txt_ChucVu.Name = "txt_ChucVu";
            txt_ChucVu.Size = new Size(114, 27);
            txt_ChucVu.TabIndex = 20;
            // 
            // NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 450);
            Controls.Add(txt_ChucVu);
            Controls.Add(txt_SDT);
            Controls.Add(dtp_NgayVaoLam);
            Controls.Add(dtp_NgaySinh);
            Controls.Add(txt_TimKiem);
            Controls.Add(txt_QueQuan);
            Controls.Add(txt_TenNV);
            Controls.Add(btn_TimKiem);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Them);
            Controls.Add(cb_GioiTinh);
            Controls.Add(dtgv_NhanVien);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NhanVien";
            Text = "NhanVien";
            Load += NhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv_NhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox txt_ChucVu;
    }
}