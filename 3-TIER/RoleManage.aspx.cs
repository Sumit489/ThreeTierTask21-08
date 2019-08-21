using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusineesObject;
using PropertyObject;

namespace _3_TIER
{
    public partial class RoleManage : System.Web.UI.Page
    {
        RoleBusinessObject rolebusinessobj = new RoleBusinessObject();
        RoleFields roleFields = new RoleFields();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            roleFields = new RoleFields();
            roleFields._RoleName = txtRoleDetails.Text;
            roleFields._IsRoleEnabled = chkEnabled.Checked;
            if(rolebusinessobj.SaveRoleDetails(roleFields))
            {
                lblMessage.InnerHtml = "<b style='color:green '> Role Details is saved! </b>";

            }
            else
            {
                lblMessage.InnerHtml = "<b style='color:red '> Role Details is not saved! </b>";
            }
            

        }
    }
}