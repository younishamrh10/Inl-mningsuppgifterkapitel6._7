using System;

namespace Inlämningsuppgifterkapitel6._7
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tal för att veta om det är ett primtal:");
            int tal = int.Parse(Console.ReadLine());
            Console.WriteLine(Prim(tal));
        }
        static bool Prim(int tal)
        {
            int deltal = 0;
            for (int i = 2; i < tal; i++)
            {
                if (tal % i == 0)
                {
                    deltal++;
                }
            }
            if (deltal == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}