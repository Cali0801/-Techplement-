using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace User_Registration
{
	public partial class Update : System.Web.UI.Page
	{
		OleDbConnection con;
		protected void Page_Load(object sender, EventArgs e)
		{
			con = new OleDbConnection("Provider=SQLOLEDB;Data Source=DESKTOP-F76TJN4\\SQLEXPRESS;Initial Catalog=Task-1;Integrated Security=SSPI");
			con.Open();
		}

		protected void btnUpdate_Click(object sender, EventArgs e)
		{
				// Get the current user's ID (assuming it's stored in a session variable)
				int userId = (int)Session["UserId"];

				// Update the user's data in the database
					OleDbCommand cmd = new OleDbCommand("UPDATE LoginRegistration SET Name = ?, Password = ?, Email = ? WHERE UserId = ?", con);
					cmd.Parameters.AddWithValue("", txtUsername.Text);
					cmd.Parameters.AddWithValue("", txtPassword.Text);
					cmd.Parameters.AddWithValue("", txtEmail.Text);
					cmd.Parameters.AddWithValue("", userId);
					cmd.ExecuteNonQuery();


			// Redirect to a success page or display a success message
			Label4.Text = "Updation Success!!!";

		}

		private string HashPassword(string password)
		{
			// Simple hashing algorithm (not recommended for production use)
			return password.GetHashCode().ToString();
		}
	}
}