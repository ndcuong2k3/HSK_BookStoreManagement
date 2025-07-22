using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HSK_BookStoreManagement
{
    public partial class DonViSanXuat : Form
    {
        DBHelper dBHelper = new DBHelper();

        public DonViSanXuat()
        {
            InitializeComponent();
        }

        private void DonViSanXuat_Load(object sender, EventArgs e)
        {
            DataTable dataTable = dBHelper.ExecuteQuery("SELECT * FROM vw_ThongTinDonViSanXuat");
            dtgv_DVSX.DataSource = dataTable;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string TenNXB = TenDVSX.Text.Trim();
            string diaChi = DiaChi.Text.Trim();
            string SDT = SoDienThoai.Text.Trim();

            if (string.IsNullOrEmpty(TenNXB) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(SDT))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(SDT, @"^0\d{9,10}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Phải bắt đầu bằng 0 và có 10-11 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra trùng tên đơn vị
            string checkSql = "SELECT COUNT(*) FROM tblDonViSanXuat WHERE sTenDV = @sTenDV";
            SqlParameter checkParam = new SqlParameter("@sTenDV", TenNXB);
            int count = Convert.ToInt32(dBHelper.ExecuteScalar(checkSql, new SqlParameter[] { checkParam }));
            if (count > 0)
            {
                MessageBox.Show("Tên đơn vị đã tồn tại. Vui lòng chọn tên khác.", "Trùng tên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = @"SELECT ISNULL(MAX(CAST(SUBSTRING(sMaDV, 3, LEN(sMaDV) - 2) AS INT)), 0) FROM tblDonViSanXuat";
            int maxSo = Convert.ToInt32(dBHelper.ExecuteScalar(sql));
            string maDVSX = "DV" + (maxSo + 1).ToString("D3");

            SqlParameter[] parameters = {
                new SqlParameter("@sMaDV", maDVSX),
                new SqlParameter("@sTenDV", TenNXB),
                new SqlParameter("@sDiachi", diaChi),
                new SqlParameter("@sSDT", SDT)
            };

            try
            {
                dBHelper.ExecuteNonQuery("sp_ThemDonViSanXuat", parameters, CommandType.StoredProcedure);
                MessageBox.Show("Thêm đơn vị sản xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DonViSanXuat_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MaDVSX.Text) || string.IsNullOrEmpty(TenDVSX.Text) || string.IsNullOrEmpty(DiaChi.Text) || string.IsNullOrEmpty(SoDienThoai.Text))
            {
                MessageBox.Show("Vui lòng chọn đơn vị để sửa và nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(SoDienThoai.Text, @"^0\d{9,10}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlParameter[] parameters = {
                new SqlParameter("@sMaDV", MaDVSX.Text),
                new SqlParameter("@sTenDV", TenDVSX.Text),
                new SqlParameter("@sDiachi", DiaChi.Text),
                new SqlParameter("@sSDT", SoDienThoai.Text)
            };

            try
            {
                dBHelper.ExecuteNonQuery("sp_SuaDonViSanXuat", parameters, CommandType.StoredProcedure);
                MessageBox.Show("Cập nhật đơn vị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DonViSanXuat_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MaDVSX.Text))
            {
                MessageBox.Show("Vui lòng chọn đơn vị để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa Đơn vị này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@sMaDV", MaDVSX.Text)
                };

                try
                {
                    dBHelper.ExecuteNonQuery("sp_XoaDonViSanXuat", parameters, CommandType.StoredProcedure);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DonViSanXuat_Load(sender, e);
                    btnLuu_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtgv_DVSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_DVSX.Rows[e.RowIndex];
                MaDVSX.Text = row.Cells["Mã đơn vị"].Value.ToString();
                TenDVSX.Text = row.Cells["Tên đơn vị"].Value.ToString();
                DiaChi.Text = row.Cells["Địa chỉ"].Value.ToString();
                SoDienThoai.Text = row.Cells["Số điện thoại"].Value.ToString();
            }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM vw_ThongTinDonViSanXuat WHERE 1 = 1";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (cbMaDVSX.Checked)
            {
                if (!string.IsNullOrWhiteSpace(MaDVSX.Text))
                {
                    sql += " AND [Mã đơn vị] = @Madv";
                    parameters.Add(new SqlParameter("@Madv", MaDVSX.Text));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã đơn vị sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (cbTenDVSX.Checked)
            {
                if (!string.IsNullOrWhiteSpace(TenDVSX.Text))
                {
                    sql += " AND [Tên đơn vị] LIKE @TenDV";
                    parameters.Add(new SqlParameter("@TenDV", "%" + TenDVSX.Text + "%"));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên đơn vị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (cbDiaChi.Checked)
            {
                if (!string.IsNullOrWhiteSpace(DiaChi.Text))
                {
                    sql += " AND [Địa chỉ] LIKE @Diachi";
                    parameters.Add(new SqlParameter("@Diachi", "%" + DiaChi.Text + "%"));
                }
                else
                {

                    MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (cbSDT.Checked)
            {
                if (!string.IsNullOrWhiteSpace(SoDienThoai.Text))
                {
                    sql += " AND [Số điện thoại] LIKE @SDT";
                    parameters.Add(new SqlParameter("@SDT", "%" + SoDienThoai.Text + "%"));
                }
                else
                {

                    MessageBox.Show("Vui lòng nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            DataTable dt = dBHelper.ExecuteQuery(sql, parameters.ToArray());
            dBHelper.FillDataGridView(dtgv_DVSX, dt);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MaDVSX.Text = string.Empty;
            TenDVSX.Text = string.Empty;
            DiaChi.Text = string.Empty;
            SoDienThoai.Text = string.Empty;
            cbDiaChi.Checked = false;
            cbMaDVSX.Checked = false;
            cbSDT.Checked = false;
            cbTenDVSX.Checked = false;

            DonViSanXuat_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgv_DVSX.Rows)
            {
                if (row.IsNewRow) continue;

                string maDV = row.Cells["Mã đơn vị"].Value?.ToString()?.Trim() ?? "";
                string tenDV = row.Cells["Tên đơn vị"].Value?.ToString()?.Trim() ?? "";
                string diaChi = row.Cells["Địa chỉ"].Value?.ToString()?.Trim() ?? "";
                string sdt = row.Cells["Số điện thoại"].Value?.ToString()?.Trim() ?? "";

                // Kiểm tra dữ liệu trống
                if (string.IsNullOrWhiteSpace(tenDV) || string.IsNullOrWhiteSpace(diaChi) || string.IsNullOrWhiteSpace(sdt))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin cho mỗi dòng.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra định dạng số điện thoại
                if (!System.Text.RegularExpressions.Regex.IsMatch(sdt, @"^0\d{9,10}$"))
                {
                    MessageBox.Show($"Số điện thoại không hợp lệ ở dòng có mã: {maDV}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra trùng tên đơn vị
                string checkNameSql = "SELECT COUNT(*) FROM tblDonViSanXuat WHERE sTenDV = @tenDV AND sMaDV <> @maDV";
                SqlParameter[] checkParams = {
            new SqlParameter("@tenDV", tenDV),
            new SqlParameter("@maDV", string.IsNullOrEmpty(maDV) ? "" : maDV)
        };
                int sameNameCount = Convert.ToInt32(dBHelper.ExecuteScalar(checkNameSql, checkParams));
                if (sameNameCount > 0)
                {
                    MessageBox.Show($"Tên đơn vị \"{tenDV}\" đã tồn tại!", "Trùng tên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Nếu dòng là dòng mới (chưa có mã) → Thêm
                if (string.IsNullOrEmpty(maDV))
                {
                    string getMaxSql = "SELECT ISNULL(MAX(CAST(SUBSTRING(sMaDV, 3, LEN(sMaDV) - 2) AS INT)), 0) FROM tblDonViSanXuat";
                    int maxSo = Convert.ToInt32(dBHelper.ExecuteScalar(getMaxSql));
                    maDV = "DV" + (maxSo + 1).ToString("D3");

                    SqlParameter[] insertParams = {
                new SqlParameter("@sMaDV", maDV),
                new SqlParameter("@sTenDV", tenDV),
                new SqlParameter("@sDiachi", diaChi),
                new SqlParameter("@sSDT", sdt)
            };

                    dBHelper.ExecuteNonQuery("sp_ThemDonViSanXuat", insertParams, CommandType.StoredProcedure);
                }
                else
                {
                    // Nếu có mã rồi → Cập nhật
                    SqlParameter[] updateParams = {
                new SqlParameter("@sMaDV", maDV),
                new SqlParameter("@sTenDV", tenDV),
                new SqlParameter("@sDiachi", diaChi),
                new SqlParameter("@sSDT", sdt)
            };

                    dBHelper.ExecuteNonQuery("sp_SuaDonViSanXuat", updateParams, CommandType.StoredProcedure);
                }
            }

            MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DonViSanXuat_Load(sender, e); // Load lại dữ liệu mới

        }
    }
}
