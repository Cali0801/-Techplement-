<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Success.aspx.cs" Inherits="User_Registration.Success" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Success</title>
    <link href="Content/css/success.css" rel="stylesheet" />
</head>
<body>
    <form runat="server" action="#">
    <div id='card' class="animated fadeIn">
  <div id='upper-side'>
   <i class="fa fa-check"></i>
   <h3 id='status'> Success </h3> 
</div>
  <div id='lower-side'>
    <p id='message'>
      Congratulations, your account has been successfully created.
    </p>
      <asp:Button ID="contBtn" runat="server" type="submit" Text="Continue to Login" OnClick="cont"/>
   <!-- <a href="#" id="contBtn">Continue</a>-->
  </div>
</div>
</form>
</body>
</html>
