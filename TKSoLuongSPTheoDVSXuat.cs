using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data;
using System.Windows.Forms;

namespace HSK_BookStoreManagement
{
    public partial class TKSoLuongSPTheoDVSXuat : Form
    {
        DBHelper dbHelper = new DBHelper(); 
        public TKSoLuongSPTheoDVSXuat()
        {
            InitializeComponent();
        }

        private void TKSoLuongSPTheoDVSXuat_Load(object sender, EventArgs e)
        {
            ReportDocument rpt = new ReportDocument();

            rpt.Load("TKSoLuongSPTheoDVSX.rpt");
            DataTable dt = dbHelper.ExecuteQuery("prThongKeSLSanPhamTheoDVSX", null, CommandType.StoredProcedure);

            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
