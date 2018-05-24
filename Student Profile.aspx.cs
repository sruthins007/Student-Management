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
    public partial class Student_Profile : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["stud"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

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
                txtdob.Text = dt.Rows[0][5].ToString();
                txtage.Text = dt.Rows[0][6].ToString();
                txtmail.Text = dt.Rows[0][8].ToString();
                txtcourse.Text = dt.Rows[0][1].ToString();
            }

            SqlCommand sql1 = new SqlCommand("select * from tbl_contact where stud_id='" + hdempid.Value + "' ", con);
            SqlDataAdapter da1 = new SqlDataAdapter(sql1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {

                txtland.Text = dt1.Rows[0][1].ToString();
                txtmob1.Text = dt1.Rows[0][2].ToString();
                txtmob2.Text = dt1.Rows[0][3].ToString();
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No Data Found on Contact')", true);
            }
            SqlCommand sql2 = new SqlCommand("select * from tbl_address where stud_id='" + hdempid.Value + "' ", con);
            SqlDataAdapter da2 = new SqlDataAdapter(sql2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            if (dt2.Rows.Count > 0)
            {

                txthouse.Text = dt2.Rows[0][1].ToString();
                txtstreet.Text = dt2.Rows[0][2].ToString();
                txtdistrict.Text = dt2.Rows[0][3].ToString();
                txtstate.Text = dt2.Rows[0][4].ToString();
                txtpin.Text = dt2.Rows[0][5].ToString();
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No Data Found on Address')", true);
            }
            SqlCommand sql3 = new SqlCommand("select * from tbl_login where stud_id='" + hdempid.Value + "' ", con);
            SqlDataAdapter da3 = new SqlDataAdapter(sql3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            if (dt3.Rows.Count > 0)
            {

                txtusername.Text = dt3.Rows[0][1].ToString();
                txtpass.Text = dt3.Rows[0][2].ToString();
                
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No Data Found on login')", true);
            }
            con.Close();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "delete from tbl_stud where stud_id='" + hdempid.Value + "'";
            //Response.Write(sql);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            string sql1 = "delete from tbl_contact where stud_id='" + hdempid.Value + "'";
            //Response.Write(sql);
            SqlCommand cmd1 = new SqlCommand(sql1, con);
            cmd1.ExecuteNonQuery();

            string sql2 = "delete from tbl_address where stud_id='" + hdempid.Value + "'";
            //Response.Write(sql);
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            cmd2.ExecuteNonQuery();

            string sql3 = "delete from tbl_login where stud_id='" + hdempid.Value + "'";
            //Response.Write(sql);
            SqlCommand cmd3 = new SqlCommand(sql3, con);
            cmd3.ExecuteNonQuery();

            Response.Redirect("Student Profile.aspx");
            con.Close();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "update tbl_stud set age = '" + txtage.Text + "', email = '" + txtmail.Text + "'  where stud_id='" + hdempid.Value + "'"; // Updating tbl_stud
            //Response.Write(sql);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            string sql1 = "update tbl_contact set phno = '" + txtland.Text + "', mob1 = '" + txtmob1.Text + "', mob2 = '" + txtmob2.Text + "'  where stud_id='" + hdempid.Value + "'"; // Updating tbl_contact
            //Response.Write(sql);
            SqlCommand cmd1 = new SqlCommand(sql1, con);
            cmd1.ExecuteNonQuery();

            string sql2 = "update tbl_address set house = '" + txthouse.Text + "', street = '" + txtstreet.Text + "', district = '" + txtdistrict.Text + "', state = '" + txtstate.Text + "', pin = '" + txtpin.Text + "'  where stud_id='" + hdempid.Value + "'"; // Updating tbl_address
            //Response.Write(sql);
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            cmd2.ExecuteNonQuery();

            string sql3 = "update tbl_login set username = '" + txtusername.Text + "', password = '" + txtpass.Text + "'  where stud_id='" + hdempid.Value + "'"; // Updating tbl_login
            //Response.Write(sql);
            SqlCommand cmd3 = new SqlCommand(sql3, con);
            cmd3.ExecuteNonQuery();

            Response.Redirect("Student Profile.aspx");
            con.Close();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            txtage.ReadOnly = false;
   
            txtdistrict.ReadOnly = false;
            txtdob.ReadOnly = false;
            txthouse.ReadOnly = false;
            txtland.ReadOnly = false;
            txtmail.ReadOnly = false;
            txtmob1.ReadOnly = false;
            txtmob2.ReadOnly = false;
            txtusername.ReadOnly = false;
            txtpass.ReadOnly = false;
            txtpin.ReadOnly = false;
            txtstate.ReadOnly = false;
            txtstreet.ReadOnly = false;
        }
    }
}