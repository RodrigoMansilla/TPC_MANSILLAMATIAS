using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AceesoDatos
{
    public abstract class ConnectionToSql
    {
        private readonly string connetion;

        public ConnectionToSql()
        {
            connetion = "data source= localhost\\SQLEXPRESS; initial catalog=MansillaRodrigo3_DB; integrated security=sspi";

        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connetion);

        }
    }
}
