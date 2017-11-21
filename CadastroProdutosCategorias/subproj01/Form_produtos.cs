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


namespace subproj01
{
    public partial class Form_produtos : Form
    {
       // Form_produtos ManipularDados = new Form_produtos();

      
        private void Form_produtos_Load(object sender, EventArgs e)
        {
        }

        public void conectar() {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS_DAN;Initial Catalog=db_sistema;Integrated Security=True";
            con.Open();
        }


        public Form_produtos()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS_DAN;Initial Catalog=db_sistema;Integrated Security=True";
            con.Open();
           
            SqlCommand cmd = new SqlCommand("select * from tb_produto", con);

            

            SqlDataReader PR = cmd.ExecuteReader();

            BindingSource source = new BindingSource();

            source.DataSource = PR;

            dataGridView_form_produtos.DataSource = source;

            con.Close();
        }

        private void btn_cadastrar_form_produtos_Click(object sender, EventArgs e)
        {
           // ManipularDados.conectar();

            string Query = "insert into tb_produto (desc_produto, valor) values ( '"+ txt_produto.Text + "'," + txt_valor.Text + ");";
        }

        
    }
}
