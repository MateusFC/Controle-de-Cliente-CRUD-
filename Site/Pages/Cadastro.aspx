<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site.Pages.Cadastro" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cadastro</title>
    <link type="text/css" rel="stylesheet" href="content/bootstrap.css" />
</head>
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
<body class="bg-primary">
    <form id="form1" runat="server">
         <div class="jumbotron-fluid p-3 mb-2 bg-light">
        <h3 class ="display-4 font-italic text-center">Cadastro de Cliente</h3>
         <hr class="my-4" />
        <p class="font-italic text-center">Preenchar os Campos com as Informações do Cliente</p>
        </div>
        <div class="container-fluid">
           <div class="form-group">
            <label class="text-white">Nome do Cliente:</label> <br />
                    <asp:TextBox ID="txtNome" runat="server" placeholder="Nome Completo" Width="45%" CssClass="form-control" />
                    <asp:RequiredFieldValidator  
                        ID="requiredNome" 
                        runat="server"
                        ControlToValidate="txtNome"
                        ErrorMessage="Por favor, digite seu nome."
                        ForeColor="Red"
                    />
            </div>
            <div class="form-group">
                   <label class="text-white">Endereço do Cliente:</label><br />
                    <asp:TextBox ID="txtEndereco" runat="server" placeholder="Endereço Residêncial" Width="50%" CssClass="form-control" />
                    <asp:RequiredFieldValidator  
                        ID="requiredEndereco" 
                        runat="server"
                        ControlToValidate="txtEndereco"
                        ErrorMessage="Por favor, digite seu Endereco."
                        ForeColor="Red"
                    />
            </div>
            <div class="form-group">
                    <label class="text-white">Email do Cliente:</label> <br />
                    <asp:TextBox ID="txtEmail" runat="server" placeholder="Email Válido" Width="25%" CssClass="form-control" />
                    <asp:RequiredFieldValidator  
                        ID="requiredEmail" 
                        runat="server"
                        ControlToValidate="txtEmail"
                        ErrorMessage="Por favor, digite seu Email."
                        ForeColor="Red"
                    />
            </div>
                    <p>
                        <asp:Label ID="lblMensagem" runat="server" class="alert alert-success" role="alert"/>
                    </p>
                    <asp:Button ID="btnCadastro" Text="Cadastrar" runat="server" CssClass="btn btn-success btn-lg" OnClick="btnCadastrarCliente" />
                    <a href="../Default.aspx" class="btn btn-secondary btn-lg" >Voltar</a>
        </div>
    </form>
</body>
</html>
