using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Estruturas : IAulaItem
    {
        public void Executar()
        {
            double Latitude1 = 13.78;
            double Longitude1 = 29.51;
            double Latitude2 = 40.23;
            double Longitude2 = 17.4;
            Console.WriteLine($"Latitude1 = {Latitude1}");
            Console.WriteLine($"Longitude1 = {Longitude1}");
            Console.WriteLine($"Latitude2 = {Latitude2}");
            Console.WriteLine($"Longitude2 = {Longitude2}");

            PosicaoGPS posicao1 = new PosicaoGPS(Latitude1, Longitude1);
            Console.WriteLine(posicao1.Longitude);
            Console.WriteLine(posicao1.estaNoHesmisferioNorte());
            //posicao1.Latitude = Latitude1;
            //posicao1.Longitude = Longitude2;

        }
    }

    interface IGPS
    {
        bool estaNoHesmisferioNorte();
    }

    struct PosicaoGPS : IGPS
    {
        public double Latitude;
        public double Longitude;

        public PosicaoGPS(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public bool estaNoHesmisferioNorte()
        {
            return Latitude > 0;
        }
    }
}
