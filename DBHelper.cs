using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace HSK_BookStoreManagement
{
    public class DBHelper
    {
        private readonly string connectionString = "Server=CUONG\\MSSQLSERVER01;Database=BookStoreManagement;User Id=sa;Password=cuong;TrustServerCertificate=True;";
        //private readonly string connectionString = "Data Source=LAPTOP-H83FI4CJ\\SQLEXPRESS;Initial Catalog=BookStoreManagement;Integrated Security=True;Encrypt=False";
        //private readonly string connectionString = "Data Source=LAPTOP-H83FI4CJ\\SQLEXPRESS;Initial Catalog=BookStoreManagement;Integrated Security=True;Encrypt=False";
        public String GetConnectionString()
        {
            return connectionString;
        }
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Thực thi câu lệnh SELECT trả về DataTable
        public DataTable ExecuteQuery(string sql, SqlParameter[] parameters = null, CommandType commandType = CommandType.Text)
        {
            DataTable dt = new DataTable();

            try
            {
                using (var connection = GetConnection())
                using (var command = new SqlCommand(sql, connection))
                {
                    command.CommandType = commandType;
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý hoặc log lỗi ở đây
                throw new Exception("Lỗi khi thực thi truy vấn: " + ex.Message);
            }

            return dt;
        }

        //Lấy dữ liệu từ bảng
        public DataTable GetTable(string tableName)
        {
            string sql = "Select * from " + tableName;
            using (var connection = GetConnection())
            {
                using (var command = new SqlCommand(sql, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        // Thực thi câu lệnh INSERT/UPDATE/DELETE trả về số bản ghi ảnh hưởng
        public int ExecuteNonQuery(string sql, SqlParameter[] parameters = null, CommandType commandType = CommandType.Text)
        {
            try
            {
                using (var connection = GetConnection())
                using (var command = new SqlCommand(sql, connection))
                {
                    command.CommandType = commandType;
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Xử lý hoặc log lỗi ở đây
                throw new Exception("Lỗi khi thực thi câu lệnh: " + ex.Message);
            }
        }

        // Thực thi câu lệnh trả về một giá trị duy nhất
        public object ExecuteScalar(string sql, SqlParameter[] parameters = null, CommandType commandType = CommandType.Text)
        {
            try
            {
                using (var connection = GetConnection())
                using (var command = new SqlCommand(sql, connection))
                {
                    command.CommandType = commandType;
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                // Xử lý hoặc log lỗi ở đây
                throw new Exception("Lỗi khi thực thi câu lệnh lấy giá trị: " + ex.Message);
            }
        }

        // Đổ dữ liệu vào ComboBox
        public void FillComboBox(ComboBox comboBox, string sql, string displayMember, string valueMember, SqlParameter[] parameters = null)
        {
            try
            {
                DataTable dt = ExecuteQuery(sql, parameters);

                comboBox.DataSource = dt;
                comboBox.DisplayMember = displayMember;
                comboBox.ValueMember = valueMember;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi đổ dữ liệu vào ComboBox: " + ex.Message);
            }
        }

        // Đổ dữ liệu vào DataGridView
        public void FillDataGridView(DataGridView dgv, DataTable dt)
        {
            try
            {
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi đổ dữ liệu vào DataGridView: " + ex.Message);
            }
        }


    }
}
