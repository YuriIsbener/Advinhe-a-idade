using System;

namespace Advinhe_a_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a idade do ator");
            int idade = int.Parse(Console.ReadLine());
            
            while (idade != 47)
            {
                Console.WriteLine("Errou!");
                Console.WriteLine("Digite a idade do ator novamente");
                idade = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Acertou Miseravi");
        }
    }
}
