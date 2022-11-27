using System;

namespace lab1ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ultima cifra a unui nr introdus de la tastatura
            int a;
            Console.WriteLine("Introduceti un numar: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ultima cifra a n umarului introdus este: " + a%10);

        }
    }
}
