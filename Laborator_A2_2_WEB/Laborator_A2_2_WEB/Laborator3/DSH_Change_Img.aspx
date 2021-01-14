<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DSH_Change_Img.aspx.cs" Inherits="Laborator_A2_2_WEB.Laborator3.DSH_Change_Img" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
       <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Marinela Hila"></asp:Label>
        <asp:TextBox ID="TextBox1" Text="20" TextMode="Number" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox2" Text="2000-02-18" TextMode="Date" runat="server"> </asp:TextBox>
        <asp:Panel ID="Panel1" runat="server">
            <asp:Image ID="Image2" runat="server" ImageUrl="~/Img/download.jpg" />

        </asp:Panel>

        <asp:CheckBox ID="CheckBox1" Text="Femer" runat="server" />
        <asp:CheckBox ID="CheckBox2" Text="Mashkull" runat="server" />
        <asp:Label ID="AfishimMesazhi" runat="server"></asp:Label>
           <br />
            <asp:Button ID="Button1" runat="server" Text="Ndrysho Imazh" OnClick="Button1_Click" />
    </form>
</body>
</html>
