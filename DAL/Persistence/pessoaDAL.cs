using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DAL.Model;
//regras de negocio- consultas,select ,update ,insert, delete,obterporid
namespace DAL.Persistence
{
    public class PessoaDal : Conexao
    {
        //insert
        public void Gravar(Pessoa p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("insert into Pessoa(Nome,Endereco,Email)values(@v1,@v2,@v3)", Con);
                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Endereco);
                Cmd.Parameters.AddWithValue("@v3", p.Email);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Error ao Gravar Cliente: " + ex.Message);
            }
            finally
            {
                FecharConexoa();
            }
        }

        //Update
        public void Atualizar(Pessoa p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("update Pessoa set Nome=@v1,Endereco=@v2, Email=@v3 where Codigo= @v4 ", Con);
                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Endereco);
                Cmd.Parameters.AddWithValue("@v3", p.Email);
                Cmd.Parameters.AddWithValue("@v4", p.Codigo);
                Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Error ao Atualizar o Cliente:" + ex.Message);
            }
            finally
            {
                FecharConexoa();
            }
        }

        //Excluir
        public void Excluir(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("delete from Pessoa where Codigo = @v1 ", Con);
                Cmd.Parameters.AddWithValue("@v1", Codigo);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Error ao Excluir cliente: " + ex.Message);
            }
            finally
            {
                FecharConexoa();
            }
        }

        //Pesquisar
        public Pessoa PequisarPorCodigo(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("Select * from Pessoa where Codigo = @v1 ", Con);
                Cmd.Parameters.AddWithValue("@v1", Codigo);
                Dr = Cmd.ExecuteReader();
                Pessoa p = null;

                if (Dr.Read())
                {
                    p = new Pessoa();
                    p.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome = Convert.ToString(Dr["Nome"]);
                    p.Endereco = Convert.ToString(Dr["Endereco"]);
                    p.Email = Convert.ToString(Dr["Email"]);
                }
                return p;
            }
            catch (Exception ex)
            {

                throw new Exception("" + ex.Message);
            }
            finally
            {
                FecharConexoa();
            }
        }

        //Lista cadastros
        public List<Pessoa> Listar()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("Select * from Pessoa", Con);
                Dr = Cmd.ExecuteReader();
                List<Pessoa> lista = new List<Pessoa>();
                while (Dr.Read())
                {
                    Pessoa p = new Pessoa();
                    p.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome = Convert.ToString(Dr["Nome"]);
                    p.Endereco = Convert.ToString(Dr["Endereco"]);
                    p.Email = Convert.ToString(Dr["Email"]);

                    lista.Add(p);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Error ao Listar Cadastros: " + ex.Message);
            }
            finally
            {
                FecharConexoa();
            }
        }

    }

}
