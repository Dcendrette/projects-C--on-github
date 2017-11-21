using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace sistema
{
    class conexaoSql
    {
        SqlConnection MinhaConexao;

        public void conectar()
        {
            MinhaConexao = new SqlConnection("Data Source=.\\SQLEXPRESS_DAN;Initial Catalog=db_sistema;Integrated Security=True");
            MinhaConexao.Open();

        }

        public void desconectar() 
        {
            MinhaConexao.Close();
        }



        public void executarSql(string Query)
        {
            SqlCommand ComandoSql = new SqlCommand(Query, MinhaConexao);

            int LinhasModificadas = ComandoSql.ExecuteNonQuery();

            if ( LinhasModificadas > 0) 

                MessageBox.Show("Realizado com Exito", "DB Modificada" , MessageBoxButtons.OK, MessageBoxIcon.Information);


            else MessageBox.Show(" Não Realizado", "DB Não Modificada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        public void AtualizarGrid(DataGridView dg, String Query)
        {
            this.conectar();

            System.Data.DataSet MeuDataSet = new System.Data.DataSet();

            SqlDataAdapter MeuAdaptadorDeDados = new SqlDataAdapter();

            MeuAdaptadorDeDados.Fill(MeuDataSet, "tb_produto");

            dg.DataSource = MeuDataSet;
            dg.DataMember = "td_produto";

            this.desconectar();
        }





    }
}
 