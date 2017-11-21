using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda
{
    class pessoafisica:agenda1
    {
        private string _rg;
        private string _cpf;

        public string rg {

            get {

                return this._rg;
            }

            set {

                this._rg = value;
            }
        
        }

        public string cpf {

            get
            {

                return this._cpf;
            }

            set
            {

                this._cpf = value;
            }
        }

        public void exibedados()
        {

            Console.Clear();
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("E-Mail: " + this.email);
            Console.WriteLine("Telefone: " + this.telefone);
            Console.WriteLine("RG: " + this.rg);
            Console.WriteLine("CPF: " + this.cpf);

        }
    }


}
