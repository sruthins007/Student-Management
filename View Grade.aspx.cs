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
    public partial class View_Grade : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["stud"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                con.Open();
                string id = Session["stud_id"].ToString();
                string com = "Select tbl_exam.exam_id,tbl_exam.exam_name,tbl_stud_exam_reg.exam_id from tbl_exam,tbl_stud_exam_reg where tbl_exam.exam_id=tbl_stud_exam_reg.exam_id and stud_id = '" + id + "' ";
                SqlDataAdapter adpt = new SqlDataAdapter(com, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                ddlexam.DataSource = dt;
                ddlexam.DataTextField = "exam_name";
                ddlexam.DataValueField = "exam_id";
                ddlexam.DataBind();
                con.Close();
            }
        }

        protected void ddlexam_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string id = Session["stud_id"].ToString();
            SqlCommand sql = new SqlCommand("select tbl_grade.grade_id,tbl_grade.grade_name,tbl_stud_grade.grade_id,tbl_stud_grade.exam_id from tbl_stud_grade,tbl_grade where tbl_grade.grade_id=tbl_stud_grade.grade_id and exam_id = '" + ddlexam.SelectedItem.Value + "' and stud_id= '" + id + "'   ", con);
            SqlDataAdapter da = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {              
                txtgrade.Text = dt.Rows[0][1].ToString();

            }
        }
    }
}