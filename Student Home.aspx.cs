using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Student
{
    public partial class Student_Home : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["stud"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "<b><font color=Brown>" + "WELLCOME : " + "</font>" + "<b><font color=red>" + Session["stud_id"] + "</font>";
        }
    }
}