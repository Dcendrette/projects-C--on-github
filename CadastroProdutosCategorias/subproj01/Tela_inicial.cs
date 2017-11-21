using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subproj01
{
    public partial class Cadastros : Form
    {
        public Cadastros()
        {
            InitializeComponent();
        }

      
        private void btn_produto_Click(object sender, EventArgs e)
        {
            Form_produtos produtos = new Form_produtos();
             produtos.Show();
        }

      

        private void btn_categorias_Click_1(object sender, EventArgs e)
        {
            Form_categorias categorias = new Form_categorias();
            categorias.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_produtos produtos = new Form_produtos();
            produtos.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_categorias categorias = new Form_categorias();
            categorias.Show();
        }
              
    }
}
