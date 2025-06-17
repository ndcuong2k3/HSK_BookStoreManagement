using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HSK_BookStoreManagement
{
    public partial class DangNhap : Form
    {
        private readonly DBHelper dbHelper = new DBHelper();
        private bool isPasswordVisible = true;

        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTaikhoan.Text.Trim();
            string sql = "SELECT sMatKhau FROM tblTaiKhoan WHERE sTenDangNhap = @TenDN";

            var parameters = new SqlParameter[]
            {
                new SqlParameter("@TenDN", tenDangNhap)
            };

            object result = dbHelper.ExecuteScalar(sql, parameters);

            if (result == null)
            {
                ShowError("Tên đăng nhập hoặc mật khẩu không đúng.");
                return;
            }

            string matKhauGiaiMa;
            try
            {
                matKhauGiaiMa = AES.Decrypt(result.ToString());
            }
            catch
            {
                ShowError("Lỗi giải mã mật khẩu.");
                return;
            }

            if (matKhauGiaiMa != txtMatkhau.Text)
            {
                ShowError("Tên đăng nhập hoặc mật khẩu không đúng.");
                return;
            }

            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Sach sach = new Sach();
            //sach.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            isPasswordVisible = !isPasswordVisible;
            txtMatkhau.UseSystemPasswordChar = !isPasswordVisible;

            pictureBox2.Image = isPasswordVisible
                ? Properties.Resources.icons8_hide_password_30
                : Properties.Resources.icons8_eye_30;
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
    }
}
