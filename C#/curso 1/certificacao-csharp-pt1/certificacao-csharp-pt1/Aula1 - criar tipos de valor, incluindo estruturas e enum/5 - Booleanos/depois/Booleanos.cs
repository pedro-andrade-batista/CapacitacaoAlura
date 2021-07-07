using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Booleanos : IAulaItem
    {
        public void Executar()
        {
            Console.WriteLine("teste");

            bool possuiSaldo = true;

            int dia = DateTime.Now.Day;

            Console.WriteLine($"Dia: {dia}");

            bool diaPar = (dia % 2 == 0);

            Console.WriteLine("O dia {0} é {1}", dia, diaPar == true ? "par" : "impar");
        }
    }
}
