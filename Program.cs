using System.ComponentModel;
using DorminhoCão.code.sizes;

namespace DorminhoCão
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DorminhoCão - O melhor hotel para seu cachorro ----------------------------");
            Console.WriteLine("Olá! Vamos pedir algumas informações para o cadastro do seu cachorro");
            Console.WriteLine();
            Console.WriteLine("Qual o nome do seu cachorro?");
            string? name = Console.ReadLine();

            ConsoleKey response;
            do{
                Console.Write("Qual o gênero do seu cachorro? (F/M)");
                 response = Console.ReadKey(false).Key; 
                if (response != ConsoleKey.Enter)
                Console.WriteLine();
            } while (response != ConsoleKey.F && response != ConsoleKey.M);
            char gender = Convert.ToChar(response);
            Console.WriteLine("Gender --> " + gender);

            Console.WriteLine("Qual o peso dele em kg?");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual a idade do cachorro?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual a data de aniversário dele?");
            string? birthday = Console.ReadLine();

            do{
                Console.Write("Seu cachorro tem alguma limitação de saúde? (S/N)");
                response = Console.ReadKey(false).Key; 
                if (response != ConsoleKey.Enter)
                Console.WriteLine();
            } while (response != ConsoleKey.S && response != ConsoleKey.N);

            if(response == ConsoleKey.S){
                bool especial = Convert.ToBoolean(true);
                Console.WriteLine("Especial --> " + especial);
                if(especial)
                {
                    Console.WriteLine("Qual a limitação de saúde do seu cachorro?");
                    string? limitation = Console.ReadLine();
                    Console.WriteLine(limitation);
                }     
            } else {
                bool especial = Convert.ToBoolean(false);
            }

            Xsmall xsmall = new Xsmall(); 
        }
    }
}