using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace FamilyManager.Model
{
    public class SQLDatabaseConnect 
    {

        #region Field

        public static SqlConnection connect;

        #endregion

        #region public methods 
        public void ConnectDataBase()
        {
            // implement the logic of code here.
        }

        public SqlCommand Query(string sqlQuery)
        {
            SqlCommand Command = new SqlCommand(sqlQuery, connect);
            return Command;
        }
        #endregion

    }
}
