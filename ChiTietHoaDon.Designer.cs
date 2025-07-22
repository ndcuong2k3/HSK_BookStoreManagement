namespace HSK_BookStoreManagement
{
    partial class ChiTietHoaDon
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
            this.dtgv_ChiTietHD = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.cb_MaSP = new System.Windows.Forms.ComboBox();
            this.lbl_TongHoaDon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ChiTietHD)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_ChiTietHD
            // 
            this.dtgv_ChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ChiTietHD.Location = new System.Drawing.Point(31, 153);
            this.dtgv_ChiTietHD.Name = "dtgv_ChiTietHD";
            this.dtgv_ChiTietHD.RowHeadersWidth = 51;
            this.dtgv_ChiTietHD.RowTemplate.Height = 24;
            this.dtgv_ChiTietHD.Size = new System.Drawing.Size(601, 212);
            this.dtgv_ChiTietHD.TabIndex = 0;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(59, 104);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(93, 30);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(274, 104);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(93, 30);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(506, 104);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(93, 30);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số lượng";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(478, 44);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(121, 22);
            this.txt_SoLuong.TabIndex = 7;
            // 
            // cb_MaSP
            // 
            this.cb_MaSP.FormattingEnabled = true;
            this.cb_MaSP.Location = new System.Drawing.Point(160, 41);
            this.cb_MaSP.Name = "cb_MaSP";
            this.cb_MaSP.Size = new System.Drawing.Size(121, 24);
            this.cb_MaSP.TabIndex = 8;
            // 
            // lbl_TongHoaDon
            // 
            this.lbl_TongHoaDon.AutoSize = true;
            this.lbl_TongHoaDon.Location = new System.Drawing.Point(374, 389);
            this.lbl_TongHoaDon.Name = "lbl_TongHoaDon";
            this.lbl_TongHoaDon.Size = new System.Drawing.Size(97, 16);
            this.lbl_TongHoaDon.TabIndex = 9;
            this.lbl_TongHoaDon.Text = "Tổng hóa đơn: ";
            // 
            // ChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 458);
            this.Controls.Add(this.lbl_TongHoaDon);
            this.Controls.Add(this.cb_MaSP);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dtgv_ChiTietHD);
            this.Name = "ChiTietHoaDon";
            this.Text = "ChiTietHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ChiTietHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_ChiTietHD;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.ComboBox cb_MaSP;
        private System.Windows.Forms.Label lbl_TongHoaDon;
    }
}