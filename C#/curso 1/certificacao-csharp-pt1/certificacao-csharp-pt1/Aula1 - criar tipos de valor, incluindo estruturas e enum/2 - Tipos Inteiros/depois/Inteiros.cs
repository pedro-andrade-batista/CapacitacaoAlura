using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposInteiros : IAulaItem
    {
        public void Executar()
        {
            int idade = 15;
            //idade = 15.5;

            char resposta = 'S'; //System.char
            byte nivelDeAzul = 0xFF;// == 255 em decimal

            Console.WriteLine($"resposta: {resposta}");
            Console.WriteLine($"nivel de azul: {nivelDeAzul}");
        }
    }
}
