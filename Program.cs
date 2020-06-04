using System;

namespace MediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digíte três números para ser feito a média aritmética sobre eles.");
            Console.Write("Primeiro número:");
            double one=Convert.ToDouble(Console.ReadLine());
            Console.Write("Segundo número:");
            double two=Convert.ToDouble(Console.ReadLine());
            Console.Write("Terceiro número:");
            double three=Convert.ToDouble(Console.ReadLine());
            double media=one + two + three;
            double media2=media / 3;
            Console.Clear();
            Console.WriteLine($"Média={media2}");
            

            
        }
    }
}
