using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            Triangulo objeto;
            objeto = new Triangulo();
            Console.WriteLine("Verifica se os valores informados formam um tringulo");
            Console.WriteLine("Lado A: ");
            entrada = Console.ReadLine();
            objeto.ladoA = Convert.ToInt32(entrada);
            Console.WriteLine("Lado B: ");
            entrada = Console.ReadLine();
            objeto.ladoB = Convert.ToInt32(entrada);
            Console.WriteLine("Lado C: ");
            entrada = Console.ReadLine();
            objeto.ladoC = Convert.ToInt32(entrada);
            objeto.VerificaTriangulo();
            Console.ReadLine();




        }
    }
}
