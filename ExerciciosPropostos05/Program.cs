// See htusing System;

using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {
            int codigoDeUmaPeca1, codigoDeUmaPeca2, numeroDePecas1, numeroDePecas2;
            double valorUnitarioDeCadaPeca1, valorUnitarioDeCadaPeca2, calculo;


            string[] valores = Console.ReadLine().Split(' ');
            codigoDeUmaPeca1 = int.Parse(valores[0]);
            numeroDePecas1 = int.Parse(valores[1]);
            valorUnitarioDeCadaPeca1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            codigoDeUmaPeca2 = int.Parse(valores[0]);
            numeroDePecas2 = int.Parse(valores[1]);
            valorUnitarioDeCadaPeca2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            calculo = valorUnitarioDeCadaPeca1 * numeroDePecas1 + valorUnitarioDeCadaPeca2 * numeroDePecas2;
            
            Console.WriteLine("VALOR A PAGAR: R$ " + calculo.ToString("F2", CultureInfo.InvariantCulture));





        }
    }
}
