namespace HSK_BookStoreManagement
{
    partial class HoaDon
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
            this.dtgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_XemCT = new System.Windows.Forms.Button();
            this.cb_maNV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_ngayLap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_maKH = new System.Windows.Forms.ComboBox();
            this.cb_trangThai = new System.Windows.Forms.ComboBox();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_HoaDon
            // 
            this.dtgv_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_HoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_HoaDon.Location = new System.Drawing.Point(72, 256);
            this.dtgv_HoaDon.Name = "dtgv_HoaDon";
            this.dtgv_HoaDon.RowHeadersWidth = 51;
            this.dtgv_HoaDon.RowTemplate.Height = 24;
            this.dtgv_HoaDon.Size = new System.Drawing.Size(813, 194);
            this.dtgv_HoaDon.TabIndex = 1;
            this.dtgv_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_HoaDon_CellClick);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(72, 132);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 2;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(250, 132);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(434, 132);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(72, 175);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 5;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_XemCT
            // 
            this.btn_XemCT.Location = new System.Drawing.Point(604, 132);
            this.btn_XemCT.Name = "btn_XemCT";
            this.btn_XemCT.Size = new System.Drawing.Size(113, 23);
            this.btn_XemCT.TabIndex = 6;
            this.btn_XemCT.Text = "Xem chi tiết";
            this.btn_XemCT.UseVisualStyleBackColor = true;
            this.btn_XemCT.Click += new System.EventHandler(this.btn_XemCT_Click);
            // 
            // cb_maNV
            // 
            this.cb_maNV.FormattingEnabled = true;
            this.cb_maNV.Location = new System.Drawing.Point(204, 27);
            this.cb_maNV.Name = "cb_maNV";
            this.cb_maNV.Size = new System.Drawing.Size(121, 24);
            this.cb_maNV.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên nhân viên";
            // 
            // dtp_ngayLap
            // 
            this.dtp_ngayLap.Location = new System.Drawing.Point(556, 73);
            this.dtp_ngayLap.Name = "dtp_ngayLap";
            this.dtp_ngayLap.Size = new System.Drawing.Size(161, 22);
            this.dtp_ngayLap.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ngày lập";
            // 
            // cb_maKH
            // 
            this.cb_maKH.FormattingEnabled = true;
            this.cb_maKH.Location = new System.Drawing.Point(204, 70);
            this.cb_maKH.Name = "cb_maKH";
            this.cb_maKH.Size = new System.Drawing.Size(121, 24);
            this.cb_maKH.TabIndex = 13;
            // 
            // cb_trangThai
            // 
            this.cb_trangThai.FormattingEnabled = true;
            this.cb_trangThai.Location = new System.Drawing.Point(556, 27);
            this.cb_trangThai.Name = "cb_trangThai";
            this.cb_trangThai.Size = new System.Drawing.Size(161, 24);
            this.cb_trangThai.TabIndex = 14;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(204, 175);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(198, 22);
            this.txt_TimKiem.TabIndex = 15;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 507);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.cb_trangThai);
            this.Controls.Add(this.cb_maKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_ngayLap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_maNV);
            this.Controls.Add(this.btn_XemCT);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dtgv_HoaDon);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgv_HoaDon;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_XemCT;
        private System.Windows.Forms.ComboBox cb_maNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_ngayLap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_maKH;
        private System.Windows.Forms.ComboBox cb_trangThai;
        private System.Windows.Forms.TextBox txt_TimKiem;
    }
}