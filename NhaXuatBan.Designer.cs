using System.Drawing;
using System.Windows.Forms;

namespace HSK_BookStoreManagement
{
    partial class NhaXuatBan
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
            txt_tenNXB = new TextBox();
            txt_SDT = new TextBox();
            txt_diaChi = new TextBox();
            btn_Them = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            btn_timKiem = new Button();
            dtgv_NXB = new DataGridView();
            txt_TimKiem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgv_NXB).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 52);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên NXB";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(547, 52);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(302, 52);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // txt_tenNXB
            // 
            txt_tenNXB.Location = new Point(108, 49);
            txt_tenNXB.Name = "txt_tenNXB";
            txt_tenNXB.Size = new Size(125, 27);
            txt_tenNXB.TabIndex = 3;
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new Point(650, 49);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(125, 27);
            txt_SDT.TabIndex = 4;
            // 
            // txt_diaChi
            // 
            txt_diaChi.Location = new Point(363, 49);
            txt_diaChi.Name = "txt_diaChi";
            txt_diaChi.Size = new Size(125, 27);
            txt_diaChi.TabIndex = 5;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(108, 98);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(94, 29);
            btn_Them.TabIndex = 6;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(274, 98);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(94, 29);
            btn_Sua.TabIndex = 7;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(453, 98);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(94, 29);
            btn_Xoa.TabIndex = 8;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_timKiem
            // 
            btn_timKiem.Location = new Point(108, 143);
            btn_timKiem.Name = "btn_timKiem";
            btn_timKiem.Size = new Size(94, 29);
            btn_timKiem.TabIndex = 9;
            btn_timKiem.Text = "Tìm kiếm";
            btn_timKiem.UseVisualStyleBackColor = true;
            btn_timKiem.Click += btn_timKiem_Click;
            // 
            // dtgv_NXB
            // 
            dtgv_NXB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_NXB.Location = new Point(108, 192);
            dtgv_NXB.Name = "dtgv_NXB";
            dtgv_NXB.RowHeadersWidth = 51;
            dtgv_NXB.Size = new Size(667, 188);
            dtgv_NXB.TabIndex = 10;
            dtgv_NXB.CellClick += dtgv_NXB_CellClick;
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(274, 143);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new Size(220, 27);
            txt_TimKiem.TabIndex = 11;
            // 
            // NhaXuatBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_TimKiem);
            Controls.Add(dtgv_NXB);
            Controls.Add(btn_timKiem);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Them);
            Controls.Add(txt_diaChi);
            Controls.Add(txt_SDT);
            Controls.Add(txt_tenNXB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NhaXuatBan";
            Text = "NhaXuatBan";
            Load += NhaXuatBan_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv_NXB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_tenNXB;
        private TextBox txt_SDT;
        private TextBox txt_diaChi;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Xoa;
        private Button btn_timKiem;
        private DataGridView dtgv_NXB;
        private TextBox txt_TimKiem;
    }
}