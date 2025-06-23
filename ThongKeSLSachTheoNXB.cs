using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace HSK_BookStoreManagement
{
    public partial class ThongKeSLSachTheoNXB : Form
    {
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
            SqlDataAdapter da = new SqlDataAdapter("TK_Sach_NXB", @"Server=CUONG\MSSQLSERVER01;Database=BookStoreManagement;User Id=sa;Password=cuong;TrustServerCertificate=True;");
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);

            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
