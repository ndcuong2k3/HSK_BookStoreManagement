using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HSK_BookStoreManagement
{
    public partial class NhaXuatBan : Form
    {
        DBHelper database = new DBHelper();

        public NhaXuatBan()
        {
            InitializeComponent();
        }

        private void NhaXuatBan_Load(object sender, EventArgs e)
        {
            DataTable dataTable = database.ExecuteQuery("SELECT * FROM tblNXB");
            dtgv_NXB.DataSource = dataTable;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string TenNXB = txt_tenNXB.Text;
            string DiaChi = txt_diaChi.Text;
            string SDT = txt_SDT.Text;

            string maNXB = (Convert.ToInt32(database.ExecuteScalar(
                "SELECT ISNULL(MAX(CAST(SUBSTRING(sMaNXB, 4, LEN(sMaNXB)-3) AS INT)), 0) FROM tblNXB")) + 1).ToString();
            maNXB = "NXB" + maNXB.PadLeft(3, '0');

            SqlParameter[] parameters = {
                new SqlParameter("@smaNXB", maNXB),
                new SqlParameter("@sten", TenNXB),
                new SqlParameter("@sdiachi", DiaChi),
                new SqlParameter("@sSDT", SDT)
            };

            database.ExecuteNonQuery("pr_ThemNXB", parameters, CommandType.StoredProcedure);
            NhaXuatBan_Load(sender, e);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dtgv_NXB.CurrentRow != null)
            {
                string maNXB = dtgv_NXB.CurrentRow.Cells["sMaNXB"].Value.ToString();

                SqlParameter[] parameters = {
                    new SqlParameter("@smaNXB", maNXB),
                    new SqlParameter("@sten", txt_tenNXB.Text),
                    new SqlParameter("@sdiachi", txt_diaChi.Text),
                    new SqlParameter("@sSDT", txt_SDT.Text)
                };

                database.ExecuteNonQuery("pr_SuaNXB", parameters, CommandType.StoredProcedure);
                NhaXuatBan_Load(sender, e);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dtgv_NXB.CurrentRow != null)
            {
                string maNXB = dtgv_NXB.CurrentRow.Cells["sMaNXB"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa NXB này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SqlParameter[] parameters = {
                        new SqlParameter("@imaNXB", maNXB)
                    };

                    database.ExecuteNonQuery("pr_XoaNXB", parameters, CommandType.StoredProcedure);
                    NhaXuatBan_Load(sender, e);
                }
            }
        }

        private void dtgv_NXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_NXB.Rows[e.RowIndex];
                txt_tenNXB.Text = row.Cells["sTenNXB"].Value.ToString();
                txt_diaChi.Text = row.Cells["sDiachi"].Value.ToString();
                txt_SDT.Text = row.Cells["sSDT"].Value.ToString();
            }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            string keyword = txt_TimKiem.Text.Trim();

            SqlParameter[] parameters = {
                new SqlParameter("@keyword", keyword)
            };

            DataTable dt = database.ExecuteQuery("pr_TimKiemNXB", parameters, CommandType.StoredProcedure);
            dtgv_NXB.DataSource = dt;
        }

        private void NhaXuatBan_Load_1(object sender, EventArgs e)
        {

        }
    }
}
