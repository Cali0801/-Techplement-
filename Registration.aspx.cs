using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Drawing;

namespace User_Registration
{
	public partial class Registration1 : System.Web.UI.Page
	{
		OleDbConnection con;
		protected void Page_Load(object sender, EventArgs e)
		{
			con = new OleDbConnection("Provider=SQLOLEDB;Data Source=DESKTOP-F76TJN4\\SQLEXPRESS;Initial Catalog=Task-1;Integrated Security=SSPI");
			con.Open();
		}
		protected void Regbtn_click(object sender, EventArgs e)
		{
			try
			{
				string nameValue = name.Text;
				string passValue = pass.Text;
				string emailValue = email.Text;
				string dateValue = date.Text;
				string phoneValue = phone.Text;
				string genderValue = Request.Form["gender"];
				string addressValue = add.Text;
				string insertQuery = "INSERT INTO LoginRegistration(Name, Password, Email, DOB, Phone, Gender, Address) VALUES (?, ?, ?, ?, ?, ?, ?)";
				using (OleDbCommand cmd = new OleDbCommand(insertQuery, con))
				{
					cmd.Parameters.AddWithValue("Name", nameValue);
					cmd.Parameters.AddWithValue("Password", passValue);
					cmd.Parameters.AddWithValue("Email", emailValue);
					cmd.Parameters.AddWithValue("DOB", dateValue);
					cmd.Parameters.AddWithValue("Phone", phoneValue);
					cmd.Parameters.AddWithValue("Gender", genderValue);
					cmd.Parameters.AddWithValue("Address",addressValue);

					int rowsAffected = cmd.ExecuteNonQuery();

					// Check if the query was successful
					if (rowsAffected > 0)
					{
						Response.Redirect("Success.aspx");
					}
					else
					{
						// There was an issue with the database insertion
					}
					int count = (int)cmd.ExecuteScalar();

					if (count > 0)
					{
						Label3.Text = "Username or email already exist. Please try again!";
						return;
					}
				}
				 
			}
			catch (Exception ex)
			{
				string msg = "Insert Error:";
				msg += ex.Message;
			}

			finally
			{
				con.Close();
			}

		}
	}
}