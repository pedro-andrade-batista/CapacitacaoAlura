using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Interfaces : IAulaItem
    {
        public void Executar()
        {
            //Console.WriteLine("teste");
        }
    }

    interface Ieletrodomestico
    {
        void Desligar();
        void Ligar();
    }

    interface IIluminacao
    {
        double PotenciaDaLampada { get; set; }

    }

    class Televisao : Ieletrodomestico
    {
        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Abajur : Ieletrodomestico, IIluminacao
    {
        public double PotenciaDaLampada { get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Lanterna : Ieletrodomestico, IIluminacao
    {
        public double PotenciaDaLampada { get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Radio : Ieletrodomestico
    {
        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }
}
