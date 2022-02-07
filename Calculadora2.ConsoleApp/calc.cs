using System;

namespace Calculadora.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.WriteLine();

                 Console.WriteLine("Calculadora da Mariana");

                Console.WriteLine("Digite os números que quer operacionalizar");

                Console.Write("Digite o primeiro número:");

                string strPrimeiroNumero = Console.ReadLine();

                Console.Write("Digite o segundo número:");

                string strSegundoNumero = Console.ReadLine();

                float primeiroNumero = Convert.ToSingle(strPrimeiroNumero);

                float segundoNumero = Convert.ToSingle(strSegundoNumero);

                
                Console.WriteLine();

                Console.Write("Aperte enter para prosseguir");

                Console.WriteLine();

                Console.ReadLine();

                Console.WriteLine("Digite 1 para somar");

                Console.WriteLine("Digite 2 para subtrair");

                Console.WriteLine("Digite 3 para multiplicar");

                Console.WriteLine("Digite 4 para dividir");

                Console.WriteLine("Digite s para sair");

                choice = Console.ReadLine();


                if (choice == "s") break;

              
                
                if (choice == "1")
                {
                    Console.Write("Resultado=");
                   
                    float resultado = primeiroNumero + segundoNumero;

                    Console.WriteLine(resultado);

                }

               
                
                if (choice == "2")
                {

                    Console.Write("Resultado=");

                    float resultado = primeiroNumero - segundoNumero;

                    Console.WriteLine(resultado);


                }

               
                
                if (choice == "3")
                {

                    Console.Write("Resultado=");

                    float resultado = primeiroNumero * segundoNumero;

                    Console.WriteLine(resultado);


                }

              
                
                if (choice == "4")
                {

                    Console.Write("Resultado=");

                    float resultado = primeiroNumero / segundoNumero;

                    Console.Write(resultado);


                }

            } while (choice == "1" || choice == "2" || choice == "3" || choice == "4");


        }



    }
}
