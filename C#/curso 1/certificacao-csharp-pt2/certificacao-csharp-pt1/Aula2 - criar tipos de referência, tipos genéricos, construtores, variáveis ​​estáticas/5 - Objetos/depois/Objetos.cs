using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Objetos : IAulaItem
    {
        public void Executar()
        {
            int pontuacao = 10;
            Console.WriteLine($"pontuacao: {pontuacao}");

            Object meuObjeto;
            meuObjeto = pontuacao;
            Console.WriteLine($"meu Objeto: {meuObjeto}");

            meuObjeto = new Jogador();
            Jogador classRef;
            classRef = (Jogador) meuObjeto; //Casting explicito
        }
    }

    class Jogador
    {
        public int Pontuacao { get; set; } = 10;
    }
}
