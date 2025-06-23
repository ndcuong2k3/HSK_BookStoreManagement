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
    public partial class ChiTietHoaDon : Form
    {

        private string maHD; // Mã hóa đơn nhận từ form Hóa đơn
        private DBHelper database = new DBHelper();
        public ChiTietHoaDon(string sMaHD)
        {
            InitializeComponent();
            maHD = sMaHD;
            LoadSach();
            HienThiChiTiet();
            TinhTongHoaDon();
        }

        private void LoadSach()
        {
            string sql = "SELECT sMasach, sTensach FROM tblSach";
            database.FillComboBox(cb_MaSach, sql, "sTensach", "sMasach");
        }

        private void HienThiChiTiet()
        {
            SqlParameter[] parameters = { new SqlParameter("@sMaHD", maHD) };
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
            if (cb_MaSach.SelectedValue == null || string.IsNullOrWhiteSpace(txt_SoLuong.Text))
            {
                MessageBox.Show("Vui lòng chọn sách và nhập số lượng.");
                return;
            }

            SqlParameter[] parameters = {
                new SqlParameter("@sMaHD", maHD),
                new SqlParameter("@sMaSach", cb_MaSach.SelectedValue.ToString()),
                new SqlParameter("@iSL", int.Parse(txt_SoLuong.Text))
            };

            database.ExecuteNonQuery("pr_ThemChiTietHD", parameters, CommandType.StoredProcedure);
            HienThiChiTiet();
            TinhTongHoaDon();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (cb_MaSach.SelectedValue == null || string.IsNullOrWhiteSpace(txt_SoLuong.Text))
            {
                MessageBox.Show("Vui lòng chọn sách và nhập số lượng.");
                return;
            }

            SqlParameter[] parameters = {
                new SqlParameter("@sMaHD", maHD),
                new SqlParameter("@sMaSach", cb_MaSach.SelectedValue.ToString()),
                new SqlParameter("@iSL", int.Parse(txt_SoLuong.Text))
            };

            database.ExecuteNonQuery("pr_SuaChiTietHD", parameters, CommandType.StoredProcedure);
            HienThiChiTiet();
            TinhTongHoaDon();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (cb_MaSach.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa.");
                return;
            }

            SqlParameter[] parameters = {
                new SqlParameter("@sMaHD", maHD),
                new SqlParameter("@sMaSach", cb_MaSach.SelectedValue.ToString())
            };

            database.ExecuteNonQuery("pr_XoaChiTietHD", parameters, CommandType.StoredProcedure);
            HienThiChiTiet();
            TinhTongHoaDon();
        }
    }
}
