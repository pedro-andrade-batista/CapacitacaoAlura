using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Strings : IAulaItem
    {
        public void Executar()
        {
            string a = "bom dia";
            string b = "b";

            b += "om dia";

            Console.WriteLine(b == a);
            Console.WriteLine((Object) b == (Object) a); //Verificando se são os mesmos objetos

            Console.WriteLine(a[4]);


        }
    }
}
