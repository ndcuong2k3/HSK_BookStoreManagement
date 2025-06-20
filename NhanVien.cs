using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HSK_BookStoreManagement
{
    public partial class NhanVien : Form
    {
        private DBHelper database = new DBHelper();
        private string selectedMaNV = "";

        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            cb_GioiTinh.Items.Clear();
            cb_GioiTinh.Items.AddRange(new string[] { "Nam", "Nữ" });

            DataTable dt = database.ExecuteQuery("SELECT * FROM tblNhanVien");
            dtgv_NhanVien.DataSource = dt;
        }

        private bool ValidateNhanVien()
        {
            if (string.IsNullOrWhiteSpace(txt_TenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên."); txt_TenNV.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(cb_GioiTinh.Text) || (cb_GioiTinh.Text != "Nam" && cb_GioiTinh.Text != "Nữ"))
            {
                MessageBox.Show("Giới tính phải là 'Nam' hoặc 'Nữ'."); cb_GioiTinh.Focus(); return false;
            }
            int tuoi = DateTime.Now.Year - dtp_NgaySinh.Value.Year;
            if (tuoi < 18 || (tuoi == 18 && DateTime.Now < dtp_NgaySinh.Value.AddYears(18)))
            {
                MessageBox.Show("Nhân viên phải đủ 18 tuổi."); dtp_NgaySinh.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(txt_QueQuan.Text))
            {
                MessageBox.Show("Vui lòng nhập quê quán."); txt_QueQuan.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(txt_SDT.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txt_SDT.Text, @"^0\d{9}$"))
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bằng số 0."); txt_SDT.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(txt_ChucVu.Text))
            {
                MessageBox.Show("Vui lòng nhập chức vụ."); txt_ChucVu.Focus(); return false;
            }
            if (dtp_NgayVaoLam.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày vào làm không được lớn hơn hiện tại."); dtp_NgayVaoLam.Focus(); return false;
            }
            return true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!ValidateNhanVien()) return;

            string maNV = (Convert.ToInt32(database.ExecuteScalar(
                "SELECT ISNULL(MAX(CAST(SUBSTRING(sMaNV, 3, LEN(sMaNV)-2) AS INT)), 0) FROM tblNhanVien")) + 1).ToString();
            maNV = "NV" + maNV.PadLeft(3, '0');

            SqlParameter[] parameters = {
                new SqlParameter("@sMaNV", maNV),
                new SqlParameter("@sTenNV", txt_TenNV.Text),
                new SqlParameter("@dNgaysinh", dtp_NgaySinh.Value),
                new SqlParameter("@sGioitinh", cb_GioiTinh.Text),
                new SqlParameter("@sQuequan", txt_QueQuan.Text),
                new SqlParameter("@sSDT", txt_SDT.Text),
                new SqlParameter("@sChucvu", txt_ChucVu.Text),
                new SqlParameter("@dNgayvaolam", dtp_NgayVaoLam.Value)
            };

            database.ExecuteNonQuery("pr_ThemNhanVien", parameters, CommandType.StoredProcedure);
            NhanVien_Load(sender, e);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (!ValidateNhanVien()) return;

            if (dtgv_NhanVien.CurrentRow != null)
            {
                string maNV = dtgv_NhanVien.CurrentRow.Cells["sMaNV"].Value.ToString();

                SqlParameter[] parameters = {
                    new SqlParameter("@sMaNV", maNV),
                    new SqlParameter("@sTenNV", txt_TenNV.Text),
                    new SqlParameter("@dNgaysinh", dtp_NgaySinh.Value),
                    new SqlParameter("@sGioitinh", cb_GioiTinh.Text),
                    new SqlParameter("@sQuequan", txt_QueQuan.Text),
                    new SqlParameter("@sSDT", txt_SDT.Text),
                    new SqlParameter("@sChucvu", txt_ChucVu.Text),
                    new SqlParameter("@dNgayvaolam", dtp_NgayVaoLam.Value)
                };

                database.ExecuteNonQuery("pr_SuaNhanVien", parameters, CommandType.StoredProcedure);
                NhanVien_Load(sender, e);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dtgv_NhanVien.CurrentRow != null)
            {
                string maNV = dtgv_NhanVien.CurrentRow.Cells["sMaNV"].Value.ToString();

                SqlParameter[] parameters = {
                    new SqlParameter("@sMaNV", maNV)
                };

                database.ExecuteNonQuery("pr_XoaNhanVien", parameters, CommandType.StoredProcedure);
                NhanVien_Load(sender, e);
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txt_TimKiem.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm."); return;
            }

            SqlParameter[] parameters = {
                new SqlParameter("@keyword", keyword)
            };

            DataTable dt = database.ExecuteQuery("pr_TimKiemNhanVien", parameters, CommandType.StoredProcedure);
            dtgv_NhanVien.DataSource = dt;
        }

        private void dtgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_NhanVien.Rows[e.RowIndex];
                selectedMaNV = row.Cells["sMaNV"].Value.ToString();

                txt_TenNV.Text = row.Cells["sTenNV"].Value.ToString();
                dtp_NgaySinh.Value = Convert.ToDateTime(row.Cells["dNgaysinh"].Value);
                cb_GioiTinh.Text = row.Cells["sGioitinh"].Value.ToString();
                txt_QueQuan.Text = row.Cells["sQuequan"].Value.ToString();
                txt_SDT.Text = row.Cells["sSDT"].Value.ToString();
                txt_ChucVu.Text = row.Cells["sChucvu"].Value.ToString();
                dtp_NgayVaoLam.Value = Convert.ToDateTime(row.Cells["dNgayvaolam"].Value);
            }
        }
    }
}
