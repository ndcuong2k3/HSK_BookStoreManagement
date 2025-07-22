using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HSK_BookStoreManagement
{
    public partial class KhachHang : Form
    {
        private DBHelper db = new DBHelper();

        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
            StyleUI();
        }

        private void LoadData()
        {
            DataTable dt = db.GetTable("tblKhachHang");
            dgvKhachHang.DataSource = dt;
        }

        private void StyleUI()
        {
            this.BackColor = Color.FromArgb(240, 248, 255);

            foreach (Control ctrl in this.Controls)
                if (ctrl is Label lbl)
                    lbl.ForeColor = Color.DarkSlateBlue;

            txtMaKH.Font = txtTenKH.Font = txtDienThoai.Font = txtDiaChi.Font = new Font("Segoe UI", 10);

            StyleButton(btnThem, Color.MediumSeaGreen);
            StyleButton(btnSua, Color.DodgerBlue);
            StyleButton(btnXoa, Color.IndianRed);
            StyleButton(btnTimKiem, Color.Goldenrod);

            dgvKhachHang.BackgroundColor = Color.White;
            dgvKhachHang.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvKhachHang.DefaultCellStyle.BackColor = Color.AliceBlue;
            dgvKhachHang.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvKhachHang.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private void StyleButton(Button btn, Color bgColor)
        {
            btn.BackColor = bgColor;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sdt = txtDienThoai.Text.Trim();
            if (!Regex.IsMatch(sdt, @"^0\d{9}$"))
            {
                MessageBox.Show("Số điện thoại phải bắt đầu bằng 0 và có 10 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string checkSql = "SELECT COUNT(*) FROM tblKhachHang WHERE sMaKH = @sMaKH";
            SqlParameter[] checkParams = { new SqlParameter("@sMaKH", txtMaKH.Text) };
            int exists = Convert.ToInt32(db.ExecuteScalar(checkSql, checkParams));
            if (exists > 0)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string insertSql = "INSERT INTO tblKhachHang VALUES (@sMaKH, @sTenKH, @sDiachi,@sSDT )";
            SqlParameter[] insertParams = {
                new SqlParameter("@sMaKH", txtMaKH.Text),
                new SqlParameter("@sTenKH", txtTenKH.Text),
                new SqlParameter("@sSDT", sdt),
                new SqlParameter("@sDiachi", txtDiaChi.Text)
            };
            int result = db.ExecuteNonQuery(insertSql, insertParams);
            MessageBox.Show(result > 0 ? "Thêm thành công!" : "Thêm thất bại.", "Thông báo");
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string updateSql = "UPDATE tblKhachHang SET sTenKH=@sTenKH, sSDT=@sSDT, sDiachi=@sDiachi WHERE sMaKH=@sMaKH";
            SqlParameter[] updateParams = {
                new SqlParameter("@sMaKH", txtMaKH.Text),
                new SqlParameter("@sTenKH", txtTenKH.Text),
                new SqlParameter("@sSDT", txtDienThoai.Text),
                new SqlParameter("@sDiachi", txtDiaChi.Text)
            };
            int result = db.ExecuteNonQuery(updateSql, updateParams);
            MessageBox.Show(result > 0 ? "Sửa thành công!" : "Không tìm thấy để sửa.", "Thông báo");
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                string deleteSql = "DELETE FROM tblKhachHang WHERE sMaKH = @sMaKH";
                SqlParameter[] deleteParams = { new SqlParameter("@sMaKH", txtMaKH.Text) };
                int result = db.ExecuteNonQuery(deleteSql, deleteParams);
                MessageBox.Show(result > 0 ? "Xóa thành công!" : "Không tìm thấy để xóa.", "Thông báo");
                LoadData();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            SqlParameter[] param = null;

            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
                sql = "SELECT * FROM tblKhachHang";
            else
            {
                sql = "SELECT * FROM tblKhachHang WHERE sTenKH LIKE @sTenKH";
                param = new SqlParameter[] { new SqlParameter("@sTenKH", "%" + txtTenKH.Text + "%") };
            }

            dgvKhachHang.DataSource = db.ExecuteQuery(sql, param);
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["sMaKH"].Value.ToString();
                txtTenKH.Text = row.Cells["sTenKH"].Value.ToString();
                txtDienThoai.Text = row.Cells["sSDT"].Value.ToString();
                txtDiaChi.Text = row.Cells["sDiachi"].Value.ToString();
            }
        }
    }
}
