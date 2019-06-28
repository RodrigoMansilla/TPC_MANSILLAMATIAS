<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AppWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="AppWeb.carritoTableAdapters.ProductosTableAdapter" UpdateMethod="Update">
            <DeleteParameters>
                <asp:Parameter Name="Original_Expr1" Type="Int32" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="IdCategoria" Type="Int32" />
                <asp:Parameter Name="IdMarca" Type="Int32" />
                <asp:Parameter Name="Stock" Type="Int32" />
                <asp:Parameter Name="PrecioVenta" Type="Decimal" />
                <asp:Parameter Name="Original_Expr1" Type="Int32" />
            </UpdateParameters>
        </asp:ObjectDataSource>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>hola<asp:DataList ID="DataList1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyField="Expr1" DataSourceID="ObjectDataSource2" GridLines="Both" OnItemCommand="DataList1_ItemCommand" RepeatColumns="2">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <ItemTemplate>
                    Expr1:
                    <asp:Label ID="Expr1Label" runat="server" Text='<%# Eval("Expr1") %>' />
                    <br />
                    Nombre:
                    <asp:Label ID="NombreLabel" runat="server" Text='<%# Eval("Nombre") %>' />
                    <br />
                    IdCategoria:
                    <asp:Label ID="IdCategoriaLabel" runat="server" Text='<%# Eval("IdCategoria") %>' />
                    <br />
                    IdMarca:
                    <asp:Label ID="IdMarcaLabel" runat="server" Text='<%# Eval("IdMarca") %>' />
                    <br />
                    Stock:
                    <asp:Label ID="StockLabel" runat="server" Text='<%# Eval("Stock") %>' />
                    <br />
                    PrecioVenta:
                    <asp:Label ID="PrecioVentaLabel" runat="server" Text='<%# Eval("PrecioVenta") %>' />
                    <br />
                    <asp:Button ID="btnañadir" runat="server" CommandName="selec" Text="sekeccionar" />
<br />
                </ItemTemplate>
                <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                </asp:DataList>
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DeleteMethod="Delete" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="AppWeb.carritoTableAdapters.ProductosTableAdapter" UpdateMethod="Update">
                    <DeleteParameters>
                        <asp:Parameter Name="Original_Expr1" Type="Int32" />
                    </DeleteParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="Expr1" Type="Int32" />
                        <asp:Parameter Name="Nombre" Type="String" />
                        <asp:Parameter Name="IdCategoria" Type="Int32" />
                        <asp:Parameter Name="IdMarca" Type="Int32" />
                        <asp:Parameter Name="Stock" Type="Int32" />
                        <asp:Parameter Name="PrecioVenta" Type="Decimal" />
                        <asp:Parameter Name="Original_Expr1" Type="Int32" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
            </h2>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
            <p>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Expr1" DataSourceID="ObjectDataSource1" OnRowDataBound="GridView1_RowDataBound">
                    <Columns>
                        <asp:BoundField DataField="Expr1" HeaderText="Expr1" ReadOnly="True" SortExpression="Expr1" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                        <asp:BoundField DataField="IdCategoria" HeaderText="IdCategoria" SortExpression="IdCategoria" />
                        <asp:BoundField DataField="IdMarca" HeaderText="IdMarca" SortExpression="IdMarca" />
                        <asp:BoundField DataField="Stock" HeaderText="Stock" SortExpression="Stock" />
                        <asp:BoundField DataField="PrecioVenta" HeaderText="PrecioVenta" SortExpression="PrecioVenta" />
                    </Columns>
                </asp:GridView>
            </p>
        </div>
    </div>

</asp:Content>
