using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testes.Data_Transfer_Object
{
    class ClienteDTO 
    {
        private int id; //metodo privado e somente executado nesta classe

        public int Id // metodo publico gerado a partir do encapsulamento ctrl+r+e
        {
            get { return id; } // atributos get e set 
            set { id = value; }
        }


        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        //----------------------------------------------------------------------------------------


    }
}
