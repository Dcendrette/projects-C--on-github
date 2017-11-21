using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form1 objeto = new Form1(double = n1, double = n2, double = res);

        //public double n1, n2, res;

        public void numerais()
        {
            n1 = Convert.ToInt16(txt_n1.Text);
            n2 = Convert.ToInt16(txt_n2.Text);
            txt_res.Text = res.ToString();
        }
        private void btn_soma_Click(object sender, EventArgs e)
        {
            
            objeto.res = objeto.n1 + objeto.n2;
        }
    }
}
