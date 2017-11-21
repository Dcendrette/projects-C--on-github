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


namespace ComunicacaoSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=USER-PC\\SQLEXPRESS_DAN;Initial Catalog=escuela;Integrated Security=True";

            SqlCommand cmd = new SqlCommand("select * from alumno" , con);

            con.Open();

            SqlDataReader DR = cmd.ExecuteReader();

            BindingSource source = new BindingSource();

            source.DataSource = DR;

            dataGridView1.DataSource = source;

            con.Close();


        }
    }
}
