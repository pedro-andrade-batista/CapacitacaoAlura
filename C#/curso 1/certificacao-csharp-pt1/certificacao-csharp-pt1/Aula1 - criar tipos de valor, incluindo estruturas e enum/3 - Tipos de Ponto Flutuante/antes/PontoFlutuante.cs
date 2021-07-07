using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class PontoFlutuante : IAulaItem
    {
        public void Executar()
        {
            float idade = 15;
            idade = 15.5f;

            Console.WriteLine($"idade: {idade}");

            Console.WriteLine($"long.min: {long.MinValue}");
            Console.WriteLine($"long.max: {long.MaxValue}");
        }
    }
}
