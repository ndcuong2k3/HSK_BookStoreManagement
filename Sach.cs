using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HSK_BookStoreManagement
{
    public partial class Sach : Form
    {
        DBHelper dBHelper = new DBHelper();
        public Sach()
        {
            InitializeComponent();
            LoadData();

        }

        public void LoadData()
        {
            string query = "Select * from vvSach";
            DataTable dataTable = new DataTable();
            dataTable = dBHelper.ExecuteQuery(query);
            dBHelper.FillDataGridView(dgdSach, dataTable);

            string cbquery = "SELECT sMaNXB, sTenNXB FROM tblNXB";
            dBHelper.FillComboBox(cbbNXB, cbquery, "sTenNXB", "sMaNXB");
        }

        private void dgdSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            var row = dgdSach.Rows[e.RowIndex];
            txtMasach.Text = row.Cells["Mã sách"].Value?.ToString() ?? "";
            txtTensach.Text = row.Cells["Tên sách"].Value?.ToString() ?? "";
            txtTheloai.Text = row.Cells["Thể loại"].Value?.ToString() ?? "";
            txtSoluong.Text = row.Cells["Số lượng"].Value?.ToString() ?? "";
            txtGia.Text = row.Cells["Giá"].Value?.ToString() ?? "";
            txtNamxuatban.Text = row.Cells["Năm xuất bản"].Value?.ToString() ?? "";
            txtTacgia.Text = row.Cells["Tác giả"].Value?.ToString() ?? "";
            cbbNXB.Text = row.Cells["Nhà xuất bản"].Value?.ToString() ?? "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out string error))
            {
                MessageBox.Show(error, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = "Select sMasach from tblSach where sMasach = @MaSach";
            var parameter = new SqlParameter[]
            {
                    new SqlParameter("@MaSach",txtMasach.Text )
            };
            var ob = dBHelper.ExecuteScalar(sql, parameter);
            if (ob != null)
            {
                MessageBox.Show("Đã tồn tại sách có mã vừa nhập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@sMasach",txtMasach.Text),
                new SqlParameter("@sTensach",txtTensach.Text),
                new SqlParameter("@sMaNXB",cbbNXB.SelectedValue),
                new SqlParameter("@sTacgia",txtTacgia.Text),
                new SqlParameter("@sTheloai",txtTheloai.Text),
                new SqlParameter("@iGia",Convert.ToInt32(txtGia.Text)),
                new SqlParameter("@iSL",Convert.ToInt32(txtSoluong.Text)),
                new SqlParameter("@iNamXB",Convert.ToInt32(txtNamxuatban.Text)),
            };
            dBHelper.ExecuteNonQuery("ThemSach", parameters, CommandType.StoredProcedure);
            MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@sMasach",txtMasach.Text),
                new SqlParameter("@sTensach",txtTensach.Text),
                new SqlParameter("@sMaNXB",cbbNXB.SelectedValue),
                new SqlParameter("@sTacgia",txtTacgia.Text),
                new SqlParameter("@sTheloai",txtTheloai.Text),
                new SqlParameter("@iGia",Convert.ToInt32(txtGia.Text)),
                new SqlParameter("@iSL",Convert.ToInt32(txtSoluong.Text)),
                new SqlParameter("@iNamXB",Convert.ToInt32(txtNamxuatban.Text)),
            };
            dBHelper.ExecuteNonQuery("SuaSach", parameters, CommandType.StoredProcedure);
            MessageBox.Show("Cập nhật sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            ClearInput();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@sMasach",txtMasach.Text)
                };
                dBHelper.ExecuteNonQuery("XoaSach", parameters, CommandType.StoredProcedure);
                MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInput();
            }

        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearInput();
            LoadData();
            cbGia.Checked = false;
            cbMasach.Checked = false;
            cbNamXB.Checked = false;
            cbNXB.Checked = false;
            cbSoluong.Checked = false;
            cbTacgia.Checked = false;
            cbTensach.Checked = false;
            cbNXB.Checked = false;
            cbTheLoai.Checked = false;
        }

        private void ClearInput()
        {
            txtGia.Text = string.Empty;
            txtMasach.Text = string.Empty;
            txtNamxuatban.Text = string.Empty;
            txtSoluong.Text = string.Empty;
            txtTacgia.Text = string.Empty;
            txtTensach.Text = string.Empty;
            txtTheloai.Text = string.Empty;
        }

        //private void dgdSach_RowValidated(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dgdSach.Rows[e.RowIndex].IsNewRow) return;

        //    DataGridViewRow row = dgdSach.Rows[e.RowIndex];
        //    string masach = row.Cells["Mã sách"].Value?.ToString() ?? "";
        //    string tensach = row.Cells["Tên sách"].Value?.ToString() ?? "";
        //    string theloai = row.Cells["Thể loại"].Value?.ToString() ?? "";
        //    int soluong = Convert.ToInt32(row.Cells["Số lượng"].Value?.ToString() ?? "");
        //    int gia = Convert.ToInt32(row.Cells["Giá"].Value?.ToString() ?? "");
        //    int namxb = Convert.ToInt32(row.Cells["Năm xuất bản"].Value?.ToString() ?? "");
        //    string tacgia = row.Cells["Tác giả"].Value?.ToString() ?? "";
        //    string tenNXB = row.Cells["Nhà xuất bản"].Value?.ToString() ?? "";

        //    string sql = "SELECT sMaNXB FROM tblNXB WHERE sTenNXB = @TenNXB";
        //    SqlParameter[] parameters = {
        //        new SqlParameter("@TenNXB", tenNXB)
        //    };

        //    object result = dBHelper.ExecuteScalar(sql, parameters);
        //    if (result == null)
        //    {
        //        MessageBox.Show("Không tìm thấy Nhà xuất bản.");
        //        return;
        //    }

        //    string maNXB = result.ToString();

        //    var parameter = new SqlParameter[]
        //    {
        //        new SqlParameter("@sMasach",masach),
        //        new SqlParameter("@sTensach",tensach),
        //        new SqlParameter("@sMaNXB",maNXB),
        //        new SqlParameter("@sTacgia",tacgia),
        //        new SqlParameter("@sTheloai",theloai),
        //        new SqlParameter("@iGia",gia),
        //        new SqlParameter("@iSL",soluong),
        //        new SqlParameter("@iNamXB",namxb),
        //    };
        //    if (CheckIfBookExists(masach))
        //    {
        //        dBHelper.ExecuteNonQuery("SuaSach", parameter, CommandType.StoredProcedure);
        //    }
        //    else
        //    {
        //        dBHelper.ExecuteNonQuery("ThemSach", parameter, CommandType.StoredProcedure);
        //    }

        //}

        private bool CheckIfBookExists(string masach)
        {
            string sql = "SELECT COUNT(*) FROM tblSach WHERE sMasach = @sMasach";
            SqlParameter[] parameters = {
            new SqlParameter("@sMasach", masach)
            };
            object result = dBHelper.ExecuteScalar(sql, parameters);
            return Convert.ToInt32(result) > 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgdSach.Rows)
            {
                if (row.IsNewRow) continue;

                string masach = row.Cells["Mã sách"].Value?.ToString() ?? "";
                string tensach = row.Cells["Tên sách"].Value?.ToString() ?? "";
                string theloai = row.Cells["Thể loại"].Value?.ToString() ?? "";
                string tacgia = row.Cells["Tác giả"].Value?.ToString() ?? "";
                string tenNXB = row.Cells["Nhà xuất bản"].Value?.ToString() ?? "";

                // Chuyển đổi số an toàn
                int.TryParse(row.Cells["Số lượng"].Value?.ToString(), out int soluong);
                int.TryParse(row.Cells["Giá"].Value?.ToString(), out int gia);
                int.TryParse(row.Cells["Năm xuất bản"].Value?.ToString(), out int namxb);

                // Lấy mã NXB từ tên NXB
                string sql = "SELECT sMaNXB FROM tblNXB WHERE sTenNXB = @TenNXB";
                SqlParameter[] parameters = {
                    new SqlParameter("@TenNXB", tenNXB)
                };
                if (string.IsNullOrEmpty(tenNXB))
                {
                    MessageBox.Show("Vui lòng nhập tên nhà xuất bản", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                object result = dBHelper.ExecuteScalar(sql, parameters);
                if (result == null)
                {
                    MessageBox.Show($"Không tìm thấy Nhà xuất bản: {tenNXB}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    continue;
                }

                string maNXB = result.ToString();

                var parameter = new SqlParameter[]
                {
                    new SqlParameter("@sMasach", masach),
                    new SqlParameter("@sTensach", tensach),
                    new SqlParameter("@sMaNXB", maNXB),
                    new SqlParameter("@sTacgia", tacgia),
                    new SqlParameter("@sTheloai", theloai),
                    new SqlParameter("@iGia", gia),
                    new SqlParameter("@iSL", soluong),
                    new SqlParameter("@iNamXB", namxb),
                };

                if (CheckIfBookExists(masach))
                {
                    if (IsRowModified(masach, tensach, theloai, tacgia, maNXB, gia, soluong, namxb))
                    {
                        var count = dBHelper.ExecuteNonQuery("SuaSach", parameter, CommandType.StoredProcedure);
                        if (count != 0)
                        {
                            MessageBox.Show("Đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    if (!ValidateInput(out string errorMessage))
                    {
                        MessageBox.Show(errorMessage, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        dBHelper.ExecuteNonQuery("ThemSach", parameter, CommandType.StoredProcedure);
                        MessageBox.Show("Đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            LoadData();
        }

        private bool IsRowModified(string masach, string tensach, string theloai, string tacgia, string maNXB, int gia, int soluong, int namxb)
        {
            string query = "SELECT sTensach, sTheloai, sTacgia, sMaNXB, iGia, iSL, iNamXB FROM tblSach WHERE sMasach = @Masach";
            SqlParameter[] parameters = {
                new SqlParameter("@Masach", masach)
            };

            DataTable dt = dBHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count == 0) return false; // Không có sách trong DB => không so sánh

            DataRow dbRow = dt.Rows[0];

            // So sánh từng trường
            return
                dbRow["sTensach"].ToString() != tensach ||
                dbRow["sTheloai"].ToString() != theloai ||
                dbRow["sTacgia"].ToString() != tacgia ||
                dbRow["sMaNXB"].ToString() != maNXB ||
                Convert.ToInt32(dbRow["iGia"]) != gia ||
                Convert.ToInt32(dbRow["iSL"]) != soluong ||
                Convert.ToInt32(dbRow["iNamXB"]) != namxb;
        }


        private bool ValidateInput(out string errorMessage)
        {
            errorMessage = "";

            // Kiểm tra các trường bắt buộc
            if (string.IsNullOrWhiteSpace(txtMasach.Text))
                errorMessage = "Vui lòng nhập Mã sách.";
            else if (string.IsNullOrWhiteSpace(txtTensach.Text))
                errorMessage = "Vui lòng nhập Tên sách.";
            else if (string.IsNullOrWhiteSpace(txtGia.Text) || !int.TryParse(txtGia.Text, out _))
                errorMessage = "Giá phải là số nguyên hợp lệ.";
            else if (string.IsNullOrWhiteSpace(txtSoluong.Text) || !int.TryParse(txtSoluong.Text, out _))
                errorMessage = "Số lượng phải là số nguyên hợp lệ.";
            else if (string.IsNullOrWhiteSpace(txtNamxuatban.Text) || !int.TryParse(txtNamxuatban.Text, out int namxb) || namxb < 1900 || namxb > DateTime.Now.Year)
                errorMessage = "Năm xuất bản phải là số hợp lệ từ 1900 đến hiện tại.";
            else if (string.IsNullOrWhiteSpace(txtTacgia.Text))
                errorMessage = "Vui lòng nhập Tác giả.";
            else if (cbbNXB.SelectedIndex == -1)
                errorMessage = "Vui lòng chọn Nhà xuất bản.";

            return string.IsNullOrEmpty(errorMessage);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM vvSach WHERE 1 = 1";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (cbMasach.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtMasach.Text))
                {
                    sql += " AND [Mã sách] = @Masach";
                    parameters.Add(new SqlParameter("@Masach", txtMasach.Text));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (cbTacgia.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtTacgia.Text))
                {
                    sql += " AND [Tác giả] LIKE @Tacgia";
                    parameters.Add(new SqlParameter("@Tacgia", "%" + txtTacgia.Text + "%"));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (cbTensach.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtTensach.Text))
                {
                    sql += " AND [Tên sách] LIKE @Tensach";
                    parameters.Add(new SqlParameter("@Tensach", "%" + txtTensach.Text + "%"));
                }
                else
                {

                    MessageBox.Show("Vui lòng nhập tên tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (cbGia.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtGia.Text) && int.TryParse(txtGia.Text, out int gia))
                {
                    sql += " AND [Giá] = @Gia";
                    parameters.Add(new SqlParameter("@Gia", gia));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập giá là một số hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (cbNamXB.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtNamxuatban.Text) && int.TryParse(txtNamxuatban.Text, out int namXB))
                {
                    sql += " AND [Năm xuất bản] = @NamXB";
                    parameters.Add(new SqlParameter("@NamXB", namXB));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập năm xuất bản là một số hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (cbTheLoai.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtTheloai.Text))
                {
                    sql += " AND [Thể loại] = @Theloai";
                    parameters.Add(new SqlParameter("@Theloai", txtTheloai.Text));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (cbSoluong.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtSoluong.Text) && int.TryParse(txtSoluong.Text, out int soluong))
                {
                    sql += " AND [Số lượng] = @Soluong";
                    parameters.Add(new SqlParameter("@Soluong", soluong));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng là số hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (cbNXB.Checked)
            {
                sql += " AND [Nhà xuất bản] = @NXB";
                parameters.Add(new SqlParameter("@NXB", cbbNXB.Text));
            }

            DataTable dataTable = new DataTable();
            dataTable = dBHelper.ExecuteQuery(sql, parameters.ToArray());
            dBHelper.FillDataGridView(dgdSach, dataTable);
        }
    }
}
