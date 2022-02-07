// A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um
// algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno.

using System;

namespace Listaa
{
    internal class Lista1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo ao programa de cálculo de área da Imóbilis");
            Console.WriteLine();
            Console.WriteLine("Digite o lado de menor comprimento do terreno (em metros)");
            

            string strMeno = Console.ReadLine();

            Console.WriteLine("Digite o lado de maior comprimento do terreno (em metros)");

            string strMaio = Console.ReadLine();

            float meno = Convert.ToSingle(strMaio);

            float maio = Convert.ToSingle(strMeno);

            Console.Write("Area do terreno=");

            float resultado = meno * maio;

            Console.Write(resultado);

            Console.Write("m²");

            Console.ReadLine();

        }
    }
}
