using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace testes.Data_Access_Layer
{
    class ClienteDAL
    {
        SqlConnection conexao;

        public void Conectar(){

        SqlConnection conexao = new SqlConnection("Data Source=USER-PC\\SQLEXPRESS_DAN;Initial Catalog=Cadastro_cliente;Integrated Security=True");
            conexao.Open();
        }

        public void desconectar(){

            conexao.Close();
        }

        public void ExecutarComandoSQL(string comandoSQL)
        {
            SqlCommand comando = new SqlCommand( , conexao);

        
        }


    }
}
