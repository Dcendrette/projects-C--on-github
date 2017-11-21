using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular a media de um eluno


            AlunoAdd obj = new AlunoAdd();
            string entrada = "";
            Console.WriteLine("calcula a media de um aluno");
            Console.Write("Aluno: ");
            entrada = Console.ReadLine();

            obj.nome = entrada;
            Console.Write("Nota 1 : ");
            entrada = Console.ReadLine();
            obj.nota1 = Convert.ToDouble(entrada);

            Console.Write("Nota 2 : ");
            entrada = Console.ReadLine();
            obj.nota2 = Convert.ToDouble(entrada);

            Console.Write("Nota 3 : ");
            entrada = Console.ReadLine();
            obj.nota3 = Convert.ToDouble(entrada);

            Console.Write("Nota 4 : ");
            entrada = Console.ReadLine();
            obj.nota4 = Convert.ToDouble(entrada);

            Console.Write("A média de " + obj.nome + " é: ");
            Console.Write(obj.media());
            Console.ReadKey();          

        }
    }
}
