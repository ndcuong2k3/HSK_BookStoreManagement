using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HSK_BookStoreManagement
{

    public partial class TrangChu : Form
    {
        private string MaNV;
        private string ChucVu;
        private DBHelper dBHelper = new DBHelper();
        public TrangChu(string ma)
        {
            InitializeComponent();
            MaNV = ma;
        }
        private void TrangChu_Load(object sender, EventArgs e)
        {
            string sql = "SELECT sTenNV, sChucVu FROM tblNhanVien WHERE sMaNV = @MaNV";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@MaNV", MaNV)
            };

            DataTable dt = dBHelper.ExecuteQuery(sql, parameters);

            if (dt.Rows.Count > 0)
            {
                txtTen.Text = dt.Rows[0]["sTenNV"].ToString();
                ChucVu = dt.Rows[0]["sChucVu"].ToString();
                txtChucVu.Text = ChucVu;
            }
            this.IsMdiContainer = true;
            if(ChucVu.Equals("Nhân viên") == true)
            {
                btnNhanVien.Enabled = false;
                nhânViênToolStripMenuItem.Visible = false;
            }
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
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan thongTinCaNhan = new ThongTinCaNhan(MaNV);
            thongTinCaNhan.MdiParent = this;
            groupBox2.Text = "Thông tin cá nhân";
            groupBox2.Controls.Add(thongTinCaNhan);
            thongTinCaNhan.Show();
        }
        private void btnNhaXuatBan_Click(object sender, EventArgs e)
        {
            NhaXuatBan nhaXuatBan = new NhaXuatBan();
            nhaXuatBan.MdiParent = this;
            groupBox2.Text = "Nhà xuất bản";
            groupBox2.Controls.Add(nhaXuatBan);
            nhaXuatBan.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.MdiParent = this;
            groupBox2.Text = "Nhân viên";
            groupBox2.Controls.Add(nhanVien);
            nhanVien.Show();
        }

        private void thốngKêSốLượngSáchTheoNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeSLSachTheoNXB thongKeSLSachTheoNXB = new ThongKeSLSachTheoNXB();
            thongKeSLSachTheoNXB.MdiParent = this;
            groupBox2.Text = "Thống kê số lượng sách theo nhà xuất bản";
            groupBox2.Controls.Add(thongKeSLSachTheoNXB);
            thongKeSLSachTheoNXB.Show();
        }
    }
}
