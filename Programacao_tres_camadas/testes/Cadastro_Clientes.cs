using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testes.Busines_Logic_Layer;
using testes.Data_Transfer_Object;



namespace testes  // camada de apresentacao
{
    public partial class Cadastro_Clientes : Form
    {
        public Cadastro_Clientes()
        {
            InitializeComponent();
        }

        ClienteBLL bll = new ClienteBLL(); // objeto criado na camada de apresentação
        ClienteDTO dto = new ClienteDTO(); // objeto criado na camada de apresentação

        private void Cadastro_Clientes_Load(object sender, EventArgs e)
        {
        }

        private void Btn_Incluir_Click(object sender, EventArgs e)
        {
            dto.Email = txt_Email.Text;
            dto.Nome = txt_Nome.Text;
            bll.inserir(dto);
        }

        
    }
}
