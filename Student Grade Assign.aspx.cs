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
    public partial class Student_Grade_Assign : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["stud"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                con.Open();
                string com = "Select grade_id,grade_name from tbl_grade";
                SqlDataAdapter adpt = new SqlDataAdapter(com, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                ddlgrade.DataSource = dt;
                ddlgrade.DataTextField = "grade_name";
                ddlgrade.DataValueField = "grade_id";
                ddlgrade.DataBind();
                ddlgrade.Items.Insert(0, new ListItem("Select", "0"));
                con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sql = new SqlCommand("select * from tbl_stud where first_name='" + txtname.Text.Trim() + "' or admission_no='" + txtname.Text.Trim() + "' ", con);
            SqlDataAdapter da = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                hdempid.Value = dt.Rows[0][0].ToString();
                txtcourse.Text = dt.Rows[0][1].ToString();
            }

            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No Data Found on login')", true);
            }
            
            string com = "Select tbl_exam.exam_id,tbl_exam.exam_name,tbl_stud_exam_reg.exam_id from tbl_exam,tbl_stud_exam_reg where tbl_exam.exam_id=tbl_stud_exam_reg.exam_id and stud_id = '" + hdempid.Value + "' ";
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dtt = new DataTable();
            adpt.Fill(dtt);
            ddlexam.DataSource = dtt;
            ddlexam.DataTextField = "exam_name";
            ddlexam.DataValueField = "exam_id";
            ddlexam.DataBind();
            ddlexam.Items.Insert(0, new ListItem("Select", "0"));
            
            con.Close();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            string com = "Select stud_id,exam_id from tbl_stud_grade where  stud_id= '" + hdempid.Value + "' and exam_id= '" + ddlexam.SelectedItem.Value + "' ";
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                string display = "Already Assigned ";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);

            }
            else
            {
                string sql = "insert into tbl_stud_grade (stud_id,exam_id,grade_id) values('" + hdempid.Value + "','" + ddlexam.SelectedItem.Value + "','" + ddlgrade.SelectedItem.Value + "')";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.ExecuteNonQuery();


                Response.Redirect("Student Grade Assign.aspx");
                string display = "Successfully Assigned ";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
                con.Close();
            }
        }
    }
}