using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace User_Registration
{
	public partial class Login : System.Web.UI.Page
	{

		OleDbConnection con;
		OleDbCommand cmd;
		OleDbDataReader dr;

		protected void Page_Load(object sender, EventArgs e)
		{
			con = new OleDbConnection("Provider=SQLOLEDB;Data Source=DESKTOP-F76TJN4\\SQLEXPRESS;Initial Catalog=Task-1;Integrated Security=SSPI");
		}
		protected void lbtn_click(object sender, EventArgs e)
		{
			try
			{
				string username = lname.Text.Trim();
				string password = lpass.Text.Trim();
				con.Open();

				OleDbCommand cmd = new OleDbCommand("SELECT * FROM LoginRegistration WHERE Name ='" + username + "' AND Password ='" + password + "'", con);
				dr = cmd.ExecuteReader();

				if (dr.Read())
				{
					Response.Redirect("Welcome.aspx");
				}
				else
				{
					Label4.Text = "Invalid Username or Password";
				}
			}

			catch (Exception ex)
			{
				Response.Write(ex.Message);
			}
			con.Close();
		}

		protected void btnsign(object sender, EventArgs e)
		{
			Response.Redirect("Registration.aspx");
		}

	}
}