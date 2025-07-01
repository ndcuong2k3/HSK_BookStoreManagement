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
    public partial class HoaDon : Form
    {
        DBHelper database = new DBHelper();
        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
            LoadHoaDonData();
        }

        private void LoadComboBoxData()
        {
            // Đổ dữ liệu mã nhân viên
            database.FillComboBox(cb_maNV, "SELECT sMaNV, sTenNV FROM tblNhanVien", "sTenNV", "sMaNV");

            // Đổ dữ liệu mã khách hàng
            database.FillComboBox(cb_maKH, "SELECT sMaKH, sTenKH FROM tblKhachHang", "sTenKH", "sMaKH");

            // Trạng thái hóa đơn
            cb_trangThai.Items.Clear();
            cb_trangThai.Items.AddRange(new string[] { "Đã thanh toán", "Chưa thanh toán" });
            cb_trangThai.SelectedIndex = 1;
        }

        private void LoadHoaDonData()
        {
            DataTable dt = database.ExecuteQuery(@"
    SELECT 
        hd.sMaHD as [Mã hóa đơn],
        nv.sTenNV AS [Tên nhân viên],
        kh.sTenKH AS [Tên khách hàng],
        hd.dNgaylap AS [Ngày lập],
        hd.sTrangthai AS [Trạng thái]
    FROM tblHoaDon hd
    JOIN tblNhanVien nv ON hd.sMaNV = nv.sMaNV
    JOIN tblKhachHang kh ON hd.sMaKH = kh.sMaKH
");
            dtgv_HoaDon.DataSource = dt;
        }

        private bool ValidateHoaDon()
        {
            if (cb_maNV.SelectedIndex == -1) { MessageBox.Show("Vui lòng chọn nhân viên."); cb_maNV.Focus(); return false; }
            if (cb_maKH.SelectedIndex == -1) { MessageBox.Show("Vui lòng chọn khách hàng."); cb_maKH.Focus(); return false; }
            if (cb_trangThai.SelectedIndex == -1) { MessageBox.Show("Vui lòng chọn trạng thái hóa đơn."); cb_trangThai.Focus(); return false; }
            if (dtp_ngayLap.Value.Date > DateTime.Now.Date) { MessageBox.Show("Ngày lập hóa đơn không hợp lệ."); dtp_ngayLap.Focus(); return false; }
            return true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!ValidateHoaDon()) return;

            string maHD = (Convert.ToInt32(database.ExecuteScalar(
                "SELECT ISNULL(MAX(CAST(SUBSTRING(sMaHD, 3, LEN(sMaHD)-2) AS INT)), 0) FROM tblHoaDon")) + 1).ToString();
            maHD = "HD" + maHD.PadLeft(3, '0');

            SqlParameter[] parameters = {
                new SqlParameter("@sMaHD", maHD),
                new SqlParameter("@sMaNV", cb_maNV.SelectedValue),
                new SqlParameter("@sMaKH", cb_maKH.SelectedValue),
                new SqlParameter("@dNgayLap", dtp_ngayLap.Value),
                new SqlParameter("@sTrangThai", cb_trangThai.Text)
            };

            database.ExecuteNonQuery("INSERT INTO tblHoaDon VALUES (@sMaHD, @sMaNV, @sMaKH, @dNgayLap, @sTrangThai)", parameters);
            LoadHoaDonData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dtgv_HoaDon.CurrentRow == null) return;
            if (!ValidateHoaDon()) return;

            string maHD = dtgv_HoaDon.CurrentRow.Cells["sMaHD"].Value.ToString();

            SqlParameter[] parameters = {
                new SqlParameter("@sMaNV", cb_maNV.SelectedValue),
                new SqlParameter("@sMaKH", cb_maKH.SelectedValue),
                new SqlParameter("@dNgayLap", dtp_ngayLap.Value),
                new SqlParameter("@sTrangThai", cb_trangThai.Text),
                new SqlParameter("@sMaHD", maHD)
            };

            database.ExecuteNonQuery("UPDATE tblHoaDon SET sMaNV = @sMaNV, sMaKH = @sMaKH, dNgaylap = @dNgayLap, sTrangthai = @sTrangThai WHERE sMaHD = @sMaHD", parameters);
            LoadHoaDonData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dtgv_HoaDon.CurrentRow == null) return;

            string maHD = dtgv_HoaDon.CurrentRow.Cells["sMaHD"].Value.ToString();

            SqlParameter[] parameters = {
                new SqlParameter("@sMaHD", maHD)
            };

            database.ExecuteNonQuery("DELETE FROM tblHoaDon WHERE sMaHD = @sMaHD", parameters);
            LoadHoaDonData();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            var keyword = txt_TimKiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
                txt_TimKiem.Focus();
                return;
            }

            dtgv_HoaDon.DataSource = database.ExecuteQuery("pr_TimKiemHoaDon",
                new[] { new SqlParameter("@keyword", keyword) },
                CommandType.StoredProcedure);
        }

        private void dtgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_HoaDon.Rows[e.RowIndex];
                cb_maNV.SelectedValue = row.Cells["sMaNV"].Value.ToString();
                cb_maKH.SelectedValue = row.Cells["sMaKH"].Value.ToString();
                dtp_ngayLap.Value = Convert.ToDateTime(row.Cells["dNgaylap"].Value);
                cb_trangThai.Text = row.Cells["sTrangthai"].Value.ToString();
            }
        }

        private void btn_XemCT_Click(object sender, EventArgs e)
        {
            if (dtgv_HoaDon.CurrentRow != null)
            {
                string sMaHD = dtgv_HoaDon.CurrentRow.Cells["sMaHD"].Value.ToString();
                ChiTietHoaDon frm = new ChiTietHoaDon(sMaHD);
                frm.ShowDialog();
            }
        }
    }
}
