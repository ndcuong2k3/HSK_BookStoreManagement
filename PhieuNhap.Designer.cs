namespace HSK_BookStoreManagement
{
    partial class PhieuNhap
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
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.cb_TenDVSX = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_ngayLap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_TenNV = new System.Windows.Forms.ComboBox();
            this.btn_XemCT = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dtgv_PhieuNhap = new System.Windows.Forms.DataGridView();
            this.cbGhiChu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_PhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(221, 159);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(198, 22);
            this.txt_TimKiem.TabIndex = 30;
            // 
            // cb_TenDVSX
            // 
            this.cb_TenDVSX.FormattingEnabled = true;
            this.cb_TenDVSX.Location = new System.Drawing.Point(159, 62);
            this.cb_TenDVSX.Name = "cb_TenDVSX";
            this.cb_TenDVSX.Size = new System.Drawing.Size(211, 24);
            this.cb_TenDVSX.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ngày lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ghi chú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên đơn vị sản xuất";
            // 
            // dtp_ngayLap
            // 
            this.dtp_ngayLap.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngayLap.Location = new System.Drawing.Point(542, 65);
            this.dtp_ngayLap.Name = "dtp_ngayLap";
            this.dtp_ngayLap.Size = new System.Drawing.Size(211, 22);
            this.dtp_ngayLap.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên nhân viên";
            // 
            // cb_TenNV
            // 
            this.cb_TenNV.FormattingEnabled = true;
            this.cb_TenNV.Location = new System.Drawing.Point(159, 19);
            this.cb_TenNV.Name = "cb_TenNV";
            this.cb_TenNV.Size = new System.Drawing.Size(211, 24);
            this.cb_TenNV.TabIndex = 22;
            // 
            // btn_XemCT
            // 
            this.btn_XemCT.Location = new System.Drawing.Point(596, 101);
            this.btn_XemCT.Name = "btn_XemCT";
            this.btn_XemCT.Size = new System.Drawing.Size(100, 29);
            this.btn_XemCT.TabIndex = 21;
            this.btn_XemCT.Text = "Xem chi tiết";
            this.btn_XemCT.UseVisualStyleBackColor = true;
            this.btn_XemCT.Click += new System.EventHandler(this.btn_XemCT_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(461, 158);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(100, 29);
            this.btn_TimKiem.TabIndex = 20;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(426, 101);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(100, 29);
            this.btn_Xoa.TabIndex = 19;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(242, 101);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(100, 29);
            this.btn_Sua.TabIndex = 18;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(64, 101);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(100, 29);
            this.btn_Them.TabIndex = 17;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dtgv_PhieuNhap
            // 
            this.dtgv_PhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_PhieuNhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgv_PhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_PhieuNhap.Location = new System.Drawing.Point(29, 203);
            this.dtgv_PhieuNhap.Name = "dtgv_PhieuNhap";
            this.dtgv_PhieuNhap.RowHeadersWidth = 51;
            this.dtgv_PhieuNhap.RowTemplate.Height = 24;
            this.dtgv_PhieuNhap.Size = new System.Drawing.Size(735, 235);
            this.dtgv_PhieuNhap.TabIndex = 16;
            this.dtgv_PhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_PhieuNhap_CellClick);
            // 
            // cbGhiChu
            // 
            this.cbGhiChu.Location = new System.Drawing.Point(542, 22);
            this.cbGhiChu.Name = "cbGhiChu";
            this.cbGhiChu.Size = new System.Drawing.Size(211, 22);
            this.cbGhiChu.TabIndex = 31;
            // 
            // PhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbGhiChu);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.cb_TenDVSX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_ngayLap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_TenNV);
            this.Controls.Add(this.btn_XemCT);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dtgv_PhieuNhap);
            this.Name = "PhieuNhap";
            this.Text = "PhieuNhap";
            this.Load += new System.EventHandler(this.PhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_PhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.ComboBox cb_TenDVSX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_ngayLap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_TenNV;
        private System.Windows.Forms.Button btn_XemCT;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dtgv_PhieuNhap;
        private System.Windows.Forms.TextBox cbGhiChu;
    }
}