using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DAL.Persistence
{
    public class Conexao
    {
        //atributos
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;

        //Metados
        protected void AbrirConexao()
        {
            try
            {
                //Connection String
                Con = new SqlConnection("Data Source=LAPTOP-F262UKQR\\SQLEXPRESS;Initial Catalog=CRUD;Integrated Security=True");
                Con.Open();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        protected void FecharConexoa()
        {
            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}

