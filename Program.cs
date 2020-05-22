using System;

namespace MediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Média de três números");
            Console.ReadKey();
            Console.WriteLine("Primeiro número:7");
            Console.ReadKey();
            Console.WriteLine("Segundo número:9");
            Console.ReadKey();
            Console.WriteLine("Terceiro número:5");
            int media=7 + 9 + 5;
            int media2=media / 3;
            Console.ReadKey();
            Console.WriteLine($"Média={media2}");
            

            
        }
    }
}
