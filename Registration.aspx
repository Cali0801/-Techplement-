<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="User_Registration.Registration1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <link rel="icon" type="image/png" href="Images/1.png"/>
    <link href="Content/css/Registration.css" rel="stylesheet" />
    <meta charset="UTF-8"/>
    <title>Techplement Registration</title>
    
    <link href="Content/css/style.css" rel="stylesheet" />
     <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
</head>
<body>
   <div class="container">
   <!-- <img id="logo" class="logo" src="Images/1.png"/>-->
       <h1><center>TECHPLEMENT</center></h1>
    <div class="title">Sign Up Form</div>
    <div class="content">
      <form runat="server" action="#">
        <div class="user-details">
          <div class="input-box">
            <span class="details">Full Name</span>
            <asp:TextBox ID="name" runat="server" type="text" placeholder="Enter your name"/>
          </div>
            <div class="input-box">
            <span class="details">Password</span>
            <asp:TextBox ID="pass" runat="server" type="text" placeholder="Enter your Password"/>
          </div>
          <div class="input-box">
            <span class="details">Email</span>
           <asp:TextBox ID="email" runat="server" type="text" placeholder="Enter your Email"/>
          </div>
          <div class="input-box">
            <span class="details">Date of Birth</span>
             <asp:TextBox ID="date" runat="server" type="text" TextMode="Date" placeholder="Enter your Dob"/>
          </div>
		  <div class="input-box">
            <span class="details">Phone Number</span>
            <asp:TextBox ID="phone" runat="server" type="number" placeholder="Enter your number"/>
          </div>
         <!-- <div class="input-box">
            <span class="details">Role</span>
            <asp:DropDownList ID="role" runat="server" Width="640px" Height="50px" Font-Size="Large" Font-Bold="true" ForeColor="#3399ff" placeholder="Enter your role">
                <asp:ListItem Selected="True" Value="White"> Please Select your Role </asp:ListItem>
                  <asp:ListItem Value="warden"> Warden </asp:ListItem>
                  <asp:ListItem Value="student"> Student </asp:ListItem>
            </asp:DropDownList>
          </div>
         <div class="input-box">
            <span class="details">Hostel Id</span>
             <asp:DropDownList ID="roleid" runat="server" Width="300px" Height="45px" placeholder="Enter your role">
                <asp:ListItem Selected="True" Value="position"> Please Select your Role </asp:ListItem>
                  <asp:ListItem Value="h1"> Hostel-1 </asp:ListItem>
                  <asp:ListItem Value="h2"> Hostel-2 </asp:ListItem>
                 <asp:ListItem Value="h3">Hostel-3 </asp:ListItem>
                  <asp:ListItem Value="h4"> Hostel-4 </asp:ListItem>
                 <asp:ListItem Value="h5">Hostel-5 </asp:ListItem>
                  <asp:ListItem Value="h6"> Hostel-6 </asp:ListItem>
                 <asp:ListItem Value="h7"> Hostel-7 </asp:ListItem>
                  <asp:ListItem Value="h8"> Hostel-8 </asp:ListItem>
                 <asp:ListItem Value="h9"> Hostel-9 </asp:ListItem>
                  <asp:ListItem Value="h10"> Hostel-10 </asp:ListItem>
            </asp:DropDownList>
          </div>-->
        </div>
        <div class="gender-details">
          <input type="radio" name="gender" id="dot-1" value="Male"/>
          <input type="radio" name="gender" id="dot-2" value="Female"/>
          <input type="radio" name="gender" id="dot-3" value="Prefer not to say"/>
          <span class="gender-title">Gender</span>
          <div class="category">
            <label for="dot-1">
            <span class="dot one"></span>
            <span class="gender">Male</span>
          </label>
          <label for="dot-2">
            <span class="dot two"></span>
            <span class="gender">Female</span>
          </label>
		  <label for="dot-3">
            <span class="dot three"></span>
            <span class="gender">Prefer not to say</span>
            </label>
          </div>
        </div>
          <div class="input-box">
            <span class="details">Address</span>
            <asp:TextBox ID="add" runat="server" type="text" placeholder="Enter your address"/>
          </div>
        <div class="button">
         <asp:Button ID="regbutton" runat="server" type="submit" Text="Register" OnClick="Regbtn_click"/>
        </div>
          <asp:Label ID="Label3" runat="server" Font-Bold="true" Font-Size="X-Large"></asp:Label>	
      </form>
    </div>
  </div>
</body>
</html>
