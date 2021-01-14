<%@ Page Language="C#" AutoEventWireup="true" UnobtrusiveValidationMode="None" CodeBehind="MenaxhoRecordePhoneBook.aspx.cs" Inherits="Laborator_A2_2_WEB.Laborator3.MenaxhoRecordePhoneBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server"> PhoneBookRecords </asp:Label> <br/>
            <asp:DropDownList ID="ddl" runat="server"></asp:DropDownList>

            <br />
            <asp:Panel runat="server" ID="pnlshto">
                <asp:Label runat="server" Text="PhoneBookPersonaName:"></asp:Label>
                <asp:TextBox ID="txtPersonName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="txtrqfield" runat="server"  ValidationGroup="shtoRecord" ControlToValidate="txtPersonName" 
                    ErrorMessage="Ju lutem plotesoni emrin e phonebookpersonname" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                 <asp:Label runat="server" Text="PhoneBookNumber:"></asp:Label>
                <asp:TextBox ID="txtPhoneBookNumber" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="txtnumberrqfield" ValidationGroup="shtoRecord" runat="server"  ControlToValidate="txtPhoneBookNumber" 
                    ErrorMessage="Ju lutem plotesoni numrin e telefonit" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator runat="server" ID="regular1" ControlToValidate="txtPhoneBookNumber"
                     ErrorMessage="Ju lutem specifikoni nr ne formatin e duhur"
                     Display="Dynamic" ForeColor="Red" ValidationGroup="shtoRecord" ValidationExpression="^[+]{1}[0-9]{10}$"
                    ></asp:RegularExpressionValidator>
                
                <%-- ^ --> tregon fillimin e shprehjes se rregullt 
                    [] --> tregojne elementin ose nje bashkesi elementesh
                    {} --> tregojn nr e hereve qe elementet ne kllapa [] perseriten
                    [0-9] --> tregojne nje bashkesi elementesh (0,1,2,3,4,5,6,7,8,9)
                    {} -->tregojn nr e hereve qe elementet ne kllapa [] perseriten
                    $ --> perfundimin e shprehjes se rregullt
                    +1234567890
                    --%>
                
                <br />
                  <asp:Label runat="server" Text="PhoneBookType:"></asp:Label>
                <asp:RadioButtonList ID="rdlPhoneType" runat="server">
                    <asp:ListItem Value=""> Zgjidhni tipin e nr te telefonit</asp:ListItem>
                    <asp:ListItem Value="1"> Celular</asp:ListItem>
                    <asp:ListItem Value="2"> Work</asp:ListItem>
                    <asp:ListItem Value="3"> Home</asp:ListItem>
                </asp:RadioButtonList>
                <asp:RequiredFieldValidator ID="rdlrequeired" runat="server"  ControlToValidate="rdlPhoneType" 
                 InitialValue=""  ErrorMessage="Ju lutem zgjidhni tipin e  numrit e telefonit" ValidationGroup="shtoRecord" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:Button ID="shto" Text="Shto record" ValidationGroup="shtoRecord"  OnClick="shto_Click"  runat="server" />

            </asp:Panel>
            <br />
            <br />

            <asp:Panel ID="pnlfshi" runat="server">

                   <asp:Button ID="fshiBtn" Text="Fshi record"  OnClick="fshiBtn_Click"  runat="server" />

           




            </asp:Panel>






        </div>
    </form>
</body>
</html>
