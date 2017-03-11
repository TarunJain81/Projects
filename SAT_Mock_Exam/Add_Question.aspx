<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Add_Question.aspx.cs" Inherits="Add_Question" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox> <br />


        Enter multiple values separated by | <br />

         <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox> <br />

        Enter Correct Answer : 
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox> <br />

        Enter Level 
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox> <br />

        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click"/>
    
    </div>
    </form>
</body>
</html>
