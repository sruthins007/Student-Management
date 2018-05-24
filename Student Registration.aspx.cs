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
    public partial class Student_Registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["stud"].ConnectionString);
        public string gender;      // Variable used for gender
        string SD;                 // Variable for photo upload
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                con.Open();
                string com = "Select course_id,course from tbl_course";
                SqlDataAdapter adpt = new SqlDataAdapter(com, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                ddlcourse.DataSource = dt;
                ddlcourse.DataTextField = "course";
                ddlcourse.DataValueField = "course";
                ddlcourse.DataBind();
                ddlcourse.Items.Insert(0, new ListItem("Select", "0"));
                con.Close();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            if (upld_photo.HasFile)
            {
                //string time = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");

                upld_photo.PostedFile.SaveAs(Server.MapPath("~/Images/") + "/" + upld_photo.FileName);
                SD = "~/ Images/" + upld_photo.FileName;

                // Response.Write(SD);
                if (male.Checked)
                {
                    gender = "M";
                }
                else if (female.Checked)
                {
                    gender = "F";
                }

                string file_name = upld_photo.FileName.ToString();



                string sql = "insert into tbl_stud (admission_no,course,first_name,last_name,dob,age,gender,email,image) values('" + txtadno.Text + "','" + ddlcourse.SelectedItem.Value + "','" + txtfname.Text + "','" + txtlname.Text + "','" + txtdob.Text + "','" + txtage.Text + "','" + gender + "','" + txtmail.Text + "','" + SD + "')";
                sql += "select @@IDENTITY";  // Used to take the current identity value from the table
                //Response.Write(sql);
                SqlDataAdapter adptt = new SqlDataAdapter(sql, con);
                SqlCommand cmd = new SqlCommand(sql, con);
                object obj = cmd.ExecuteScalar();
                int stud_id = Convert.ToInt16(obj);

                SqlCommand cmd1 = new SqlCommand("insert into tbl_address(stud_id,house,street,district,state,pin) values('" + stud_id + "','" + txthouse.Text + "','" + txtstreet.Text + "','" + txtdistrict.Text + "','" + txtstate.Text + "','" + txtpin.Text + "')");
                cmd1.Connection = con;
                cmd1.Parameters.Add("@stud_id", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("insert into tbl_contact(stud_id,phno,mob1,mob2) values('" + stud_id + "','" + txtland.Text + "','" + txtmob1.Text + "','" + txtmob2.Text + "')");
                cmd2.Connection = con;
                cmd2.Parameters.Add("@stud_id", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                cmd2.ExecuteNonQuery();

                SqlCommand cmd3 = new SqlCommand("insert into tbl_login(stud_id,username,password) values('" + stud_id + "','" + txtusername.Text + "','" + txtpass.Text + "')");
                cmd3.Connection = con;
                cmd3.Parameters.Add("@stud_id", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                cmd3.ExecuteNonQuery();

                string display = "Registration Successful ";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);  // Allert Box
                con.Close();

                Response.Redirect("Student Registration.aspx");
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Not Inserted";
            }

        }


    }
}