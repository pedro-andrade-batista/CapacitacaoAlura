using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposDeValor : IAulaItem
    {
        public void Executar()
        {
            int idade;
            idade = 40;
            Console.WriteLine(idade);

            int copiaIdade = idade;
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"cópia da idade: {copiaIdade}");

            idade = 23;
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"cópia da idade: {copiaIdade}");

            int? idade2 = null; //A interrogação permite atribuir valores nulos na variavel
            System.Nullable<int> idade3 = null; //mesma coisa que a linha de cima
        }
    }
}
