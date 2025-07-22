using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HSK_BookStoreManagement
{
    public partial class ChiTietHoaDon : Form
    {

        private string maHD;
        private string trangThai;
        private DBHelper database = new DBHelper();
        public ChiTietHoaDon(string sMaHD, string trangThai)
        {
            InitializeComponent();
            maHD = sMaHD;
            this.trangThai = trangThai;
            LoadSach();
            HienThiChiTiet();
            TinhTongHoaDon();
            if(trangThai.Equals("Đã thanh toán"))
            {
                btn_Them.Enabled = false;
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
            }
        }

        private void LoadSach()
        {
            string sql = "SELECT sMaSP, sTenSP FROM tblSanPham";
            database.FillComboBox(cb_MaSP, sql, "sTenSP", "sMaSP");
        }

        private void HienThiChiTiet()
        {
            SqlParameter[] parameters = { new SqlParameter("@MaHD", maHD) };
            DataTable dt = database.ExecuteQuery("pr_HienThiChiTietHD", parameters, CommandType.StoredProcedure);
            database.FillDataGridView(dtgv_ChiTietHD, dt);
        }

        private void TinhTongHoaDon()
        {
            decimal tong = 0;
            foreach (DataGridViewRow row in dtgv_ChiTietHD.Rows)
            {
                if (row.Cells["Tổng tiền"].Value != DBNull.Value)
                {
                    tong += Convert.ToDecimal(row.Cells["Tổng tiền"].Value);
                }
            }
            lbl_TongHoaDon.Text = $"Tổng hóa đơn: {tong:N0} VNĐ";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (cb_MaSP.SelectedValue == null || string.IsNullOrWhiteSpace(txt_SoLuong.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm và nhập số lượng.");
                return;
            }

            SqlParameter[] parameters = {
                new SqlParameter("@sMaHD", maHD),
                new SqlParameter("@sMaSP", cb_MaSP.SelectedValue.ToString()),
                new SqlParameter("@iSL", int.Parse(txt_SoLuong.Text))
            };

            database.ExecuteNonQuery("pr_ThemChiTietHD", parameters, CommandType.StoredProcedure);
            HienThiChiTiet();
            TinhTongHoaDon();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (cb_MaSP.SelectedValue == null || string.IsNullOrWhiteSpace(txt_SoLuong.Text))
            {
                MessageBox.Show("Vui lòng chọn sách và nhập số lượng.");
                return;
            }

            SqlParameter[] parameters = {
                new SqlParameter("@sMaHD", maHD),
                new SqlParameter("@sMaSach", cb_MaSP.SelectedValue.ToString()),
                new SqlParameter("@iSL", int.Parse(txt_SoLuong.Text))
            };

            database.ExecuteNonQuery("pr_SuaChiTietHD", parameters, CommandType.StoredProcedure);
            HienThiChiTiet();
            TinhTongHoaDon();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (cb_MaSP.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa.");
                return;
            }

            SqlParameter[] parameters = {
                new SqlParameter("@sMaHD", maHD),
                new SqlParameter("@sMaSach", cb_MaSP.SelectedValue.ToString())
            };

            database.ExecuteNonQuery("pr_XoaChiTietHD", parameters, CommandType.StoredProcedure);
            HienThiChiTiet();
            TinhTongHoaDon();
        }
    }
}
