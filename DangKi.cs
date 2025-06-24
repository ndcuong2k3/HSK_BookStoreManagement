using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace HSK_BookStoreManagement
{
    public partial class DangKi : Form
    {
        DBHelper dbHelper = new DBHelper();

        public DangKi()
        {
            InitializeComponent();
        }

        private void DangKi_Load(object sender, EventArgs e)
        {
            cbbGioitinh.Items.AddRange(new string[] { "Nam", "Nữ" });
            cbbGioitinh.Text = "Nam";
        }

        private void lbDangnhap_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            this.Hide();
            dangNhap.ShowDialog();
            this.Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!ValidateNhanVien()) return;

            try
            {
                // Tạo mã nhân viên mới
                string maNV = (Convert.ToInt32(dbHelper.ExecuteScalar(
                    "SELECT ISNULL(MAX(CAST(SUBSTRING(sMaNV, 3, LEN(sMaNV)-2) AS INT)), 0) FROM tblNhanVien")) + 1).ToString();
                maNV = "NV" + maNV.PadLeft(3, '0');

                // Thêm vào bảng Nhân viên
                SqlParameter[] parameters = {
                    new SqlParameter("@sMaNV", maNV),
                    new SqlParameter("@sTenNV", txtHoten.Text),
                    new SqlParameter("@dNgaysinh", dtpNgaysinh.Value),
                    new SqlParameter("@sGioitinh", cbbGioitinh.Text),
                    new SqlParameter("@sQuequan", txtQuequan.Text),
                    new SqlParameter("@sSDT", txtSDT.Text),
                    new SqlParameter("@sChucvu", "Nhân viên"),
                    new SqlParameter("@dNgayvaolam", DateTime.Now)
                };
                dbHelper.ExecuteNonQuery("pr_ThemNhanVien", parameters, CommandType.StoredProcedure);

                // Thêm vào bảng Tài khoản
                string queryTK = "INSERT INTO tblTaiKhoan VALUES(@sTenDangNhap, @sMatKhau, @sMaNV)";
                SqlParameter[] sqlParameters =
                {
                    new SqlParameter("@sTenDangNhap", txtTaikhoan.Text),
                    new SqlParameter("@sMatKhau", AES.Encrypt(txtMatkhau.Text)),
                    new SqlParameter("@sMaNV", maNV),
                };
                dbHelper.ExecuteNonQuery(queryTK, sqlParameters);

                MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Chuyển về form đăng nhập
                DangNhap dangNhap = new DangNhap();
                dangNhap.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateNhanVien()
        {
            if (string.IsNullOrWhiteSpace(txtHoten.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoten.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtQuequan.Text))
            {
                MessageBox.Show("Vui lòng nhập quê quán.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuequan.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTaikhoan.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaikhoan.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMatkhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatkhau.Focus();
                return false;
            }

            if (txtSDT.Text.Length < 9 || txtSDT.Text.Length > 11 || !txtSDT.Text.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return false;
            }

            // Kiểm tra độ tuổi (phải >= 18)
            DateTime now = DateTime.Now;
            int age = now.Year - dtpNgaysinh.Value.Year;
            if (dtpNgaysinh.Value > now.AddYears(-age)) age--;
            if (age < 18)
            {
                MessageBox.Show("Nhân viên phải từ 18 tuổi trở lên.", "Lỗi độ tuổi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
