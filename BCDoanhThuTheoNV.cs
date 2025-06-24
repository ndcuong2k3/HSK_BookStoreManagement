using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSK_BookStoreManagement
{
    public partial class BCDoanhThuTheoNV : Form
    {
        DBHelper dbHelper = new DBHelper();
        public BCDoanhThuTheoNV()
        {
            InitializeComponent();
        }

        private void BCDoanhThuTheoNV_Load(object sender, EventArgs e)
        {
            ReportDocument rpt = new ReportDocument();

            rpt.Load("BaoCaoDoanhThuTheoNV.rpt");
            DataTable dt = dbHelper.ExecuteQuery("BaoCao_DoanhThuTheoNhanVien", null, CommandType.StoredProcedure);

            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
