using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;
using PropertyObject;


namespace BusineesObject
{
    public class RoleBusinessObject
    {
        RoleDataAccess roleobj = new RoleDataAccess();

        public bool SaveRoleDetails(RoleFields fields)
        {
            try
            {
                roleobj.insertcommand(fields._RoleName);

            }
            catch (Exception ex)
            {

                return false;
            }
            return true;
        }

        public bool ModiefiedRoleDetails(RoleFields fields)
        {
            try
            {
                roleobj.updatecommand(fields._RoleId,fields._RoleName, fields._IsRoleEnabled);
            }
            catch (Exception ex)
            {

                return false;
            }
            return true;
        }

        public bool IsRoleEnabled(RoleFields fields)
        {
            try
            {
                roleobj.updatecommand(fields._RoleId," ",fields._IsRoleEnabled);

            }
           catch (Exception ex)
            {

                return false;
            }
            return true;
        }

        public DataTable GetRoleDetails(int? id=0)
        {
            return null;

        }
    }
}
