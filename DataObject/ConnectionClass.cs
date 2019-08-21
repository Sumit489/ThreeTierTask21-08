using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObject
{
    public class ConnectionClass
    {
        protected SqlConnection _sqlconnection;
        protected SqlDataAdapter _sqldataadapter;
        protected DataTable _dt;
        protected SqlCommand _sqlcommand;

        public ConnectionClass()
        {
            _sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }
    }
}
