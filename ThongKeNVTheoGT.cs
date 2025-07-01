using CrystalDecisions.CrystalReports.Engine;
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
    public partial class ThongKeNVTheoGT : Form
    {
        public ThongKeNVTheoGT()
        {
            InitializeComponent();
        }


        private void ThongKeNVTheoGT_Load(object sender, EventArgs e)
        {
            ReportDocument rpt = new ReportDocument();
            string path = System.IO.Path.Combine(Application.StartupPath, "D:\\HSK\\HSK_BookStoreManagement\\ThongKeNVtheoGT.rpt");
            rpt.Load(path);


            SqlDataAdapter da = new SqlDataAdapter("pr_ThongKeNhanVien_TheoGioiTinh", "Data Source=LAPTOP-H83FI4CJ\\SQLEXPRESS;Initial Catalog=BookStoreManagement;Integrated Security=True;Encrypt=False");
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);

            rpt.SetDataSource(dt);
            crpt_TKtheoGT.ReportSource = rpt;
        }
    }
}
