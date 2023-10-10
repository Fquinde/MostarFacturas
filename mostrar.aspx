<%@ Page Language="C#" AutoEventWireup="true" CodeFile="mostrar.aspx.cs" Inherits="mostrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">


<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Facturas</title>
</head>
<style>
    #mostrarfacturas {
        justify-content: center;
        display: flex;
    }
</style>
 

<body>
    <form id="form1" runat="server">
        <div  style="text-align:center"; >
            <h1 >Lista de Facturas</h1>
            <asp:GridView  H="table table-secondary table-bordered border-3 table-striped" ID="mostrarfacturas"  runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" >
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
            <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/datos/XMLFile.xml"></asp:XmlDataSource>
        </div>
    </form>
</body>
</html>