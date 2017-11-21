using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Simples
{
    public partial class Calculadora : Form
    {
      
       
        public Calculadora()
        {
            InitializeComponent();
        }

        

        private void btn_soma_Click(object sender, EventArgs e)

        {
            if ((txt_N1.Text == "") || (txt_N1.Text == ""))
                {
                    MessageBox.Show(" Campos em branco!");
                }
                else
                {
                    double N1;
                    double N2;
                    double Res;
                    N1 = Convert.ToDouble(txt_N1.Text);
                    N2 = Convert.ToDouble(txt_N2.Text);
                    Res = (N1 + N2);
                    txt_resultado.Text = Convert.ToString(Res);
                }
        }

        private void btn_subtrair_Click(object sender, EventArgs e)
        {
            int N1;
            int N2;
            int Res;
            N1 = Convert.ToInt16(txt_N1.Text);
            N2 = Convert.ToInt16(txt_N2.Text);
            Res = (N1 - N2);
            txt_resultado.Text = Convert.ToString(Res);

        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            int N1;
            int N2;
            int Res;
            N1 = Convert.ToInt16(txt_N1.Text);
            N2 = Convert.ToInt16(txt_N2.Text);
            Res = (N1 / N2);
            txt_resultado.Text = Convert.ToString(Res);
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            int N1;
            int N2;
            int Res;
            N1 = Convert.ToInt16(txt_N1.Text);
            N2 = Convert.ToInt16(txt_N2.Text);
            Res = (N1 * N2);
            txt_resultado.Text = Convert.ToString(Res);

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
        //    int N1;
        //    int N2;
        //    int Res;
        //    N1 = Convert.ToInt16(txt_N1.Text);
        //    N2 = Convert.ToInt16(txt_N2.Text);
        //    Res = (N1 * N2);
        //    txt_resultado.Text = Convert.ToString(Res);

            txt_N1.Text = "";
            txt_N2.Text = "";
            txt_resultado.Text = "";

        }





    }
}
