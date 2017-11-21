using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Triangulo
    {
        public int ladoA;
        public int ladoB;
        public int ladoC;

        public void VerificaTriangulo() {

            if ((ladoA < (ladoB + ladoC)) && (ladoB < (ladoA + ladoC)) && (ladoC < (ladoB + ladoA)))
            {

                Console.WriteLine("Forma um Triangulo");
            }

            else {

                Console.WriteLine("Não forma um tringulo");
            }
        
        }
    }
}
