using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda
{
    public class agenda1
    {

        public agenda1 (string nome, string email, string telefone)
        
        {
        
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
        }

        public agenda1() {

            this.nome = "";
            this.email = "";
            this.telefone = "";

        }



        private string _nome;
        private string _email;
        private string _telefone;

        public string nome 
        {
            get { 

                return this._nome;
                 }

            set {

                this._nome = value;                
                }   
        }

        public string email
        {
            get
            {

                return this._email;
            }

            set
            {

                this._email = value;
            }
        }


        public string telefone
        {
            get
            {

                return this._telefone;
            }

            set
            {

                this._telefone = value;
            }
        }

        public void exibedados() 
        {

            Console.Clear();
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("E-Mail: " + this.email);
            Console.WriteLine("Telefone: " + this.telefone);
        
        }





    }
}
