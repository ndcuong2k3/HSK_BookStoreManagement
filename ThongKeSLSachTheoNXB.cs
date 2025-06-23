using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace HSK_BookStoreManagement
{
    public partial class ThongKeSLSachTheoNXB : Form
    {
        private DBHelper db = new DBHelper();
        public ThongKeSLSachTheoNXB()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportDocument rpt = new ReportDocument();
            //string path = System.IO.Path.Combine(Application.StartupPath, "CR_ThongKeSLSachTheoNXB.rpt");
           // rpt.Load(path);
            rpt.Load("CR_ThongKeSLSachTheoNXB.rpt");
            DataTable dt = db.ExecuteQuery("TK_Sach_NXB", null, CommandType.StoredProcedure);

            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
