using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = ""; // variavel para armazenar a entrada de dados 

            Pessoas pessoa1; // variavel baseada na classe pessoa(classe criada em referenciada aqui)

            pessoa1 = new Pessoas(); // criado o objeto pessoa1  (estanciado anteriormente a classe pessoas "criada")
            // a partir da criação podemos utilizar dodos as instancias e metodos que ele possui (foi criado).

            Console.WriteLine("efetua leitura dos dados de tres pessoas"); // mensagem ao usuario
            Console.WriteLine("Dados da Primeira Pessoa");// mensagem ao usuario
            Console.Write("Informe seu nome: ");// mensagem ao usuario
            entrada = Console.ReadLine(); // leitura dos dados do teclado

            pessoa1.setNome(entrada);//******** preenchimento dos dadaos do teclado armazenados na variavel entrada, na variavel
            //nome criado na classe pessoas (classe criada).

            Console.Write("Informe sua altura: "); // escreve na tela 
            entrada = Console.ReadLine(); // faz a leitura novamente da entrada 
            pessoa1.setAltura(Convert.ToDouble(entrada)); // atribui a entrada do teclado ao atributo altura do objeto pessoa1 
            pessoa1.falesobrevoce(); // executa o metodo falesobrevoce na classe pessoas, com os valores atribuidos *atributos
            // ao obejeto pessoa nas linhas acima 
            Console.ReadKey(); // efetua leitura dos atributos ** mesmo resultado com o comando comentado.

           /* Pessoas pessoa2;
            pessoa2 = new Pessoas();
            Console.WriteLine("efetua leitura dos dados de tres pessoas");
            Console.WriteLine("Dados da Primeira Pessoa");
            Console.Write("Informe seu nome: ");
            entrada = Console.ReadLine();
            pessoa2.nome = entrada;
            Console.Write("Informe sua altura: ");
            entrada = Console.ReadLine();
            pessoa2.altura = Convert.ToString(entrada);
            pessoa2.falesobrevoce();
            Console.ReadKey();


            Pessoas pessoa3;
            pessoa3 = new Pessoas();
            Console.WriteLine("efetua leitura dos dados de tres pessoas");
            Console.WriteLine("Dados da Primeira Pessoa");
            Console.Write("Informe seu nome: ");
            entrada = Console.ReadLine();
            pessoa3.nome = entrada;
            Console.Write("Informe sua altura: ");
            entrada = Console.ReadLine();
            pessoa3.altura = Convert.ToString(entrada);
            pessoa3.falesobrevoce();
            Console.ReadKey();*/




        }
    }
}
