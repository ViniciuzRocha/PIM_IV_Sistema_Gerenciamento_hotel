using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PIM_IV_CONEXAOBD
{
    public class ConexaoFonte
    {
        public SqlConnection GetConnection()
        {
            try
            {
                string connString = "Data Source=UNICO-PEBG739\\SQLEXPRESS;Initial Catalog=HOTEL_BD;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                if (conn == null || conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                return conn;
            }
            catch (SqlException err)
            {
                throw new System.Exception(err.Message);
            }
        }
    }
}
