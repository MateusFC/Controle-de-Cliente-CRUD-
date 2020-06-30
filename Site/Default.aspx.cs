using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensagem.Visible = false;
        }
        protected void bntAcessar(object sender, EventArgs e)
        {
            string opcao = ddlMenu.SelectedValue;
            switch (opcao)
            {
                case "0":
                    lblMensagem.Text = "Por favor, selecione uma opção válida.";
                    lblMensagem.Visible = true;
                break;
                case "1":
                    Response.Redirect("/Pages/Cadastro.aspx");
                break;
                case "2":
                    Response.Redirect("/Pages/Consultar.aspx"); 
                break;
                case "3":
                    Response.Redirect("/Pages/Detalhes.aspx");
                    break;
            }
        }
    }
}