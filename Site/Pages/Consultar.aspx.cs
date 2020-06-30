using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Persistence;
using DAL.Model;
namespace Site.Pages
{
    public partial class Consultar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensagem.Visible = false;
            try
            {
                PessoaDal p = new PessoaDal();

                gridClientes.DataSource = p.Listar();//Popular
                gridClientes.DataBind();//Exibir
            }
            catch (Exception ex)
            {
                lblMensagem.Visible = true;
                lblMensagem.Text = "Error ao Consultar Cliente " + ex.Message; 
            }
        }
    }
}