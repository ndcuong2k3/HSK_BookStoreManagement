using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSK_BookStoreManagement
{
    public partial class Vo : Form
    {
        DBHelper dbHelper = new DBHelper();
        public Vo()
        {
            InitializeComponent();
        }

        private void Vo_Load(object sender, EventArgs e)
        {
            string query = "Select * from vvVo";
            DataTable dataTable = new DataTable();
            dataTable = dbHelper.ExecuteQuery(query);
            dbHelper.FillDataGridView(dgdVo, dataTable);

            string cbquery = "SELECT sMaDV, sTenDV FROM tblDonViSanXuat";
            dbHelper.FillComboBox(cbbDVSX, cbquery, "sTenDV", "sMaDV");
        }

        private void dgdSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            var row = dgdVo.Rows[e.RowIndex];
            txtMaSP.Text = row.Cells["Mã vở"].Value?.ToString() ?? "";
            txtTenSP.Text = row.Cells["Tên vở"].Value?.ToString() ?? "";
            txtSoLuong.Text = row.Cells["Số lượng"].Value?.ToString() ?? "";
            txtGiaBan.Text = row.Cells["Giá bán"].Value?.ToString() ?? "";
            txtSoTrang.Text = row.Cells["Số trang"].Value?.ToString() ?? "";
            txtKieuDongKe.Text = row.Cells["Kiểu dòng kẻ"].Value?.ToString() ?? "";
            txtGiaNhap.Text = row.Cells["Giá nhập"].Value?.ToString() ?? "";
            cbbDVSX.Text = row.Cells["Đơn vị sản xuất"].Value?.ToString() ?? "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInputVo(out string error))
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
                new SqlParameter("@iSoTrang", Convert.ToInt32(txtSoTrang.Text)),
                new SqlParameter("@sKieuDongKe", txtKieuDongKe.Text),
                new SqlParameter("@sMaDV", cbbDVSX.SelectedValue),
            };

            // Gọi stored procedure để thêm vở
            dbHelper.ExecuteNonQuery("prThemVo", parameters, CommandType.StoredProcedure);

            MessageBox.Show("Thêm vở thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Vo_Load(sender, e);
        }

        private bool ValidateInputVo(out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                errorMessage = "Vui lòng nhập Mã vở.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                errorMessage = "Vui lòng nhập Tên vở.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoLuong.Text) || !int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong < 0)
            {
                errorMessage = "Số lượng phải là số nguyên không âm.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoTrang.Text) || !int.TryParse(txtSoTrang.Text, out int soTrang) || soTrang <= 0)
            {
                errorMessage = "Số trang phải là số nguyên dương.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtKieuDongKe.Text))
            {
                errorMessage = "Vui lòng nhập Kiểu dòng kẻ.";
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn mã vở cần sửa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputVo(out string error))
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
                new SqlParameter("@iSoTrang", Convert.ToInt32(txtSoTrang.Text)),
                new SqlParameter("@sKieuDongKe", txtKieuDongKe.Text),
                new SqlParameter("@sMaDV", cbbDVSX.SelectedValue)
            };

            dbHelper.ExecuteNonQuery("prSuaVo", parameters, CommandType.StoredProcedure);
            MessageBox.Show("Cập nhật vở thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Vo_Load(sender, e);
            ClearInput();
        }

        private void ClearInput()
        {
            txtGiaBan.Text = string.Empty;
            txtMaSP.Text = string.Empty;
            txtTenSP.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtSoTrang.Text = string.Empty;
            txtTenSP.Text = string.Empty;
            txtKieuDongKe.Text = string.Empty;
            txtGiaNhap.Text = string.Empty;
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
                dbHelper.ExecuteNonQuery("prXoaSach", parameters, CommandType.StoredProcedure);
                MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Vo_Load(sender, e);
                ClearInput();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM vvVo WHERE 1 = 1";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (cbMaSP.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtMaSP.Text))
                {
                    sql += " AND [Mã vở] = @MaVo";
                    parameters.Add(new SqlParameter("@MaVo", txtMaSP.Text));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã vở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (cbTenSP.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtTenSP.Text))
                {
                    sql += " AND [Tên vở] LIKE @TenVo";
                    parameters.Add(new SqlParameter("@TenVo", "%" + txtTenSP.Text + "%"));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên vở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (cbSoTrang.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtSoTrang.Text) && int.TryParse(txtSoTrang.Text, out int soTrang))
                {
                    sql += " AND [Số trang] = @SoTrang";
                    parameters.Add(new SqlParameter("@SoTrang", soTrang));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số trang là số hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (cbKieuDongKe.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtKieuDongKe.Text))
                {
                    sql += " AND [Kiểu dòng kẻ] LIKE @DongKe";
                    parameters.Add(new SqlParameter("@DongKe", "%" + txtKieuDongKe.Text + "%"));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập kiểu dòng kẻ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            dbHelper.FillDataGridView(dgdVo, dataTable);
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearInput();
            Vo_Load(sender, e);
            cbGiaBan.Checked = false;
            cbTenSP.Checked = false;
            cbMaSP.Checked = false;
            cbSoLuong.Checked = false;
            cbSoTrang.Checked = false;
            cbNhaSX.Checked = false;
            cbKieuDongKe.Checked = false;
            cbGiaNhap.Checked = false;
        }

        private void btnLuuVo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgdVo.Rows)
            {
                if (row.IsNewRow) continue;

                string maVo = row.Cells["Mã vở"].Value?.ToString() ?? "";
                string tenVo = row.Cells["Tên vở"].Value?.ToString() ?? "";
                string kieuDongKe = row.Cells["Kiểu dòng kẻ"].Value?.ToString() ?? "";
                string tenNSX = row.Cells["Đơn vị sản xuất"].Value?.ToString() ?? "";

                int.TryParse(row.Cells["Số lượng"].Value?.ToString(), out int soLuong);
                int.TryParse(row.Cells["Giá bán"].Value?.ToString(), out int giaBan);
                int.TryParse(row.Cells["Giá nhập"].Value?.ToString(), out int giaNhap);
                int.TryParse(row.Cells["Số trang"].Value?.ToString(), out int soTrang);

                if (string.IsNullOrEmpty(tenNSX))
                {
                    MessageBox.Show("Vui lòng nhập tên nhà sản xuất", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy mã NSX
                string sql = "SELECT sMaDV FROM tblDonViSanXuat WHERE sTenDV = @TenNSX";
                SqlParameter[] getMaDVParams = {
                    new SqlParameter("@TenNSX", tenNSX)
                };
                object result = dbHelper.ExecuteScalar(sql, getMaDVParams);
                if (result == null)
                {
                    MessageBox.Show($"Không tìm thấy nhà sản xuất: {tenNSX}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    continue;
                }
                string maDV = result.ToString();

                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@sMaSP", maVo),
                    new SqlParameter("@sTenSP", tenVo),
                    new SqlParameter("@iGiaNhap", giaNhap),
                    new SqlParameter("@iGiaBan", giaBan),
                    new SqlParameter("@iSL", soLuong),
                    new SqlParameter("@iSoTrang", soTrang),
                    new SqlParameter("@sKieuDongKe", kieuDongKe),
                    new SqlParameter("@sMaDV", maDV)
                };

                if (CheckIfNotebookExists(maVo))
                {
                    if (IsNotebookModified(maVo, tenVo, kieuDongKe, maDV, giaNhap, giaBan, soLuong, soTrang))
                    {
                        dbHelper.ExecuteNonQuery("prSuaVo", parameters, CommandType.StoredProcedure);
                    }
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(maVo) || string.IsNullOrWhiteSpace(tenVo))
                    {
                        MessageBox.Show("Thông tin mã vở hoặc tên vở không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    dbHelper.ExecuteNonQuery("prThemVo", parameters, CommandType.StoredProcedure);
                }
            }

            MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Vo_Load(sender,e); // Gọi lại dữ liệu sau khi lưu
        }


        private bool CheckIfNotebookExists(string maVo)
        {
            string sql = "SELECT COUNT(*) FROM tblVo WHERE sMaSP = @sMaSP";
            SqlParameter[] parameters = {
                new SqlParameter("@sMaSP", maVo)
            };
            object result = dbHelper.ExecuteScalar(sql, parameters);
            return Convert.ToInt32(result) > 0;
        }

        private bool IsNotebookModified(string maVo, string tenVo, string dongKe, string maDV, int giaNhap, int giaBan, int soLuong, int soTrang)
        {
            string query = @"
            SELECT sp.sTenSP, sp.iGiaNhap, sp.iGiaBan, sp.iSL,
                   v.iSoTrang, v.sKieuDongKe, v.sMaDV
            FROM tblSanPham sp
            JOIN tblVo v ON sp.sMaSP = v.sMaSP
            WHERE sp.sMaSP = @MaSP
            ";

            SqlParameter[] parameters = {
                new SqlParameter("@MaSP", maVo)
            };

            DataTable dt = dbHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count == 0) return false;

            DataRow row = dt.Rows[0];

            return
                row["sTenSP"].ToString() != tenVo ||
                row["sKieuDongKe"].ToString() != dongKe ||
                row["sMaDV"].ToString() != maDV ||
                Convert.ToInt32(row["iGiaNhap"]) != giaNhap ||
                Convert.ToInt32(row["iGiaBan"]) != giaBan ||
                Convert.ToInt32(row["iSL"]) != soLuong ||
                Convert.ToInt32(row["iSoTrang"]) != soTrang;
        }


    }
}
