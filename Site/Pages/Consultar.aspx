<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consultar.aspx.cs" Inherits="Site.Pages.Consultar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Consulta</title>
    <link type="text/css" rel="stylesheet" href="../Content/bootstrap.css" />
</head>
    <script src="../Scripts/jquery-3.0.0.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
<body class="bg-primary">
    <form id="form1" runat="server">
        <div class="jumbotron-fluid p-3 mb-2 bg-light">
        <h3 class ="display-4 font-italic text-center">Consulta de Cliente</h3>
         <hr class="my-4" />
        <p class="font-italic text-center">Tabela de Clientes Cadastrados</p>
        </div>
        <div class="container-fluid">
                <asp:GridView 
                    ID="gridClientes" 
                    runat="server" 
                    CssClass="table table-hover table-dark" 
                    GridLines="None" 
                    AutoGenerateColumns="false"
                    >
                    <Columns> 
                        <asp:BoundField DataField="Codigo" HeaderText="Código"/>  
                        <asp:BoundField DataField="Nome" HeaderText="Nome"/>
                        <asp:BoundField DataField="Endereco" HeaderText="Endereço"/>
                        <asp:BoundField DataField="Email" HeaderText="Email"/>
                    </Columns>
                    <RowStyle CssClass="cursor-pointer" />
                </asp:GridView>
                <br/>
                 <asp:Label ID="lblMensagem" runat="server" class="alert alert-danger" role="alert" />
                 <a href="../Default.aspx" class="btn btn-secondary btn-lg" >Voltar</a>
        </div>
    </form>
</body>
</html>
