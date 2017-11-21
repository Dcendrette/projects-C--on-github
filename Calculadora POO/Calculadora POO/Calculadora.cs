using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_POO
{
    public class Calculadora
    {
        private double v1, v2;
        private string op;

        public void Calc_mtd()
        {
            v1 = 0;
            v2 = 0;
          }

        public double V1
        {
            set
            {
                if (v1 >= 0)
                {
                    v1 = value;
                }
                else { v1 = 0; }
            }
        }


        public double V2
        {
            set
            {
                if (v2 >= 0)
                {
                    v2 = value;
                }
                else { v2 = 0;} 
            }
        }

        public double Soma()
        {
            double soma;
            soma = v1+v2;
            return soma;
        }
        public double Subtracao()
        {
            double subtracao;
            subtracao = v1-v2;
            return subtracao;
        }
        public double Multiplicacao()
        {
            double multiplicacao;
            multiplicacao = v1*v2;
            return multiplicacao;
        }
        public double Divisao()
        {
            double divisao;
            divisao = v1/v2;
            return divisao;
        }

        public double Operacao()
        {
            double res;

            switch (op){
            
                case "+":
                    res = Soma();
                    break;

                case "-":
                res = Subtracao();
                break;
                
                    case "*":
                res = Multiplicacao();
                break;

                     case "/":
                res = Divisao();
                break;
 
                default: 
                    res = double.NaN;
                    break;
            }
            return res;
        }
                    

            }

        }



