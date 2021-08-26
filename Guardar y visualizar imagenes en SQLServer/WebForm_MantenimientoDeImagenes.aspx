<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm_MantenimientoDeImagenes.aspx.cs" Inherits="Guardar_y_visualizar_imagenes_en_SQLServer.WebForm_MantenimientoDeImagenes" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Guardar y visualizar imagenes en SQL Server</title>
    <link rel="stylesheet" type="text/css" href="Resources/css/imagenes.css" />
</head>
<body>
    <form id="formMantenimiento" runat="server">
        <div class="contenedor">
            <div class="row">
                <h1>Guardar, visualizar y lista imagenes en SQL Server</h1>
            </div>
            <div class="row">
                <div class="column left">Imagen:</div>
                <div class="column right"><asp:FileUpload ID="fuImagen" runat="server" /></div>
            </div>
            <div class="row">
                <asp:Button CssClass="btn btn-primary" ID="btnGuardar" OnClick="btnGuardar_Click" OnClientClick="return ValidarFormulario();" runat="server" Text="Guardar en SQL Server" />
            </div>
        </div>
        <div>
            <div class="row">
                <asp:Label CssClass="ok" ID="lblMensajeOk" runat="server"></asp:Label>
                <asp:Label CssClass="error" ID="lblMensajeError" runat="server"></asp:Label>
            </div>
            <div class="row"><br /></div>
        </div>
        <div class="contenedor">
            <asp:GridView CssClass="table-custom" ID="gvListaImagenes" AutoGenerateColumns="false" runat="server">
                <Columns>
                    <asp:BoundField HeaderText="ID" DataField="ID" />
                    <asp:HyperLinkField HeaderText="Url" Text="Ver" DataNavigateUrlFields="visorImagen" Target="_blank" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
    <script type="text/javascript" src="Resources/js/imagenes.js"></script>
</body>
</html>
