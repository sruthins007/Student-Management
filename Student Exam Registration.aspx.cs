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
    public partial class Student_Exam_Registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["stud"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                con.Open();
                string com = "Select exam_id,exam_name from tbl_exam";
                SqlDataAdapter adpt = new SqlDataAdapter(com, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                ddlexam.DataSource = dt;
                ddlexam.DataTextField = "exam_name";
                ddlexam.DataValueField = "exam_id";
                ddlexam.DataBind();
                ddlexam.Items.Insert(0, new ListItem("Select", "0"));
                con.Close();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            string com = "Select exam_id,stud_id from tbl_stud_exam_reg where  stud_id= '" + Session["stud_id"] + "' and exam_id= '" + ddlexam.SelectedItem.Value + "' ";
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                string display = "Already Registered ";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);

            }
            else
            {
                string sql = "insert into tbl_stud_exam_reg(stud_id,exam_id) values('" + Session["stud_id"] + "','" + ddlexam.SelectedItem.Value + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                Response.Redirect("Student Exam Registration.aspx");
            }
        }
    }
}