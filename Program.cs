using System;

namespace ConsoleApp57
{
    class Program
    {
        static void Main(string[] args)
        {
            tring nome = "";
            int idade = 0;


            Console.WriteLine("Você é Homem ou Mulher?");
            nome = Console.ReadLine();

            if (nome == "mulher")
            {
                Console.WriteLine("Quantos ano você tem?");
                idade = int.Parse(Console.ReadLine());


            }
            else
            {
                Console.WriteLine("Você é Homem então paga entrada!");
                Console.WriteLine("Entrada gratis somente para Mulheres!");

            }



            if (nome == "mulher" && idade >= 25)
            {
                Console.WriteLine(" Você tem acima de 25 anos, sua entrada é gratis!");

                Console.WriteLine("Obrigada! pela preferencia!");
            }
            else
            {
                Console.WriteLine("Não conrespode as exigencias!");
            }



            Console.ReadLine();
        }
    }
}
        }
    }
}
