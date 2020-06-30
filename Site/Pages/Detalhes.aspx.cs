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
    public partial class Detalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlDados.Visible = false;
            lblMensagemErro.Visible = false;
            lblMensagem.Visible = false;
        }
        protected void btnPesquisarCliente(object sender, EventArgs e)
        {
            try
            {
                int Codigo = Convert.ToInt32(txtCodigo.Text);
                PessoaDal d = new PessoaDal();
                Pessoa p = d.PequisarPorCodigo(Codigo);

                if (p != null)
                {
                    pnlDados.Visible = true;
                    txtNome.Text = p.Nome;
                    txtEndereco.Text = p.Endereco;
                    txtEmail.Text = p.Email;
                }
                else
                {
                    lblMensagemErro.Text = " Cliente não Encontrado!";
                    txtCodigo.Text = string.Empty;
                }
                 
            }
            catch (Exception ex)
            {

                lblMensagemErro.Text = ex.Message;
            }
        }
        protected void btnExcluirCliente(object sender, EventArgs e)
        {
            try
            {
                int Codigo = Convert.ToInt32(txtCodigo.Text);
                Pessoa p    = new Pessoa();
                PessoaDal d = new PessoaDal();

                d.Excluir(Codigo);
                lblMensagem.Visible = true;
                lblMensagem.Text = "Cliente Excluido com Sucesso!";

                txtCodigo.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtEmail.Text = string.Empty;

            }
            catch (Exception ex)
            {

                lblMensagemErro.Text = ex.Message;
            }
        }
        protected void btnAtualizarCliente(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa();
                p.Codigo   = Convert.ToInt32(txtCodigo.Text);
                p.Nome     = Convert.ToString(txtNome.Text);
                p.Endereco = Convert.ToString(txtEndereco.Text);
                p.Email    = Convert.ToString(txtEmail.Text);

                PessoaDal d = new PessoaDal();
                d.Atualizar(p);
                lblMensagem.Visible= true;
                lblMensagem.Text = "Cliente "+ p.Nome +" Atualizado com Sucesso!!";
                
                txtCodigo.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtEmail.Text = string.Empty;
            }
            catch (Exception ex)
            {
                lblMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
        }
    }
}