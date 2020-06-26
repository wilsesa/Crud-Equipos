<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CRUDEquipos._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h1>CRUD Equipos</h1>

        <asp:Label ID="lblId" runat="server" Text="Id"></asp:Label>
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        <br />
        <br />

        <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <br />

        <asp:Label ID="lblEstado" runat="server" Text="Estado"></asp:Label>
        <asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
        <asp:Button ID="btnCrear" runat="server" OnClick="btnCrear_Click" Text="Crear" />
        <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" />
        <asp:Button ID="btnExcluir" runat="server" OnClick="btnExcluir_Click" Text="Excluir" />
        <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
        <br />
        <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:GridView ID="tablaEquipos" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" DataSourceID="dsEquipos">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <asp:SqlDataSource ID="dsEquipos" runat="server" ConnectionString="<%$ ConnectionStrings:fnstoreConnectionString %>" DeleteCommand="DELETE FROM [equipo] WHERE [id] = @id" InsertCommand="INSERT INTO [equipo] ([id], [nombre], [estado]) VALUES (@id, @nombre, @estado)" SelectCommand="SELECT [id], [nombre], [estado] FROM [equipo]" UpdateCommand="UPDATE [equipo] SET [nombre] = @nombre, [estado] = @estado WHERE [id] = @id">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="id" Type="Int32" />
                <asp:Parameter Name="nombre" Type="String" />
                <asp:Parameter Name="estado" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="nombre" Type="String" />
                <asp:Parameter Name="estado" Type="String" />
                <asp:Parameter Name="id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
    </div>




</asp:Content>
