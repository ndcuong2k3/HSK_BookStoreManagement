using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HSK_BookStoreManagement
{
    public partial class But : Form
    {
        DBHelper dbHelper = new DBHelper();
        public But()
        {
            InitializeComponent();
        }

        private void But_Load(object sender, EventArgs e)
        {
            string sql = "Select * from vvBut";
            DataTable dt =  dbHelper.ExecuteQuery(sql);
            dbHelper.FillDataGridView(dgdBut, dt);

            string cbquery = "SELECT sMaDV, sTenDV FROM tblDonViSanXuat";
            dbHelper.FillComboBox(cbbDVSX, cbquery, "sTenDV", "sMaDV");

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInputBut(out string error))
            {
                MessageBox.Show(error, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sinh mã sản phẩm tự động
            string sql = @"
                SELECT ISNULL(MAX(CAST(SUBSTRING(sMaSP, 3, LEN(sMaSP) - 2) AS INT)), 0)
                FROM tblSanPham";

            int maxSo = Convert.ToInt32(dbHelper.ExecuteScalar(sql));
            int soMoi = maxSo + 1;
            string maSP = "SP" + soMoi.ToString("D3");

            // Tạo danh sách tham số
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@sMaSP", maSP),
                new SqlParameter("@sTenSP", txtTenSP.Text),
                new SqlParameter("@iGiaNhap", Convert.ToInt32(txtGiaNhap.Text)),
                new SqlParameter("@iGiaBan", Convert.ToInt32(txtGiaBan.Text)),
                new SqlParameter("@iSL", Convert.ToInt32(txtSoLuong.Text)),
                new SqlParameter("@sLoaiBut", txtLoaiBut.Text),
                new SqlParameter("@sMauBut", txtMauBut.Text),
                new SqlParameter("@sMaDV", cbbDVSX.SelectedValue),
            };

            // Gọi stored procedure để thêm bút
            dbHelper.ExecuteNonQuery("prThemBut", parameters, CommandType.StoredProcedure);

            MessageBox.Show("Thêm bút thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            But_Load(sender, e);
        }

        private bool ValidateInputBut(out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                errorMessage = "Vui lòng nhập Mã bút.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                errorMessage = "Vui lòng nhập Tên bút.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLoaiBut.Text))
            {
                errorMessage = "Vui lòng nhập Loại bút.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMauBut.Text))
            {
                errorMessage = "Vui lòng nhập Màu mực.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoLuong.Text) || !int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong < 0)
            {
                errorMessage = "Số lượng phải là số nguyên không âm.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGiaNhap.Text) || !int.TryParse(txtGiaNhap.Text, out int giaNhap) || giaNhap < 0)
            {
                errorMessage = "Giá nhập phải là số nguyên dương.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGiaBan.Text) || !int.TryParse(txtGiaBan.Text, out int giaBan) || giaBan < 0)
            {
                errorMessage = "Giá bán phải là số nguyên dương.";
                return false;
            }

            if (giaBan < giaNhap)
            {
                errorMessage = "Giá bán không được nhỏ hơn Giá nhập.";
                return false;
            }

            if (cbbDVSX.SelectedIndex == -1 || cbbDVSX.SelectedValue == null)
            {
                errorMessage = "Vui lòng chọn Nhà sản xuất.";
                return false;
            }

            return true;
        }

        private void dgdBut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            var row = dgdBut.Rows[e.RowIndex];
            txtMaSP.Text = row.Cells["Mã bút"].Value?.ToString() ?? "";
            txtTenSP.Text = row.Cells["Tên bút"].Value?.ToString() ?? "";
            txtSoLuong.Text = row.Cells["Số lượng"].Value?.ToString() ?? "";
            txtGiaBan.Text = row.Cells["Giá bán"].Value?.ToString() ?? "";
            txtLoaiBut.Text = row.Cells["Loại bút"].Value?.ToString() ?? "";
            txtMauBut.Text = row.Cells["Màu bút"].Value?.ToString() ?? "";
            txtGiaNhap.Text = row.Cells["Giá nhập"].Value?.ToString() ?? "";
            cbbDVSX.Text = row.Cells["Đơn vị sản xuất"].Value?.ToString() ?? "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn mã bút cần sửa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputBut(out string error))
            {
                MessageBox.Show(error, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var parameters = new SqlParameter[]
           {
                new SqlParameter("@sMaSP", txtMaSP.Text),
                new SqlParameter("@sTenSP", txtTenSP.Text),
                new SqlParameter("@iGiaNhap", Convert.ToInt32(txtGiaNhap.Text)),
                new SqlParameter("@iGiaBan", Convert.ToInt32(txtGiaBan.Text)),
                new SqlParameter("@iSL", Convert.ToInt32(txtSoLuong.Text)),
                new SqlParameter("@sLoaiBut", txtLoaiBut.Text),
                new SqlParameter("@sMauBut", txtMauBut.Text),
                new SqlParameter("@sMaDV", cbbDVSX.SelectedValue),
           };

            // Gọi stored procedure để sửa bút
            dbHelper.ExecuteNonQuery("prSuaBut", parameters, CommandType.StoredProcedure);

            MessageBox.Show("Sửa thông tin bút thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            But_Load(sender, e);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@sMaSP",txtMaSP.Text)
                };
                dbHelper.ExecuteNonQuery("prXoaBut", parameters, CommandType.StoredProcedure);
                MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                But_Load(sender, e);
                ClearInput();
            }
        }

        private void ClearInput()
        {
            txtGiaBan.Text = string.Empty;
            txtMaSP.Text = string.Empty;
            txtTenSP.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtLoaiBut.Text = string.Empty;
            txtTenSP.Text = string.Empty;
            txtMauBut.Text = string.Empty;
            txtGiaNhap.Text = string.Empty;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM vvBut WHERE 1 = 1";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (cbMaSP.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtMaSP.Text))
                {
                    sql += " AND [Mã bút] = @MaBut";
                    parameters.Add(new SqlParameter("@MaBut", txtMaSP.Text));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã bút", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (cbTenSP.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtTenSP.Text))
                {
                    sql += " AND [Tên bút] LIKE @TenBut";
                    parameters.Add(new SqlParameter("@TenBut", "%" + txtTenSP.Text + "%"));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên bút", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (cbMauBut.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtMauBut.Text))
                {
                    sql += " AND [Màu bút] LIKE @MauBut";
                    parameters.Add(new SqlParameter("@MauBut", "%" + txtMauBut.Text + "%"));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập màu bút", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (cbLoaiBut.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtLoaiBut.Text))
                {
                    sql += " AND [Loại bút] LIKE @LoaiBut";
                    parameters.Add(new SqlParameter("@LoaiBut", "%" + txtLoaiBut.Text + "%"));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập kiểu loại bút", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (cbGiaNhap.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtGiaNhap.Text) && int.TryParse(txtGiaNhap.Text, out int giaNhap))
                {
                    sql += " AND [Giá nhập] = @GiaNhap";
                    parameters.Add(new SqlParameter("@GiaNhap", giaNhap));
                }
                else
                {
                    MessageBox.Show("Giá nhập phải là số hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (cbGiaBan.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtGiaBan.Text) && int.TryParse(txtGiaBan.Text, out int giaBan))
                {
                    sql += " AND [Giá bán] = @GiaBan";
                    parameters.Add(new SqlParameter("@GiaBan", giaBan));
                }
                else
                {
                    MessageBox.Show("Giá bán phải là số hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (cbSoLuong.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtSoLuong.Text) && int.TryParse(txtSoLuong.Text, out int soLuong))
                {
                    sql += " AND [Số lượng] = @SoLuong";
                    parameters.Add(new SqlParameter("@SoLuong", soLuong));
                }
                else
                {
                    MessageBox.Show("Số lượng phải là số hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (cbNhaSX.Checked)
            {
                if (cbbDVSX.SelectedIndex != -1)
                {
                    sql += " AND [Đơn vị sản xuất] = @NhaSX";
                    parameters.Add(new SqlParameter("@NhaSX", cbbDVSX.Text));
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn nhà sản xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Lấy dữ liệu và đổ vào DataGridView
            DataTable dataTable = dbHelper.ExecuteQuery(sql, parameters.ToArray());
            dbHelper.FillDataGridView(dgdBut, dataTable);
        
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearInput();
            But_Load(sender, e);
            cbGiaBan.Checked = false;
            cbTenSP.Checked = false;
            cbMaSP.Checked = false;
            cbSoLuong.Checked = false;
            cbLoaiBut.Checked = false;
            cbNhaSX.Checked = false;
            cbMauBut.Checked = false;
            cbGiaNhap.Checked = false;
        }

        private bool CheckIfPenExists(string maBut)
        {
            string sql = "SELECT COUNT(*) FROM tblBut WHERE sMaSP = @sMaSP";
            SqlParameter[] parameters = {
                new SqlParameter("@sMaSP", maBut)
            };
            object result = dbHelper.ExecuteScalar(sql, parameters);
            return Convert.ToInt32(result) > 0;
        }

        private bool IsPenModified(string maBut, string tenBut, string loaiBut, string maDV, int giaNhap, int giaBan, int soLuong, string mauBut)
        {
            string query = @"
            SELECT sp.sTenSP, sp.iGiaNhap, sp.iGiaBan, sp.iSL,
                   b.sMauBut, b.sLoaiBut, b.sMaDV
            FROM tblSanPham sp
            JOIN tblBut b ON sp.sMaSP = b.sMaSP
            WHERE sp.sMaSP = @MaSP
            ";

            SqlParameter[] parameters = {
                new SqlParameter("@MaSP", maBut)
            };

            DataTable dt = dbHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count == 0) return false;

            DataRow row = dt.Rows[0];

            return
                row["sTenSP"].ToString() != tenBut ||
                row["sLoaiBut"].ToString() != loaiBut ||
                row["sMaDV"].ToString() != maDV ||
                Convert.ToInt32(row["iGiaNhap"]) != giaNhap ||
                Convert.ToInt32(row["iGiaBan"]) != giaBan ||
                Convert.ToInt32(row["iSL"]) != soLuong ||
                row["sMauBut"].ToString() != mauBut;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool hasError = false;

            foreach (DataGridViewRow row in dgdBut.Rows)
            {
                if (row.IsNewRow) continue;

                string maBut = row.Cells["Mã bút"].Value?.ToString() ?? "";
                string tenBut = row.Cells["Tên bút"].Value?.ToString() ?? "";
                string loaiBut = row.Cells["Loại bút"].Value?.ToString() ?? "";
                string tenNSX = row.Cells["Đơn vị sản xuất"].Value?.ToString() ?? "";
                string mauBut = row.Cells["Màu bút"].Value?.ToString() ?? "";

                int.TryParse(row.Cells["Số lượng"].Value?.ToString(), out int soLuong);
                int.TryParse(row.Cells["Giá bán"].Value?.ToString(), out int giaBan);
                int.TryParse(row.Cells["Giá nhập"].Value?.ToString(), out int giaNhap);

                if (string.IsNullOrEmpty(tenNSX))
                {
                    MessageBox.Show("Vui lòng nhập tên nhà sản xuất", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    hasError = true;
                    continue;
                }

                string sql = "SELECT sMaDV FROM tblDonViSanXuat WHERE sTenDV = @TenNSX";
                SqlParameter[] getMaDVParams = {
                     new SqlParameter("@TenNSX", tenNSX)
                };
                object result = dbHelper.ExecuteScalar(sql, getMaDVParams);
                if (result == null)
                {
                    MessageBox.Show($"Không tìm thấy nhà sản xuất: {tenNSX}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hasError = true;
                    continue;
                }
                string maDV = result.ToString();

                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@sMaSP", maBut),
                    new SqlParameter("@sTenSP", tenBut),
                    new SqlParameter("@iGiaNhap", giaNhap),
                    new SqlParameter("@iGiaBan", giaBan),
                    new SqlParameter("@iSL", soLuong),
                    new SqlParameter("@sMauBut", mauBut),
                    new SqlParameter("@sLoaiBut", loaiBut),
                    new SqlParameter("@sMaDV", maDV)
                };

                if (CheckIfPenExists(maBut))
                {
                    if (IsPenModified(maBut, tenBut, loaiBut, maDV, giaNhap, giaBan, soLuong, mauBut))
                    {
                        dbHelper.ExecuteNonQuery("prSuaBut", parameters, CommandType.StoredProcedure);
                    }
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(maBut) || string.IsNullOrWhiteSpace(tenBut))
                    {
                        MessageBox.Show("Thông tin mã bút hoặc tên bút không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        hasError = true;
                        continue;
                    }

                    dbHelper.ExecuteNonQuery("prThemBut", parameters, CommandType.StoredProcedure);
                }
            }

            if (!hasError)
            {
                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu hoàn tất. Một số dòng có lỗi và đã bị bỏ qua.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            But_Load(sender, e);
        }

    }
}
