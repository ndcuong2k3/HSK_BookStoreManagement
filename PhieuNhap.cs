using CrystalDecisions.CrystalReports.Engine;
using Microsoft.Office.Interop.Excel;
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
using DataTable = System.Data.DataTable;

namespace HSK_BookStoreManagement
{
    public partial class PhieuNhap : Form
    {
        DBHelper dBHelper = new DBHelper();
        public PhieuNhap()
        {
            InitializeComponent();
        }

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            dBHelper.FillComboBox(cb_TenNV, "Select sMaNV, sTenNV from tblNhanVien", "sTenNV", "sMaNV");
            dBHelper.FillComboBox(cb_TenDVSX, "Select sMaDV, sTenDV from tblDonViSanXuat", "sTenDV", "sMaDV");
            DataTable dt = dBHelper.ExecuteQuery("select * from vvPhieuNhap");
            dtgv_PhieuNhap.DataSource = dt;

            dtgv_PhieuNhap.Columns["sMaNV"].Visible = false;
            dtgv_PhieuNhap.Columns["sMaDV"].Visible = false;
        }



        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (cb_TenNV.SelectedIndex == -1 || cb_TenDVSX.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên và đơn vị sản xuất.");
                return;
            }

            if (dtp_ngayLap.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày nhập không hợp lệ.");
                return;
            }

            string maPN = GenerateMaPN();

            SqlParameter[] parameters = {
                new SqlParameter("@sMaPN", maPN),
                new SqlParameter("@sMaNV", cb_TenNV.SelectedValue),
                new SqlParameter("@sMaDV", cb_TenDVSX.SelectedValue),
                new SqlParameter("@dNgayNhap", dtp_ngayLap.Value),
                new SqlParameter("@sGhiChu", cbGhiChu.Text)
            };

            dBHelper.ExecuteNonQuery(@"
                 INSERT INTO tblPhieuNhap(sMaPN, sMaNV, sMaDV, dNgayNhap, sGhiChu)
                 VALUES (@sMaPN, @sMaNV, @sMaDV, @dNgayNhap, @sGhiChu)", parameters);

            MessageBox.Show("Thêm phiếu nhập thành công!");
            PhieuNhap_Load(sender, e);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dtgv_PhieuNhap.CurrentRow == null) return;

            string maPN = dtgv_PhieuNhap.CurrentRow.Cells["Mã phiếu nhập"].Value.ToString();

            SqlParameter[] parameters = {
                new SqlParameter("@sMaNV", cb_TenNV.SelectedValue),
                new SqlParameter("@sMaDV", cb_TenDVSX.SelectedValue),
                new SqlParameter("@dNgayNhap", dtp_ngayLap.Value),
                new SqlParameter("@sGhiChu", cbGhiChu.Text),
                new SqlParameter("@sMaPN", maPN)
             };

            dBHelper.ExecuteNonQuery(@"
                UPDATE tblPhieuNhap
                SET sMaNV = @sMaNV, sMaDV = @sMaDV, dNgayNhap = @dNgayNhap, sGhiChu = @sGhiChu
                WHERE sMaPN = @sMaPN", parameters);
            MessageBox.Show("Cập nhật phiếu nhập thành công!");
            PhieuNhap_Load(null, null);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dtgv_PhieuNhap.CurrentRow == null) return;

            string maPN = dtgv_PhieuNhap.CurrentRow.Cells["Mã phiếu nhập"].Value.ToString();

            if (MessageBox.Show("Bạn có chắc muốn xóa phiếu nhập này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlParameter[] parameters = {
                new SqlParameter("@sMaPN", maPN)
               };

                dBHelper.ExecuteNonQuery("DELETE FROM tblPhieuNhap WHERE sMaPN = @sMaPN", parameters);
                MessageBox.Show("Xóa thành công!");
                PhieuNhap_Load(null, null);
            }
        }
        private string GenerateMaPN()
        {
            int nextId = Convert.ToInt32(dBHelper.ExecuteScalar(@"
        SELECT ISNULL(MAX(CAST(SUBSTRING(sMaPN, 3, LEN(sMaPN)-2) AS INT)), 0) + 1 FROM tblPhieuNhap"));
            return "PN" + nextId.ToString().PadLeft(3, '0');
        }

        private void dtgv_PhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dtgv_PhieuNhap.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow row = dtgv_PhieuNhap.Rows[e.RowIndex];

                // Kiểm tra null trước khi truy cập
                if (row.Cells["sMaNV"].Value != null)
                    cb_TenNV.SelectedValue = row.Cells["sMaNV"].Value.ToString();

                if (row.Cells["sMaDV"].Value != null)
                    cb_TenDVSX.SelectedValue = row.Cells["sMaDV"].Value.ToString();

                if (row.Cells["Ngày nhập"].Value != null)
                    dtp_ngayLap.Value = Convert.ToDateTime(row.Cells["Ngày nhập"].Value);

                cbGhiChu.Text = row.Cells["Ghi chú"].Value?.ToString() ?? string.Empty;
            }

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string maPN = txt_TimKiem.Text.Trim();

            if (string.IsNullOrEmpty(maPN))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu nhập cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = $"SELECT * FROM vvPhieuNhap WHERE [Mã phiếu nhập] LIKE '%{maPN}%'";
                DataTable data = new DataTable();
                DataTable dt = dBHelper.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    dtgv_PhieuNhap.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu nhập nào với mã này.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgv_PhieuNhap.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm phiếu nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_XemCT_Click(object sender, EventArgs e)
        {
            if (dtgv_PhieuNhap.CurrentRow != null)
            {
                string sMaPN = dtgv_PhieuNhap.CurrentRow.Cells["Mã phiếu nhập"].Value.ToString();
                string sMaDV = dtgv_PhieuNhap.CurrentRow.Cells["sMaDV"].Value.ToString();
                ChiTietPhieuNhap pn = new ChiTietPhieuNhap(sMaPN, sMaDV);
                pn.ShowDialog();
            }
           
        }
    }
}
