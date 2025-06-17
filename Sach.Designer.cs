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
            this.cbNXB = new System.Windows.Forms.CheckBox();
            this.cbGia = new System.Windows.Forms.CheckBox();
            this.cbTheLoai = new System.Windows.Forms.CheckBox();
            this.cbTacgia = new System.Windows.Forms.CheckBox();
            this.cbNamXB = new System.Windows.Forms.CheckBox();
            this.cbSoluong = new System.Windows.Forms.CheckBox();
            this.cbTensach = new System.Windows.Forms.CheckBox();
            this.cbMasach = new System.Windows.Forms.CheckBox();
            this.cbbNXB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTheloai = new System.Windows.Forms.TextBox();
            this.txtTacgia = new System.Windows.Forms.TextBox();
            this.txtNamxuatban = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtTensach = new System.Windows.Forms.TextBox();
            this.txtMasach = new System.Windows.Forms.TextBox();
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
            this.button6 = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdSach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNXB);
            this.groupBox1.Controls.Add(this.cbGia);
            this.groupBox1.Controls.Add(this.cbTheLoai);
            this.groupBox1.Controls.Add(this.cbTacgia);
            this.groupBox1.Controls.Add(this.cbNamXB);
            this.groupBox1.Controls.Add(this.cbSoluong);
            this.groupBox1.Controls.Add(this.cbTensach);
            this.groupBox1.Controls.Add(this.cbMasach);
            this.groupBox1.Controls.Add(this.cbbNXB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.txtTheloai);
            this.groupBox1.Controls.Add(this.txtTacgia);
            this.groupBox1.Controls.Add(this.txtNamxuatban);
            this.groupBox1.Controls.Add(this.txtSoluong);
            this.groupBox1.Controls.Add(this.txtTensach);
            this.groupBox1.Controls.Add(this.txtMasach);
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
            this.groupBox1.Size = new System.Drawing.Size(417, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách";
            // 
            // cbNXB
            // 
            this.cbNXB.AutoSize = true;
            this.cbNXB.Location = new System.Drawing.Point(359, 252);
            this.cbNXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNXB.Name = "cbNXB";
            this.cbNXB.Size = new System.Drawing.Size(18, 17);
            this.cbNXB.TabIndex = 23;
            this.cbNXB.UseVisualStyleBackColor = true;
            // 
            // cbGia
            // 
            this.cbGia.AutoSize = true;
            this.cbGia.Location = new System.Drawing.Point(359, 221);
            this.cbGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGia.Name = "cbGia";
            this.cbGia.Size = new System.Drawing.Size(18, 17);
            this.cbGia.TabIndex = 22;
            this.cbGia.UseVisualStyleBackColor = true;
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.AutoSize = true;
            this.cbTheLoai.Location = new System.Drawing.Point(359, 190);
            this.cbTheLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(18, 17);
            this.cbTheLoai.TabIndex = 21;
            this.cbTheLoai.UseVisualStyleBackColor = true;
            // 
            // cbTacgia
            // 
            this.cbTacgia.AutoSize = true;
            this.cbTacgia.Location = new System.Drawing.Point(359, 161);
            this.cbTacgia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTacgia.Name = "cbTacgia";
            this.cbTacgia.Size = new System.Drawing.Size(18, 17);
            this.cbTacgia.TabIndex = 20;
            this.cbTacgia.UseVisualStyleBackColor = true;
            // 
            // cbNamXB
            // 
            this.cbNamXB.AutoSize = true;
            this.cbNamXB.Location = new System.Drawing.Point(359, 130);
            this.cbNamXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNamXB.Name = "cbNamXB";
            this.cbNamXB.Size = new System.Drawing.Size(18, 17);
            this.cbNamXB.TabIndex = 19;
            this.cbNamXB.UseVisualStyleBackColor = true;
            // 
            // cbSoluong
            // 
            this.cbSoluong.AutoSize = true;
            this.cbSoluong.Location = new System.Drawing.Point(359, 96);
            this.cbSoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSoluong.Name = "cbSoluong";
            this.cbSoluong.Size = new System.Drawing.Size(18, 17);
            this.cbSoluong.TabIndex = 18;
            this.cbSoluong.UseVisualStyleBackColor = true;
            // 
            // cbTensach
            // 
            this.cbTensach.AutoSize = true;
            this.cbTensach.Location = new System.Drawing.Point(359, 67);
            this.cbTensach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTensach.Name = "cbTensach";
            this.cbTensach.Size = new System.Drawing.Size(18, 17);
            this.cbTensach.TabIndex = 17;
            this.cbTensach.UseVisualStyleBackColor = true;
            // 
            // cbMasach
            // 
            this.cbMasach.AutoSize = true;
            this.cbMasach.Location = new System.Drawing.Point(359, 36);
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
            this.cbbNXB.Location = new System.Drawing.Point(128, 250);
            this.cbbNXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbNXB.Name = "cbbNXB";
            this.cbbNXB.Size = new System.Drawing.Size(198, 24);
            this.cbbNXB.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhà xuất bản";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(128, 218);
            this.txtGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(198, 22);
            this.txtGia.TabIndex = 15;
            // 
            // txtTheloai
            // 
            this.txtTheloai.Location = new System.Drawing.Point(128, 187);
            this.txtTheloai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTheloai.Name = "txtTheloai";
            this.txtTheloai.Size = new System.Drawing.Size(198, 22);
            this.txtTheloai.TabIndex = 14;
            // 
            // txtTacgia
            // 
            this.txtTacgia.Location = new System.Drawing.Point(128, 156);
            this.txtTacgia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTacgia.Name = "txtTacgia";
            this.txtTacgia.Size = new System.Drawing.Size(198, 22);
            this.txtTacgia.TabIndex = 13;
            // 
            // txtNamxuatban
            // 
            this.txtNamxuatban.Location = new System.Drawing.Point(128, 125);
            this.txtNamxuatban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNamxuatban.Name = "txtNamxuatban";
            this.txtNamxuatban.Size = new System.Drawing.Size(198, 22);
            this.txtNamxuatban.TabIndex = 12;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(128, 94);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(198, 22);
            this.txtSoluong.TabIndex = 11;
            // 
            // txtTensach
            // 
            this.txtTensach.Location = new System.Drawing.Point(128, 62);
            this.txtTensach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.Size = new System.Drawing.Size(198, 22);
            this.txtTensach.TabIndex = 10;
            // 
            // txtMasach
            // 
            this.txtMasach.Location = new System.Drawing.Point(128, 31);
            this.txtMasach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.Size = new System.Drawing.Size(198, 22);
            this.txtMasach.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Năm xuất bản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Thể loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tác giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 31);
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
            this.btnLammoi.Location = new System.Drawing.Point(611, 316);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(143, 29);
            this.btnLammoi.TabIndex = 21;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(909, 316);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 29);
            this.button6.TabIndex = 23;
            this.button6.Text = "Về trang chủ";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(760, 316);
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
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 362);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgdSach);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Sach";
            this.Text = "Quản lý sách";
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
        private TextBox txtGia;
        private TextBox txtTheloai;
        private TextBox txtTacgia;
        private TextBox txtNamxuatban;
        private TextBox txtSoluong;
        private TextBox txtTensach;
        private TextBox txtMasach;
        private Label label9;
        private DataGridView dgdSach;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLammoi;
        private Button button6;
        private Button btnLuu;
        private CheckBox cbMasach;
        private Button btnTimkiem;
        private CheckBox cbNXB;
        private CheckBox cbGia;
        private CheckBox cbTheLoai;
        private CheckBox cbTacgia;
        private CheckBox cbNamXB;
        private CheckBox cbSoluong;
        private CheckBox cbTensach;
    }
}