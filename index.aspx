<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="script/jquery-2.1.4.min.js"></script>
    <script src="script/controller.js"></script>
</head>
<body>
  <form id="form1" runat="server">
    
Select book:
    
   <asp:DropDownList ID="DropDownList1" runat="server" Width="150">
      <asp:ListItem Text="Select" Value="-1" />
   </asp:DropDownList>
    
   <br />
   <br />
    
   <table style="border: solid 1px black; width: 300px; display: none; background-color: #f3f3f3"
      cellpadding="4" cellspacing="0" id="outputTable">
      <tr>
         <td>Book ID:</td>
         <td><span id="bId" /></td>  
      </tr>
      <tr>
         <td>Book Title:</td>
         <td><span id="bTitle" /></td>
      </tr>
      <tr>
         <td>Book Author:</td>
         <td><span id="bAuth" /></td>
      </tr>
       <tr>
         <td>Book Price:</td>
         <td><span id="bPrice" /></td>
      </tr>
   </table>

</form>
</body>
</html>
