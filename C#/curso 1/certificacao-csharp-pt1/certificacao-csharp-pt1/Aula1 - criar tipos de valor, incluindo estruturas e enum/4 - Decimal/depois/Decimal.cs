using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Decimal : IAulaItem
    {
        public void Executar()
        {
            double valor1 = 10;
            double valor2 = 20;
            double subtotal = 30;
            //Console.WriteLine("teste");
            Console.WriteLine((valor1 + valor2) == subtotal);

            valor1 = 10.10;
            valor2 = 20.20;
            subtotal = 30.30;
            Console.WriteLine((valor1 + valor2) == subtotal);

            decimal valor3 = 10.1m;
            decimal valor4 = 20.2m;
            decimal custo = 30.3m;

            Console.WriteLine((valor3 + valor4) == custo);
        }
    }
}
