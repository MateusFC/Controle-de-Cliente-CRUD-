using System; 
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;
namespace Site.Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensagem.Visible = false;
        }
        protected void btnCadastrarCliente(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa();
                p.Nome = txtNome.Text;
                p.Endereco = txtEndereco.Text;
                p.Email = txtEmail.Text;

                PessoaDal d = new PessoaDal();

                d.Gravar(p);// gravando

                lblMensagem.Visible = true;
                lblMensagem.Text = "Cliente " + p.Nome + " Cadastrado com Sucesso!";
                txtNome.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtEmail.Text = string.Empty;


            }
            catch (Exception ex)
            {
                lblMensagem.Visible = true;
                lblMensagem.Text = ex.Message;
            }
        }
    }
}