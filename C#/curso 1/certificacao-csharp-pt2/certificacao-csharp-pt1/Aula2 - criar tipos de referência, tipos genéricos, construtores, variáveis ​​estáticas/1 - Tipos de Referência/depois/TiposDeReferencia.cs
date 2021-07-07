using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposDeReferencia : IAulaItem
    {
        public void Executar()
        {
            //Console.WriteLine("teste");
            var cliente1 = new Cliente("João", 42);
            var cliente2 = cliente1;

            Console.WriteLine($"Cliente 1: {cliente1}" );
            Console.WriteLine($"Cliente 2: {cliente2}" );

            cliente1.Nome = "Maria";

            Console.WriteLine($"Cliente 1: {cliente1}");
            Console.WriteLine($"Cliente 2: {cliente2}");
        }
    }

    class Cliente
    {
        //public string nome;
        //public int idade;

        public Cliente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }



        public override string ToString()
        {
            return $"Nome: {Nome}, idade {Idade}";
        }
    }
}
