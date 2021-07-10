<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Buscar_socio.aspx.vb" Inherits="Final_Labo4_pugno._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Buscar Socio: "></asp:Label>
        <asp:TextBox ID="txt_apellido" runat="server" AutoPostBack="True" 
            BorderStyle="Solid"></asp:TextBox>
        <asp:TextBox ID="txt_nombre" runat="server" AutoPostBack="True" 
            BorderStyle="Solid"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Buscar" />
    
    </div>
    <br />
    <asp:GridView ID="gv_busqueda" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="Blue" BorderStyle="None" BorderWidth="1px" 
        Visible="False">
        <Columns>
            <asp:BoundField DataField="nro_socio" HeaderText="Nro socio" ReadOnly="True" />
            <asp:BoundField DataField="Apellido y Nombre" HeaderText="Apellido y Nombre" />
            <asp:BoundField DataField="Parentezco" HeaderText="Parentezco" />
            <asp:BoundField DataField="Plan_os" HeaderText="Tipo de Plan" />
        </Columns>
    </asp:GridView>
    </form>
</body>
</html>
