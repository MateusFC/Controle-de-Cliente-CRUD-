<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Home</title>
    <link type="text/css" rel="stylesheet" href="content/bootstrap.css" />
</head>
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
<body class="p-3 mb-2 bg-primary">
 <div class="container">
    <div class="row">
      <div class="col-sm-9 col-md-7 col-lg-5 mx-auto">
        <div class="card card-signin my-5">
          <div class="card-body">
            <h1 class="card-title text-center">Controle de Clientes</h1>
            <form id="form1" class="form-signin" runat="server">
            <div class="form-label-group">
                <div class="form-label-group">
                    <h5 class="card-title text-center">Selecione a operação desejada</h5>
                </div>
                <br/>
                <div class="form-label-group text-center">
                    <asp:DropDownList ID="ddlMenu" runat="server" CssClass="form-control">
                        <asp:ListItem Value="0" Text="Escolha uma Opção" />
                        <asp:ListItem Value="1" Text="Cadastrar Cliente" />
                        <asp:ListItem Value="3" Text="Obter os Dados do Clientes" />
                        <asp:ListItem Value="2" Text="Consultar Cliente" />
                    </asp:DropDownList>
                           <br/>
                       </div>
                <br/>
                <asp:Button ID="btnMenu" runat="server" Text="Acessar" CssClass="btn btn-lg btn-primary btn-block text-uppercase" OnClick="bntAcessar" />
                <br />
                <div>
                    <asp:Label ID="lblMensagem" runat="server" CssClass="alert alert-danger" role="alert"/>
                </div>
                </div>
            </form>
          </div>
        </div>
      </div>
    </div>
  </div>   
</body>
</html>
<