using System;

namespace Listaaaaa
{
    internal class Lista4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo a calculadora de temperatura (Celsius para Farenheit)");
            Console.WriteLine();
            Console.WriteLine("Qual a tempertaura em graus Celsius que você pretende converter?");


            string strcelsius = Console.ReadLine();

            



            float celsius = Convert.ToSingle(strcelsius);

            Console.WriteLine();
            Console.WriteLine();

            

            Console.Write("Essa temperatura equivale a ");




            const float farenprod = 1.8f;
            const float farensoma = 32f;


            float resultado1 = celsius * farenprod;

            float resultado2 = resultado1 + farensoma;


            Console.Write(resultado2);



            Console.WriteLine(" graus Farenheit. ");








            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


        }
    }
}
        
    

