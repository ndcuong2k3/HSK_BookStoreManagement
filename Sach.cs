using iTextSharp.text;
using iTextSharp.text.pdf;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.AccessControl;
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

            string cbquery = "SELECT sMaDV, sTenDV FROM tblDonViSanXuat";
            dBHelper.FillComboBox(cbbNXB, cbquery, "sTenDV", "sMaDV");

        }

        private void dgdSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            var row = dgdSach.Rows[e.RowIndex];
            txtMaSP.Text = row.Cells["Mã sách"].Value?.ToString() ?? "";
            txtTenSP.Text = row.Cells["Tên sách"].Value?.ToString() ?? "";
            txtTheloai.Text = row.Cells["Thể loại"].Value?.ToString() ?? "";
            txtSoluong.Text = row.Cells["Số lượng"].Value?.ToString() ?? "";
            txtGiaBan.Text = row.Cells["Giá bán"].Value?.ToString() ?? "";
            txtGiaNhap.Text = row.Cells["Giá nhập"].Value?.ToString() ?? "";
            txtNamxuatban.Text = row.Cells["Năm xuất bản"].Value?.ToString() ?? "";
            txtTacgia.Text = row.Cells["Tác giả"].Value?.ToString() ?? "";
            cbbNXB.Text = row.Cells["Đơn vị sản xuất"].Value?.ToString() ?? "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out string error))
            {
                MessageBox.Show(error, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //string sql = "Select sMaSP from tblSanPham where sMaSP = @MaSP";
            //var parameter = new SqlParameter[]
            //{
            //        new SqlParameter("@MaSP",txtMaSP.Text )
            //};
            //var ob = dBHelper.ExecuteScalar(sql, parameter);
            //if (ob != null)
            //{
            //    MessageBox.Show("Đã tồn tại sách có mã vừa nhập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            string sql = @"
                SELECT ISNULL(MAX(CAST(SUBSTRING(sMaSP, 3, LEN(sMaSP) - 2) AS INT)), 0)
                FROM tblSanPham"
            ;

            int maxSo = Convert.ToInt32(dBHelper.ExecuteScalar(sql));
            int soMoi = maxSo + 1;
            string maSP = "SP" + soMoi.ToString("D3");
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@sMaSP", maSP),
                new SqlParameter("@sTenSP", txtTenSP.Text),
                new SqlParameter("@iGiaNhap", Convert.ToInt32(txtGiaNhap.Text)),
                new SqlParameter("@iGiaBan", Convert.ToInt32(txtGiaBan.Text)),
                new SqlParameter("@iSL", Convert.ToInt32(txtSoluong.Text)),
                new SqlParameter("@sTacgia", txtTacgia.Text),
                new SqlParameter("@sTheloai", txtTheloai.Text),
                new SqlParameter("@iNamXB", Convert.ToInt32(txtNamxuatban.Text)),
                new SqlParameter("@sMaDV", cbbNXB.SelectedValue),
            };

            dBHelper.ExecuteNonQuery("prThemSach", parameters, CommandType.StoredProcedure);
            MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@sMaSP", txtMaSP.Text),
                new SqlParameter("@sTenSP", txtTenSP.Text),
                new SqlParameter("@iGiaNhap", Convert.ToInt32(txtGiaNhap.Text)),
                new SqlParameter("@iGiaBan", Convert.ToInt32(txtGiaBan.Text)),
                new SqlParameter("@iSL", Convert.ToInt32(txtSoluong.Text)),
                new SqlParameter("@sTacgia", txtTacgia.Text),
                new SqlParameter("@sTheloai", txtTheloai.Text),
                new SqlParameter("@iNamXB", Convert.ToInt32(txtNamxuatban.Text)),
                new SqlParameter("@sMaDV", cbbNXB.SelectedValue)
            };
            dBHelper.ExecuteNonQuery("prSuaSach", parameters, CommandType.StoredProcedure);
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
                    new SqlParameter("@sMaSP",txtMaSP.Text)
                };
                dBHelper.ExecuteNonQuery("prXoaSach", parameters, CommandType.StoredProcedure);
                MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInput();
            }

        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearInput();
            LoadData();
            cbGiaBan.Checked = false;
            cbMasach.Checked = false;
            cbNamXB.Checked = false;
            cbNXB.Checked = false;
            cbSoluong.Checked = false;
            cbTacgia.Checked = false;
            cbTensach.Checked = false;
            cbNXB.Checked = false;
            cbTheLoai.Checked = false;
            cbGiaNhap.Checked = false;
        }

        private void ClearInput()
        {
            txtGiaBan.Text = string.Empty;
            txtMaSP.Text = string.Empty;
            txtNamxuatban.Text = string.Empty;
            txtSoluong.Text = string.Empty;
            txtTacgia.Text = string.Empty;
            txtTenSP.Text = string.Empty;
            txtTheloai.Text = string.Empty;
            txtGiaNhap.Text = string.Empty;
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
            string sql = "SELECT COUNT(*) FROM tblSach WHERE sMaSP = @sMaSP";
            SqlParameter[] parameters = {
                new SqlParameter("@sMaSP", masach)
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
                string tenNXB = row.Cells["Đơn vị sản xuất"].Value?.ToString() ?? "";

                int.TryParse(row.Cells["Số lượng"].Value?.ToString(), out int soluong);
                int.TryParse(row.Cells["Giá bán"].Value?.ToString(), out int giaban);
                int.TryParse(row.Cells["Giá nhập"].Value?.ToString(), out int gianhap);
                int.TryParse(row.Cells["Năm xuất bản"].Value?.ToString(), out int namxb);

                // Kiểm tra tên nhà xuất bản
                if (string.IsNullOrEmpty(tenNXB))
                {
                    MessageBox.Show("Vui lòng nhập tên nhà xuất bản", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy mã NXB
                string sql = "SELECT sMaDV FROM tblDonViSanXuat WHERE sTenDV = @TenNXB";
                SqlParameter[] getMaDVParams = {
                    new SqlParameter("@TenNXB", tenNXB)
                };
                object result = dBHelper.ExecuteScalar(sql, getMaDVParams);
                if (result == null)
                {
                    MessageBox.Show($"Không tìm thấy đơn vị sản xuất: {tenNXB}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    continue;
                }
                string maDV = result.ToString();

                // Tạo parameter để truyền vào SP
                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@sMaSP", masach),
                    new SqlParameter("@sTenSP", tensach),
                    new SqlParameter("@iGiaNhap", gianhap),
                    new SqlParameter("@iGiaBan", giaban),
                    new SqlParameter("@iSL", soluong),
                    new SqlParameter("@sTacgia", tacgia),
                    new SqlParameter("@sTheloai", theloai),
                    new SqlParameter("@iNamXB", namxb),
                    new SqlParameter("@sMaDV", maDV),
                };

                // Kiểm tra tồn tại
                if (CheckIfBookExists(masach))
                {
                    // Nếu có thay đổi dữ liệu
                    if (IsRowModified(masach, tensach, theloai, tacgia, maDV, giaban, soluong, namxb, gianhap))
                    {
                        dBHelper.ExecuteNonQuery("prSuaSach", parameters, CommandType.StoredProcedure);
                    }
                }
                else
                {
                    // Validate đầu vào trước khi thêm mới
                    if (string.IsNullOrWhiteSpace(masach) || string.IsNullOrWhiteSpace(tensach))
                    {
                        MessageBox.Show("Thông tin mã sách hoặc tên sách không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    dBHelper.ExecuteNonQuery("prThemSach", parameters, CommandType.StoredProcedure);
                }
            }

            MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }


        private bool IsRowModified(string masach, string tensach, string theloai, string tacgia, string maDV, int giaban, int soluong, int namxb, int gianhap)
        {
            string query = @"
                SELECT sp.sTenSP, sp.iGiaNhap, sp.iGiaBan, sp.iSL,
                       sa.sTacgia, sa.sTheloai, sa.iNamXB, sa.sMaDV
                FROM tblSanPham sp
                JOIN tblSach sa ON sp.sMaSP = sa.sMaSP
                WHERE sp.sMaSP = @MaSP
            ";

            SqlParameter[] parameters = {
                new SqlParameter("@MaSP", masach)
            };

            DataTable dt = dBHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count == 0) return false;

            DataRow row = dt.Rows[0];

            return
                row["sTenSP"].ToString() != tensach ||
                row["sTacgia"].ToString() != tacgia ||
                row["sTheloai"].ToString() != theloai ||
                row["sMaDV"].ToString() != maDV ||
                Convert.ToInt32(row["iGiaNhap"]) != gianhap ||
                Convert.ToInt32(row["iGiaBan"]) != giaban ||
                Convert.ToInt32(row["iSL"]) != soluong ||
                Convert.ToInt32(row["iNamXB"]) != namxb;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM vvSach WHERE 1 = 1";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (cbMasach.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtMaSP.Text))
                {
                    sql += " AND [Mã sách] = @Masach";
                    parameters.Add(new SqlParameter("@Masach", txtMaSP.Text));
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
                if (!string.IsNullOrWhiteSpace(txtTenSP.Text))
                {
                    sql += " AND [Tên sách] LIKE @Tensach";
                    parameters.Add(new SqlParameter("@Tensach", "%" + txtTenSP.Text + "%"));
                }
                else
                {

                    MessageBox.Show("Vui lòng nhập tên tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (cbGiaBan.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txtGiaBan.Text) && int.TryParse(txtGiaBan.Text, out int gia))
                {
                    sql += " AND [Giá bán] = @Gia";
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
                sql += " AND [Đơn vị sản xuất] = @NXB";
                parameters.Add(new SqlParameter("@NXB", cbbNXB.Text));
            }

            if (cbGiaNhap.Checked)
            {
                sql += " AND [Giá nhập] = @GiaNhap";
                parameters.Add(new SqlParameter("@GiaNhap", txtGiaNhap.Text));
            }

            DataTable dataTable = new DataTable();
            dataTable = dBHelper.ExecuteQuery(sql, parameters.ToArray());
            dBHelper.FillDataGridView(dgdSach, dataTable);
        }
        private bool ValidateInput(out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                errorMessage = "Vui lòng nhập Tên sách.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTheloai.Text))
            {
                errorMessage = "Vui lòng nhập Thể loại.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTacgia.Text))
            {
                errorMessage = "Vui lòng nhập Tác giả.";
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

            // ⚠️ Kiểm tra giá bán không được nhỏ hơn giá nhập
            if (giaBan < giaNhap)
            {
                errorMessage = "Giá bán không được nhỏ hơn Giá nhập.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoluong.Text) || !int.TryParse(txtSoluong.Text, out int soLuong) || soLuong < 0)
            {
                errorMessage = "Số lượng phải là số nguyên dương.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNamxuatban.Text) || !int.TryParse(txtNamxuatban.Text, out int namXB) || namXB < 1900 || namXB > DateTime.Now.Year)
            {
                errorMessage = $"Năm xuất bản phải nằm trong khoảng 1900 - {DateTime.Now.Year}.";
                return false;
            }

            if (cbbNXB.SelectedIndex == -1 || cbbNXB.SelectedValue == null)
            {
                errorMessage = "Vui lòng chọn Nhà xuất bản.";
                return false;
            }

            return true;
        }

        private void Sach_Load(object sender, EventArgs e)
        {

        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            ExportExcel2();

        }

        private void ExportExcel2() {
            try
            {
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = (Microsoft.Office.Interop.Excel._Worksheet)excelApp.ActiveSheet;
                worksheet.Name = "Exported from DataGridView";

                // Xuất tiêu đề cột
                for (int i = 1; i <= dgdSach.Columns.Count; i++)
                {
                    worksheet.Cells[1, i] = dgdSach.Columns[i - 1].HeaderText;
                }

                // Xuất dữ liệu
                for (int i = 0; i < dgdSach.Rows.Count; i++)
                {
                    for (int j = 0; j < dgdSach.Columns.Count; j++)
                    {
                        if (dgdSach.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgdSach.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }

                // Hiển thị và lưu
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Workbook|*.xlsx";
                sfd.Title = "Save an Excel File";
                sfd.FileName = "Export.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    worksheet.SaveAs(sfd.FileName);
                    MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                excelApp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message);
            }
        }
        private void ExportExcel()
        {
            ExcelPackage.License.SetNonCommercialOrganization("My Noncommercial organization");

            using (ExcelPackage pck = new ExcelPackage())
            {
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Sách");

                // Tiêu đề cột
                for (int i = 0; i < dgdSach.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1].Value = dgdSach.Columns[i].HeaderText;
                }

                // Dữ liệu
                for (int i = 0; i < dgdSach.Rows.Count; i++)
                {
                    for (int j = 0; j < dgdSach.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1].Value = dgdSach.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                // Lưu
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel file|*.xlsx";
                sfd.Title = "Save as Excel file";
                sfd.FileName = "Export_EPPlus.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(sfd.FileName, pck.GetAsByteArray());
                    MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void ExportPDF(DataGridView dgv)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF file (*.pdf)|*.pdf";
            saveFileDialog.FileName = "DanhSachSach.pdf";

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            string fontPath = Path.Combine(Application.StartupPath, "Fonts", "arial.ttf");

            BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font font = new Font(bf, 12);

            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 20f, 30f);
            PdfWriter.GetInstance(pdfDoc, new FileStream(saveFileDialog.FileName, FileMode.Create));
            pdfDoc.Open();

            PdfPTable pdfTable = new PdfPTable(dgv.ColumnCount);
            pdfTable.WidthPercentage = 100;

            // Xuất tiêu đề
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                pdfTable.AddCell(cell);
            }

            // Xuất dữ liệu
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    string cellText = cell.Value?.ToString() ?? "";
                    pdfTable.AddCell(new Phrase(cellText, font));
                }
            }

            pdfDoc.Add(pdfTable);
            pdfDoc.Close();

            MessageBox.Show("Xuất PDF thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
