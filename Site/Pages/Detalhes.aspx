<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="Site.Pages.Detalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Detalhes</title>
<link type="text/css" rel="stylesheet" href="../Content/bootstrap.css" />
</head>
    <script src="../Scripts/jquery-3.0.0.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
<body class="bg-primary">
    <form id="form1" runat="server">
         <div class="jumbotron-fluid p-3 mb-2 bg-light">
        <h3 class ="display-4 font-italic text-center">Detalhes</h3>
         <hr class="my-4" />
        <p class="font-italic text-center">Irá Pesuisar pelo Codigo do Cliente se vai Atualizar ou Deletar.</p>
        </div>
        <div class="container-fluid">
            <div class="form-group">
                <label class="text-white">Codigo do Cliente:</label><br />
                   <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Width="5%" /><br />
                    <asp:Button ID="btnPesquisa" runat="server" Text="Pesquisar" CssClass="btn btn-info btn-lg" OnClick="btnPesquisarCliente" />
                    <a href="../Default.aspx" class="btn btn-secondary btn-lg" >Voltar</a>
                    <br/>
            </div >
            <div class="form-group">
              <p>
                 <asp:Label ID="lblMensagemErro" runat="server" class="alert alert-danger" role="alert"/>
                  <asp:Label ID="lblMensagem" runat="server" class="alert alert-success" role="alert"/>
              </p>
                <br/>
              <asp:Panel ID="pnlDados" runat="server" >
                <div class="form-group">
               <label class="text-white">Nome do Cliente:</label> 
                <asp:TextBox ID="txtNome" runat="server"  CssClass="form-control" Width="45%" />
                </div>
                  <div class="form-group">
                    <label class="text-white">Endereço do Cliente:</label>
                    <asp:TextBox ID="txtEndereco" runat="server"  CssClass="form-control" Width="45%" />
                  </div>
                  <div class="form-group">
                    <label class="text-white">Email do Cliente:</label>
                    <asp:TextBox ID="txtEmail" runat="server"  CssClass="form-control" Width="30%" />
                  </div>
                <asp:Button ID="btnExcluir" runat="server" Text="Excluir" CssClass="btn btn-danger btn-lg" OnClick="btnExcluirCliente" />
                <asp:Button ID="bntAtualizar" runat="server" Text="Atualizar" CssClass="btn btn-warning btn-lg" OnClick="btnAtualizarCliente"  />                    
              </asp:Panel>
           </div>
        </div>
    </form>
</body>
</html>
