<%@ Page Language="C#"  MasterPageFile="~/Site3.Master"  AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CentroAlumnos.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/estilo.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      <div>
     
        <form id="form1" class="formL" runat="server">
    <div>
    
        <asp:Login ID="Login1" runat="server" BackColor="#000" BorderColor="#F5D1A1" BorderPadding="5" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#F5D1A1">
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <LoginButtonStyle BackColor="#FE3F68" BorderColor="#FE3F68" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#F5D1A1" />
            <TextBoxStyle Font-Size="0.8em" />
            <TitleTextStyle  BackColor="#000" Font-Bold="True" Font-Size="0.9em" ForeColor="#FE3F68" />
        </asp:Login>
    
    </div>
    </form>
    

   
        </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div>
     
        <p  class="formC" runat="server">
   
            Bienvenido al sistema de votación electrónica de Centro de Alumnos
    
 
    </p>
    

   
        </div>

</asp:Content>


