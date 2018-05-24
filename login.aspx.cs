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
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["stud"].ConnectionString);
        int RowCount,id;
        string UserName, Password;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select tbl_stud.admission_no,tbl_login.username,tbl_login.password,tbl_login.stud_id,tbl_stud.stud_id from tbl_stud,tbl_login where tbl_stud.stud_id=tbl_login.stud_id", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            RowCount = dt.Rows.Count;

            for (int i = 0; i < RowCount; i++)
            {

                UserName = dt.Rows[i]["username"].ToString();

                Password = dt.Rows[i]["password"].ToString();

                id = Int32.Parse(dt.Rows[i]["stud_id"].ToString());

                if(txtname.Text== "admin" && txtpass.Text== "admin")
                {
                    Response.Redirect("Staff Home.aspx");
                }
                else if (UserName == txtname.Text && Password == txtpass.Text)
                {
                    Session["stud_id"] = id;

                    Response.Redirect("Student Home.aspx");

                }

                else
                {

                    Label1.Text = "Invalid User Name or Password! Please try again!";

                }

            }
        }
    }
}