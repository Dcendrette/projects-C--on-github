using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace teste_db
{
    public partial class Form1 : Form
    {
        Alunos_classe ManipularDados = new Alunos_classe();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Alunos_classe ClasseDeCriacaoDaConexao = new Alunos_classe();

            ClasseDeCriacaoDaConexao.AtualizarGrid(this.dataGridView_Alunos, "select * from Alunos");

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            // Conectar a base de dados 
            ManipularDados.Conectar();

            // Armar query (cadeia de dados);
            String Query = "insert into Aluno (Codigo,Nome,Sobrenome,Idade) values ('" + txtCodigo.Text + "' ,'" + txtNome.Text + "','" + txtSobrenome.Text + "'," + txtIdade.Text + ")";

            //Executar Query...
            ManipularDados.ExecutarSql(Query);

            // Desconectar 
            ManipularDados.Desconectar();

        }

    }
}
