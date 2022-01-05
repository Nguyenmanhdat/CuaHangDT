using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CuaHangDT
{
    internal class functionN
    {
        public static string tangkey(string sql, string tiento)
        {
            string key = tiento;
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, functions.con);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            if (table.Rows.Count <= 0)
            {
                key = tiento + "1";
            }
            else
            {
                string soma = table.Rows[0][0].ToString();
                key = key + soma;
            }
            return key;
        }
    }
}
