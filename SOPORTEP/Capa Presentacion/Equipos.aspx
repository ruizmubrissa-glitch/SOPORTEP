<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Equipos.aspx.cs" Inherits="CapaPresentacion.Equipos" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gestión de Equipos</title>
    <link rel="stylesheet" type="text/css" href="/css/Estilos.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Mantenimiento de Equipos</h2>
            
            <div>
                <asp:Label ID="lblEquipoID" runat="server" Text="ID Equipo:"></asp:Label><br />
                <asp:TextBox ID="txtEquipoID" runat="server" ReadOnly="true"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblTipoEquipo" runat="server" Text="Tipo de Equipo:"></asp:Label><br />
                <asp:TextBox ID="txtTipoEquipo" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblModelo" runat="server" Text="Modelo:"></asp:Label><br />
                <asp:TextBox ID="txtModelo" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblUsuarioID" runat="server" Text="ID Usuario:"></asp:Label><br />
                <asp:TextBox ID="txtUsuarioID" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
            </div>
            <br />
            <asp:GridView ID="dgvEquipos" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="dgvEquipos_SelectedIndexChanged">
            </asp:GridView>
        </div>
    </form>
</body>
</html>