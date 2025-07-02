using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data;
using System.Windows.Forms;

namespace HSK_BookStoreManagement
{
    public partial class ThongKeNVTheoGT : Form
    {
       DBHelper dbHelper= new DBHelper();
        public ThongKeNVTheoGT()
        {
            InitializeComponent();
        }


        private void ThongKeNVTheoGT_Load(object sender, EventArgs e)
        {
            ReportDocument rpt = new ReportDocument();
           
            rpt.Load("ThongKeNVtheoGT.rpt");

            DataTable dt = dbHelper.ExecuteQuery("pr_ThongKeNhanVien_TheoGioiTinh", null, CommandType.StoredProcedure);
            rpt.SetDataSource(dt);
            crpt_TKtheoGT.ReportSource = rpt;
        }

        private void crpt_TKtheoGT_Load(object sender, EventArgs e)
        {

        }
    }
}
