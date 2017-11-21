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
    public partial class Form_categorias : Form
    {
        public Form_categorias()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS_DAN;Initial Catalog=db_sistema;Integrated Security=True";

            SqlCommand cmd = new SqlCommand("select * from tb_categoria", con);

            con.Open();

            SqlDataReader PR = cmd.ExecuteReader();

            BindingSource source = new BindingSource();

            source.DataSource = PR;

            dataGridView_form_categorias.DataSource = source;

            con.Close();

        }

        private void Form_categorias_Load(object sender, EventArgs e)
        {

        }
    }
}
