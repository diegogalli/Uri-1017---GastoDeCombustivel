using System;
using System.Globalization;

namespace GastoCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {

            int TempoGasto, VelMedia, distancia;
            double litros;

            TempoGasto = int.Parse(Console.ReadLine());
            VelMedia = int.Parse(Console.ReadLine());

            distancia = TempoGasto * VelMedia;

            litros = distancia / (double) 12;

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
