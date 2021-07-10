<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="resolucion_tramite.aspx.vb" Inherits="Final_Labo4_pugno.resolucion_tramite" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="gv_res_tramite" runat="server" BackColor="LightGoldenrodYellow" 
            BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" 
            GridLines="None" AutoGenerateColumns="False" Width="732px">
            <Columns>
                <asp:CheckBoxField HeaderText="CHECK" />
                <asp:BoundField DataField="Nro_tramite" HeaderText="Nro Tramite" />
                <asp:BoundField DataField="Apellido y Nombre" HeaderText="APELLIDO Y NOMBRE" />
                <asp:BoundField DataField="Plan Actual" HeaderText="PLAN ACTUAL" />
                <asp:BoundField DataField="Plan Solicitado" HeaderText="PLAN SOLICITADO" />
                <asp:BoundField DataField="Estado" HeaderText="ESTADO" />
            </Columns>
            <FooterStyle BackColor="Tan" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
                HorizontalAlign="Center" />
            <EmptyDataTemplate>
                <asp:CheckBox ID="CheckBox1" runat="server" />
            </EmptyDataTemplate>
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
        </asp:GridView>
    
    </div>
    <p>
        <asp:Button ID="btn_aplicar" runat="server" Text="Aplicar" />
    </p>
    </form>
</body>
</html>
