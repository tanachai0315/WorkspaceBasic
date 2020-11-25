using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Workspace01
{
    class Connection
    {

        public static SqlConnection Strcon()
        {
            return new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=DB_Workspace;Integrated Security=True;");
        }

        public static DataTable SqlGet(string sqlcommand)
        {
            SqlConnection conn = Strcon();
            SqlDataAdapter da = new SqlDataAdapter(sqlcommand, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }

    }
}
