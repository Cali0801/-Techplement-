﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace User_Registration
{
	public partial class Success : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}
		protected void cont(object sender, EventArgs e) 
		{
				Response.Redirect("Login.aspx");
			
		}
	}
}