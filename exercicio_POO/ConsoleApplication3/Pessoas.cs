using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Pessoas
    {
        private string nome;
        private double altura;

        public void setNome(String valor){
            this.nome = valor;
            //ou poderia ser Nome = valor; ***
        }

        public string getNome(){
        return this.nome;  
        }

        public void setAltura(double valor)
        {
            this.altura = valor;
            //ou poderia ser Nome = valor; ***
        }

        public Double getAltura()
        {
            return this.altura;
        }


        public void falesobrevoce() 
        {

            Console.WriteLine("Meu nome é: " + nome);
            Console.WriteLine("Eu tenho: " + altura + " metros de altura ");

        }
    }
}
