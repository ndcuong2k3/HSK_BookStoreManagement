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
        private string GioiTinh;
        private DBHelper dBHelper = new DBHelper();
        public TrangChu(string ma)
        {
            InitializeComponent();
            MaNV = ma;
        }
        private void TrangChu_Load(object sender, EventArgs e)
        {
            string sql = "SELECT sTenNV, sChucVu, sGioitinh FROM tblNhanVien WHERE sMaNV = @MaNV";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@MaNV", MaNV)
            };

            DataTable dt = dBHelper.ExecuteQuery(sql, parameters);

            if (dt.Rows.Count > 0)
            {
                txtTen.Text = dt.Rows[0]["sTenNV"].ToString();
                ChucVu = dt.Rows[0]["sChucVu"].ToString();
                GioiTinh = dt.Rows[0]["sGioitinh"].ToString();
                txtChucVu.Text = ChucVu;
            }
            this.IsMdiContainer = true;
            if(ChucVu.Equals("Nhân viên") == true)
            {
                btnNhanVien.Enabled = false;
                nhânViênToolStripMenuItem.Visible = false;
            }
            if (GioiTinh.Equals("Nữ")){
                pictureBox1.Image = Properties.Resources.female_icon_resizedpng;
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
            ThongTinCaNhan thongTinCaNhan = new ThongTinCaNhan(MaNV, GioiTinh);
            thongTinCaNhan.MdiParent = this;
            groupBox2.Text = "Thông tin cá nhân";
            groupBox2.Controls.Add(thongTinCaNhan);
            thongTinCaNhan.Show();
        }
        private void btnNhaXuatBan_Click(object sender, EventArgs e)
        {
            DonViSanXuat nhaXuatBan = new DonViSanXuat();
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

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.MdiParent = this;
            groupBox2.Text = "Quản lý khách hàng";
            groupBox2.Controls.Add(kh);
            kh.Show();  
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnKhachHang_Click(sender, e);
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSach_Click(sender, e);
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnHoadon_Click(sender, e);
        }
         
        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnNhaXuatBan_Click(sender, e);
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnNhanVien_Click(sender, e);
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.MdiParent = this;
            groupBox2.Text = "Quản lý hóa đơn";
            groupBox2.Controls.Add(hd);
            hd.Show();
        }

        private void báoCáoDoanhThuTheoNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BCDoanhThuTheoNV bC = new BCDoanhThuTheoNV();
            bC.MdiParent = this;
            groupBox2.Text = "Báo cáo doanh thu theo nhân viên";
            groupBox2.Controls.Add(bC);
            bC.Show();
        }

        private void thốngKêSốLượngNhânViênTheoGiớiTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeNVTheoGT bC = new ThongKeNVTheoGT();
            bC.MdiParent = this;
            groupBox2.Text = "Thống kê số lượng nhân viên theo giới tính";
            groupBox2.Controls.Add(bC);
            bC.Show();
        }

        private void vởToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnVo_Click(sender, e);
        }

        private void bútToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBut_Click(sender, e);
        }

        private void btnVo_Click(object sender, EventArgs e)
        {
            Vo bC = new Vo();
            bC.MdiParent = this;
            groupBox2.Text = "Quản lý vở";
            groupBox2.Controls.Add(bC);
            bC.Show();
        }

        private void btnBut_Click(object sender, EventArgs e)
        {
            But bC = new But();
            bC.MdiParent = this;
            groupBox2.Text = "Quản lý bút";
            groupBox2.Controls.Add(bC);
            bC.Show();
        }
    }
}
