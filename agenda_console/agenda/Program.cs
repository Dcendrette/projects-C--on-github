using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda
{
    class Program
    {
        static void Main(string[] args)
        {

            agenda1 p1 = new agenda1("Danillo", "222-2222", "dcendrette@hotmail.com");
            agenda1 p2 = new agenda1();
            pessoafisica pessoafisica = new pessoafisica();
            pessoafisica.nome = "pessoa";
            pessoafisica.telefone = "telefone";
            pessoafisica.email = "email";
            pessoafisica.cpf = "cpf";
            pessoafisica.cpf = "rg";
            pessoafisica.exibedados();
            Console.ReadKey();

        }


    }
}
