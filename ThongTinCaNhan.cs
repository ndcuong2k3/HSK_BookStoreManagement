using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace HSK_BookStoreManagement
{
    public partial class ThongTinCaNhan : Form
    {
        private string MaNV;
        private string Gioitinh;
        private DBHelper dBHelper = new DBHelper();
        
        public ThongTinCaNhan(string ma, string gioitinh)
        {
            InitializeComponent();
            MaNV = ma;
            Gioitinh = gioitinh;
        }

        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            if(Gioitinh.Equals("Nữ") == true)
            {
                pictureBox1.Image = Properties.Resources.female_icon_resizedpng;
            }
            string queryNV = "Select * from tblNhanVien where sMaNV = @MaNV";
            var parameterNV = new SqlParameter[]
            {
                new SqlParameter("@MaNV",MaNV)
            };
            DataTable nhanVien = dBHelper.ExecuteQuery(queryNV, parameterNV);

            string queryTK = "Select * from tblTaiKhoan where sMaNV = @MaNV";
            var parameterTK = new SqlParameter[]
            {
                new SqlParameter("@MaNV",MaNV)
            };
            DataTable taiKhoan = dBHelper.ExecuteQuery(queryTK, parameterTK);

            txtMaNV.Text = nhanVien.Rows[0]["sMaNV"].ToString();
            txtTenNV.Text = nhanVien.Rows[0]["sTenNV"].ToString();
            txtChucvu.Text = nhanVien.Rows[0]["sChucvu"].ToString();
            txtGioitinh.Text = nhanVien.Rows[0]["sGioitinh"].ToString();
            txtQueQuan.Text = nhanVien.Rows[0]["sQuequan"].ToString();
            txtSDT.Text = nhanVien.Rows[0]["sSDT"].ToString();
            dtpNgaysinh.Text = nhanVien.Rows[0]["dNgaysinh"].ToString();
            dtpNgayvaolam.Text = nhanVien.Rows[0]["dNgayvaolam"].ToString();

            txtTenTK.Text = taiKhoan.Rows[0]["sTenDangNhap"].ToString();
            txtMatkhau.Text = AES.Decrypt(taiKhoan.Rows[0]["sMatKhau"].ToString());
        }

        private void CapNhatTTbt_Click(object sender, EventArgs e)
        {
            if (!ValidateThongTinCaNhan()) return;
            var parameters = new SqlParameter[]
           {
                new SqlParameter("@MaNV", txtMaNV.Text),
                new SqlParameter("@TenNV", txtTenNV.Text),
                new SqlParameter("@ChucVu", txtChucvu.Text),
                new SqlParameter("@GioiTinh", txtGioitinh.Text),
                new SqlParameter("@QueQuan", txtQueQuan.Text),
                new SqlParameter("@SDT", txtSDT.Text),
                new SqlParameter("@NgaySinh", dtpNgaysinh.Value),
                new SqlParameter("@NgayVaoLam", dtpNgayvaolam.Value)
           };

            dBHelper.ExecuteNonQuery("sp_UpdateNhanVienTheoMa", parameters, CommandType.StoredProcedure);
            MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ThongTinCaNhan_Load(sender, e);
        }

        private void CapNhatTkbt_Click(object sender, EventArgs e)
        {
            var parametersMatKhau = new SqlParameter[]
            {
                new SqlParameter("@MaNV", txtMaNV.Text),
                new SqlParameter("@MatKhau", AES.Encrypt(txtMatkhau.Text))
            };

            dBHelper.ExecuteNonQuery("sp_UpdateMatKhauTheoMaNV", parametersMatKhau, CommandType.StoredProcedure);

            MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private bool ValidateThongTinCaNhan()
        {
            if (string.IsNullOrWhiteSpace(txtTenNV.Text) ||
                string.IsNullOrWhiteSpace(txtChucvu.Text) ||
                string.IsNullOrWhiteSpace(txtGioitinh.Text) ||
                string.IsNullOrWhiteSpace(txtQueQuan.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            int tuoi = DateTime.Now.Year - dtpNgaysinh.Value.Year;
            if (dtpNgaysinh.Value > DateTime.Now.AddYears(-tuoi)) tuoi--;

            if (tuoi < 18)
            {
                MessageBox.Show("Nhân viên phải từ 18 tuổi trở lên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!txtSDT.Text.All(char.IsDigit) || txtSDT.Text.Length < 9 || txtSDT.Text.Length > 11)
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ValidateTaiKhoan()
        {
            if (string.IsNullOrWhiteSpace(txtMatkhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtMatkhau.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

    }
}
