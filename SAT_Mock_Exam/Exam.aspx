<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Exam.aspx.cs" Inherits="Exam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Unselect" OnClick="Button1_Click" /> &nbsp;
        <asp:Button ID="Button2" runat="server" Text="Next" OnClick="Button2_Click" /> &nbsp;
        <asp:Button ID="Button3" runat="server" Text="Submit" OnClick="Button3_Click" /> &nbsp; <br />
        <asp:HiddenField ID="QuizIdField" runat="server" />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label> <br />

        <asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList>

    </div>
    </form>
</body>
</html>
