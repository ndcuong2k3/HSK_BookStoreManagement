using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HSK_BookStoreManagement
{
    public partial class ChiTietPhieuNhap : Form
    {
        private string maPN;
        private string maDV;
        private DBHelper dBHelper = new DBHelper();

        public ChiTietPhieuNhap(string maPN, string maDV)
        {
            InitializeComponent();
            this.maPN = maPN;
            this.maDV = maDV;
        }

        private void ChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            HienThiChiTietPN();
            TinhTongPN();
        }

        private void LoadSanPham()
        {
            string sql = $"SELECT sMaSP, sTenSP FROM tblSanPham WHERE sMaDV = '{maDV}'";
            dBHelper.FillComboBox(cb_MaSP, sql, "sTenSP", "sMaSP");
        }


        private void HienThiChiTietPN()
        {
            SqlParameter[] parameters = { new SqlParameter("@MaPN", maPN) };
            DataTable dt = dBHelper.ExecuteQuery("pr_HienThiChiTietPN", parameters, CommandType.StoredProcedure);
            dBHelper.FillDataGridView(dtgv_ChiTietHD, dt);

            if (dtgv_ChiTietHD.Columns.Contains("Mã sản phẩm"))
                dtgv_ChiTietHD.Columns["Mã sản phẩm"].Visible = false;
        }

        private void TinhTongPN()
        {
            decimal tong = 0;
            foreach (DataGridViewRow row in dtgv_ChiTietHD.Rows)
            {
                if (row.Cells["Tổng tiền"].Value != DBNull.Value && row.Cells["Tổng tiền"].Value != null)
                {
                    tong += Convert.ToDecimal(row.Cells["Tổng tiền"].Value);
                }
            }
            lbl_TongHoaDon.Text = $"Tổng tiền nhập: {tong:N0} VNĐ";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (cb_MaSP.SelectedValue == null || string.IsNullOrWhiteSpace(txt_SoLuong.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm và nhập đầy đủ số lượng");
                return;
            }

            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@sMaPN", maPN),
                    new SqlParameter("@sMaSP", cb_MaSP.SelectedValue.ToString()),
                    new SqlParameter("@iSoLuong", int.Parse(txt_SoLuong.Text)),
                };

                dBHelper.ExecuteNonQuery("sp_ThemChiTietPhieuNhap", parameters, CommandType.StoredProcedure);
                HienThiChiTietPN();
                TinhTongPN();
                MessageBox.Show("Thêm chi tiết phiếu nhập thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (cb_MaSP.SelectedValue == null || string.IsNullOrWhiteSpace(txt_SoLuong.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm và nhập đầy đủ số lượng.");
                return;
            }

            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@sMaPN", maPN),
                    new SqlParameter("@sMaSP", cb_MaSP.SelectedValue.ToString()),
                    new SqlParameter("@iSoLuong", int.Parse(txt_SoLuong.Text)),
                };

                dBHelper.ExecuteNonQuery("pr_SuaChiTietPN", parameters, CommandType.StoredProcedure);
                HienThiChiTietPN();
                TinhTongPN();
                MessageBox.Show("Cập nhật chi tiết phiếu nhập thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (cb_MaSP.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này khỏi phiếu nhập?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@sMaPN", maPN),
                    new SqlParameter("@sMaSP", cb_MaSP.SelectedValue.ToString())
                };

                dBHelper.ExecuteNonQuery("pr_XoaChiTietPN", parameters, CommandType.StoredProcedure);
                HienThiChiTietPN();
                TinhTongPN();
                MessageBox.Show("Xóa chi tiết phiếu nhập thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message);
            }
        }

        private void dtgv_ChiTietPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dtgv_ChiTietHD.Rows[e.RowIndex].IsNewRow) return;

            var row = dtgv_ChiTietHD.Rows[e.RowIndex];

            cb_MaSP.SelectedValue = row.Cells["Mã sản phẩm"].Value?.ToString() ?? "";
            txt_SoLuong.Text = row.Cells["Số lượng"].Value?.ToString() ?? "";
        }
    }
}
