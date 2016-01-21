<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroCuentas.aspx.cs" Inherits="rCuentas22.RegistroCuentas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            width: 36px;
            margin-left: 34px;
        }
        #Text2 {
            width: 199px;
            margin-left: 14px;
        }
        #Text3 {
            width: 60px;
            margin-left: 8px;
        }
        #iCuentaId {
            margin-left: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <strong style="color: #003399">Registro de Cuentas Web </strong><p>
            CuentaId:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tbCuentaId" runat="server" Height="22px" MaxLength="4" style="margin-left: 3px"></asp:TextBox>
            <br />
            <br />
            Descripción:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbDescripcion" runat="server" MaxLength="100" style="text-align: center; margin-left: 0px" Width="121px"></asp:TextBox>
            <br />
            <br />
            Balance:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbBalance" runat="server" style="margin-left: 7px" MaxLength="9"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnBuscar" runat="server" OnClick="Button1_Click" Text="Buscar" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnGuardar" runat="server" OnClick="BtnGuardar_Click" Text="Guardar" BackColor="#00CC00" />
        &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEliminar" runat="server" BackColor="Red" OnClick="btnEliminar_Click" Text="Eliminar" />
&nbsp;
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
