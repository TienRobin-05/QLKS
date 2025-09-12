using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QLKS
{
    internal class DbHandle
    {

        private SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=QLKS;Integrated Security=True");
        public DbHandle() {
            
        }

        public void Command(string sql) {
            

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi kết nối: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
        public DataTable GetData(string sql)
        {
            try
            {
                var adapter = new SqlDataAdapter(sql, connection);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi kết nối: " + ex.Message);
                return new DataTable();
            }
        }
    }
}
