using System.Drawing;
using System.Windows.Forms;

namespace HSK_BookStoreManagement
{
    partial class DonViSanXuat
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
            this.TenDVSX = new System.Windows.Forms.TextBox();
            this.SoDienThoai = new System.Windows.Forms.TextBox();
            this.DiaChi = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.dtgv_DVSX = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSDT = new System.Windows.Forms.CheckBox();
            this.cbDiaChi = new System.Windows.Forms.CheckBox();
            this.cbTenDVSX = new System.Windows.Forms.CheckBox();
            this.cbMaDVSX = new System.Windows.Forms.CheckBox();
            this.MaDVSX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DVSX)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đơn vị sản xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // TenDVSX
            // 
            this.TenDVSX.Location = new System.Drawing.Point(164, 93);
            this.TenDVSX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TenDVSX.Name = "TenDVSX";
            this.TenDVSX.Size = new System.Drawing.Size(207, 22);
            this.TenDVSX.TabIndex = 3;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.Location = new System.Drawing.Point(164, 165);
            this.SoDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Size = new System.Drawing.Size(207, 22);
            this.SoDienThoai.TabIndex = 4;
            // 
            // DiaChi
            // 
            this.DiaChi.Location = new System.Drawing.Point(164, 127);
            this.DiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(207, 22);
            this.DiaChi.TabIndex = 5;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(28, 274);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(100, 29);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(134, 274);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(100, 29);
            this.btn_Sua.TabIndex = 7;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(240, 274);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(100, 29);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.Location = new System.Drawing.Point(346, 274);
            this.btn_timKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(100, 29);
            this.btn_timKiem.TabIndex = 9;
            this.btn_timKiem.Text = "Tìm kiếm";
            this.btn_timKiem.UseVisualStyleBackColor = true;
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // dtgv_DVSX
            // 
            this.dtgv_DVSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DVSX.Location = new System.Drawing.Point(497, 29);
            this.dtgv_DVSX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_DVSX.Name = "dtgv_DVSX";
            this.dtgv_DVSX.RowHeadersWidth = 51;
            this.dtgv_DVSX.Size = new System.Drawing.Size(509, 234);
            this.dtgv_DVSX.TabIndex = 10;
            this.dtgv_DVSX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_DVSX_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSDT);
            this.groupBox1.Controls.Add(this.cbDiaChi);
            this.groupBox1.Controls.Add(this.cbTenDVSX);
            this.groupBox1.Controls.Add(this.cbMaDVSX);
            this.groupBox1.Controls.Add(this.MaDVSX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TenDVSX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SoDienThoai);
            this.groupBox1.Controls.Add(this.DiaChi);
            this.groupBox1.Location = new System.Drawing.Point(28, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 234);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn vị sản xuất";
            // 
            // cbSDT
            // 
            this.cbSDT.AutoSize = true;
            this.cbSDT.Location = new System.Drawing.Point(391, 169);
            this.cbSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSDT.Name = "cbSDT";
            this.cbSDT.Size = new System.Drawing.Size(18, 17);
            this.cbSDT.TabIndex = 23;
            this.cbSDT.UseVisualStyleBackColor = true;
            // 
            // cbDiaChi
            // 
            this.cbDiaChi.AutoSize = true;
            this.cbDiaChi.Location = new System.Drawing.Point(391, 131);
            this.cbDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDiaChi.Name = "cbDiaChi";
            this.cbDiaChi.Size = new System.Drawing.Size(18, 17);
            this.cbDiaChi.TabIndex = 22;
            this.cbDiaChi.UseVisualStyleBackColor = true;
            // 
            // cbTenDVSX
            // 
            this.cbTenDVSX.AutoSize = true;
            this.cbTenDVSX.Location = new System.Drawing.Point(391, 98);
            this.cbTenDVSX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTenDVSX.Name = "cbTenDVSX";
            this.cbTenDVSX.Size = new System.Drawing.Size(18, 17);
            this.cbTenDVSX.TabIndex = 21;
            this.cbTenDVSX.UseVisualStyleBackColor = true;
            // 
            // cbMaDVSX
            // 
            this.cbMaDVSX.AutoSize = true;
            this.cbMaDVSX.Location = new System.Drawing.Point(391, 64);
            this.cbMaDVSX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaDVSX.Name = "cbMaDVSX";
            this.cbMaDVSX.Size = new System.Drawing.Size(18, 17);
            this.cbMaDVSX.TabIndex = 20;
            this.cbMaDVSX.UseVisualStyleBackColor = true;
            // 
            // MaDVSX
            // 
            this.MaDVSX.Enabled = false;
            this.MaDVSX.Location = new System.Drawing.Point(164, 58);
            this.MaDVSX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaDVSX.Name = "MaDVSX";
            this.MaDVSX.Size = new System.Drawing.Size(207, 22);
            this.MaDVSX.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã đơn vị sản xuất";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(897, 278);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 29);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(757, 278);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(100, 29);
            this.btnLammoi.TabIndex = 13;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.button2_Click);
            // 
            // DonViSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 327);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgv_DVSX);
            this.Controls.Add(this.btn_timKiem);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DonViSanXuat";
            this.Text = "Đơn vị sản xuất";
            this.Load += new System.EventHandler(this.DonViSanXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DVSX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TenDVSX;
        private TextBox SoDienThoai;
        private TextBox DiaChi;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Xoa;
        private Button btn_timKiem;
        private DataGridView dtgv_DVSX;
        private GroupBox groupBox1;
        private TextBox MaDVSX;
        private Label label4;
        private CheckBox cbSDT;
        private CheckBox cbDiaChi;
        private CheckBox cbTenDVSX;
        private CheckBox cbMaDVSX;
        private Button btnLuu;
        private Button btnLammoi;
    }
}