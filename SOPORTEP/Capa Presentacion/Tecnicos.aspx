<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tecnicos.aspx.cs" Inherits="CapaPresentacion.Tecnicos" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gestión de Técnicos</title>
    <link rel="stylesheet" type="text/css" href="/css/Estilos.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Mantenimiento de Técnicos</h2>
            
            <div>
                <asp:Label ID="lblID" runat="server" Text="ID Técnico:"></asp:Label><br />
                <asp:TextBox ID="txtTecnicoID" runat="server" ReadOnly="true"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label><br />
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblEspecialidad" runat="server" Text="Especialidad:"></asp:Label><br />
                <asp:TextBox ID="txtEspecialidad" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
            </div>
            <br />
            <!-- Grilla para mostrar los datos -->
            <asp:GridView ID="dgvTecnicos" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="dgvTecnicos_SelectedIndexChanged">
            </asp:GridView>
        </div>
    </form>
</body>
</html>