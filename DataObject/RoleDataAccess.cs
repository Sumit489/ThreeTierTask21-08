using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObject
{
    public class RoleDataAccess:ConnectionClass
    {
        public void insertcommand(string rolename,bool isEnabled= true)
        {
            _sqlconnection.Open();
            _sqlcommand = new System.Data.SqlClient.SqlCommand("sp_RoleInsert", _sqlconnection);

            _sqlcommand.Parameters.AddWithValue("@roleName", rolename);
            _sqlcommand.Parameters.AddWithValue("@isEnabled", isEnabled);
            _sqlcommand.CommandType = System.Data.CommandType.StoredProcedure;
            _sqlcommand.ExecuteNonQuery();
            _sqlconnection.Close();

        }
        public void updatecommand(int roleId,string roleName = " ", bool isEnabled = true)
        {
            _sqlconnection.Open();
            _sqlcommand = new System.Data.SqlClient.SqlCommand("sp_RoleUpdate", _sqlconnection);

            _sqlcommand.Parameters.AddWithValue("@roleName", roleName);
            _sqlcommand.Parameters.AddWithValue("@isEnabled", isEnabled);
            _sqlcommand.Parameters.AddWithValue("@roleid", roleId);
            _sqlcommand.CommandType = System.Data.CommandType.StoredProcedure;
            _sqlcommand.ExecuteNonQuery();
            _sqlconnection.Close();

        }

        public void deleteCommand(int roleId)
        {
            _sqlconnection.Open();
            _sqlcommand = new System.Data.SqlClient.SqlCommand("sp_RoleUpdate", _sqlconnection);

            
            _sqlcommand.Parameters.AddWithValue("@roleId", roleId);
        
            _sqlcommand.CommandType = System.Data.CommandType.StoredProcedure;
            _sqlcommand.ExecuteNonQuery();
            _sqlconnection.Close();

        }
    }
}
