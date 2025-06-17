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
    
    public partial class TrangChu : Form
    {
        private string MaNV;
        private DBHelper dBHelper = new DBHelper();
        public TrangChu(string ma)
        {
            InitializeComponent();
            MaNV = ma;
            Load();
        }

        public void Load()
        {
            string sql = "SELECT sTenNV, sChucVu FROM tblNhanVien WHERE sMaNV = @MaNV";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@MaNV", MaNV)
            };

            DataTable dt = dBHelper.ExecuteQuery(sql, parameters); // Gợi ý: dùng phương thức trả về DataTable

            if (dt.Rows.Count > 0)
            {
                txtTen.Text = dt.Rows[0]["sTenNV"].ToString();
                txtChucVu.Text = dt.Rows[0]["sChucVu"].ToString();
            }
            this.IsMdiContainer = true;
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox2.Controls)
            {
                control.Dispose();
            }
            Sach sach = new Sach();
            sach.MdiParent = this;
            groupBox2.Text = "Sách";
            groupBox2.Controls.Add(sach);
            sach.Show();
            sach.Dock = DockStyle.Fill;
        }
    }
}
