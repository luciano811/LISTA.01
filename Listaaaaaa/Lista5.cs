using System;

namespace Listaaaaaa
{
    internal class Lista5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo ao programa que calcula saldos com aumento e inclui impostos hehe");
            Console.WriteLine();
            Console.WriteLine("Qual é o seu salário atual?");

            string strsatual = Console.ReadLine();
                               
            float satual = Convert.ToSingle(strsatual);

            Console.WriteLine();

            
            
            Console.Write("Seu salário atual é de r$:");

            Console.Write(satual);

            Console.WriteLine();




            Console.Write("Seu salário com o aumento de 15% é de R$:");

            const float kincreased = 1.15f;

            float resultado1 = satual * kincreased;

            Console.Write(resultado1);

            Console.WriteLine();

            

            
            Console.Write("Seu salário após o desconto de 8% é de R$: ");

            const float ktaxes = 0.92f;
                                           
            float resultado2 = resultado1 * ktaxes; ;
                       
            Console.Write(resultado2);


            Console.WriteLine();
            Console.WriteLine();


            Console.Write("Obrigado por usar a nossa calculadora de salários");


            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
