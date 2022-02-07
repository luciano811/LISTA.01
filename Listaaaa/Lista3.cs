/* A
Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir
quantos dias de vida ela possui. Considere sempre anos completos, e que um
ano possui 365 dias. Ex: uma pessoa com 19 anos possui 6935 dias de vida; veja
um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.
*/

using System;

namespace Listaaaa
{
    internal class Lista3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo a calculadora de dias de vida");
            Console.WriteLine();
            Console.WriteLine("Qual é o seu nome?");


            string strnome = Console.ReadLine();

            Console.WriteLine("Quantos anos completos você tem?");

            string stranos = Console.ReadLine();

            
            float anos = Convert.ToSingle(stranos);
           
            Console.WriteLine();
            Console.WriteLine();
            
            Console.Write(strnome);

            Console.Write(", você viveu ");




            const float anodias = 365f;
            

            float resultado = anos * anodias;

           

           
            Console.Write(resultado);

            

            Console.WriteLine(" dias de vida. ");

            

            


            

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


        }
    }
}
