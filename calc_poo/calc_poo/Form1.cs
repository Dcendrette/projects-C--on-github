using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc_poo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            Calculadora cal = new Calculadora();

            try
            {
                cal.V1 = double.Parse(textBox1.Text);
                cal.V2 = double.Parse(textBox3.Text);
                cal.Op = textBox2.Text;
                MessageBox.Show(cal.V1 + " " + cal.Op + " " + cal.V2 + " = " + cal.Operacao(), "Resulltado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insira os Valores A e B");

            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }
    }
}
