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
    public partial class Exam_Registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["stud"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            if (txtexam.Text == string.Empty)
            {

                string display = "Exam Type Required";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
                return;
            }
            else if (txtmark.Text == string.Empty)
            {

                string display = "Total Mark required";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
                return;
            }
            else
            {
                string com = "Select exam_name from tbl_exam where exam_name ='" + txtexam.Text.Trim() + "' ";
                SqlDataAdapter adpt = new SqlDataAdapter(com, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    string display = "This Exam Type  already registered ";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);

                }
                else
                {
                    string sql = "insert into tbl_exam (exam_name,hr,mark) values('" + txtexam.Text.Trim() + "','" + ddlhr.SelectedItem.Value + "','" + txtmark.Text.Trim() + "')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

                    txtexam.Text = "";

                    ddlhr.ClearSelection();


                    Response.Redirect("Exam Registration.aspx");
                }
            }
        }
    }
}