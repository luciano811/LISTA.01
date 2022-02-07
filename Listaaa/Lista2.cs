/* A padaria Hotpão vende uma certa quantidade de pães franceses e uma
quantidade de broas acada dia. Cada pãozinho custa R$ 0,12 e a broa custa R$
1,50. Ao final do dia, o dono quer saberquanto arrecadou com a venda dos pães
e broas (juntos), e quanto deve guardar numa conta depoupança (10% do total
arrecadado). Você foi contratado para fazer os cálculos para o dono. Combase
nestes fatos, faça um algoritmo para ler as quantidades de pães e de broas, e
depois calcularos dados solicitados. 
*/

using System;

namespace Listaaa
{
    internal class Lista2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo ao programa da Hotpao");
            Console.WriteLine();
            Console.WriteLine("Quantos paes vc vendeu?");


            string strnpao = Console.ReadLine();

            Console.WriteLine("Quantas broas vc vendeu?");

            string strnbroa = Console.ReadLine();

            float npao = Convert.ToSingle(strnpao);

            float nbroa = Convert.ToSingle(strnbroa);

            Console.Write("Vc arrecadou R$ ");
           


            const float pvalue=0.12f;
            const float bvalue = 1.50f;
            const float poupvalue = 0.1f;

            float resultadop = npao * pvalue;
                
            float resultadob = nbroa * bvalue;

            float resultado = resultadob + resultadop;

            Console.Write(resultado);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Você precisará guardar ");

            float poup = resultado * poupvalue;

            Console.Write(poup);
            

            Console.Write(" reais para ter uma aposentadoria no futuro hehe");
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


        }
    }
}
