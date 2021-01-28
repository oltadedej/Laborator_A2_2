<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AfishoStudent.aspx.cs" Inherits="Laborator_A2_2_WEB.Laborator4.AfishoStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server"> Emri studentit</asp:Label>
            <asp:Label runat="server" ID="lblName"></asp:Label>
            <br />
            <asp:Label runat="server"> Mbiemri i studentit</asp:Label>
            <asp:Label runat="server" ID="lblSurname"></asp:Label>
            <br />
            <asp:Label runat="server"> Data e regjistrimit te studentit</asp:Label>
            <asp:Label runat="server" MaxLength="10" ID="lblEnrollmentDate"></asp:Label>
            <br />

        </div>
    </form>
</body>
</html>
