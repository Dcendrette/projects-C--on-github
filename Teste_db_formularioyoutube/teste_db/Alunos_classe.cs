using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace teste_db
{
    class Alunos_classe {


        SqlConnection MinhaConexao;
       

        public void Conectar() {

        MinhaConexao = new SqlConnection("Data Source=USER-PC\\SQLEXPRESS_DAN;Initial Catalog=Registro_alunos;Integrated Security=True");
            MinhaConexao.Open();
        }


        public void Desconectar() {

            MinhaConexao.Close(); 
        }


        public void ExecutarSql(String Query)
        {

            SqlCommand MiComando = new SqlCommand(Query,MinhaConexao);

            //ejecutamos la consulta (query) sql...
            int FilasAfectadas = MiComando.ExecuteNonQuery();

            if (FilasAfectadas > 0)
                MessageBox.Show("Operación realizada exitosamente", "la base de datos ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else

                MessageBox.Show("No se pudo realizar la modificación de la base de datos :-(", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Criar datasource
        public void AtualizarGrid(DataGridView dg, String Query) {

            // Conectar a Base de Dados
            this.Conectar();

            // criar dataset
            System.Data.DataSet CacheMem = new System.Data.DataSet();


            // Criar adaptador de dados 
               SqlDataAdapter AdaptadorDB = new SqlDataAdapter(Query,MinhaConexao);

            // Preencher dataset
              AdaptadorDB.Fill(CacheMem,"Alunos");

            // Preencher o datagrid
              dg.DataSource = CacheMem;
              dg.DataMember = "Alunos";

              this.Desconectar();


         }

        }
}
