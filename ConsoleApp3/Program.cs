using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nummer1 = 0;
            int nummer2 = 0;
            
            while(true)
            {
                //eerste
                header();
                Console.WriteLine("schrijf nu je eerste letter");
                nummer1 = Convert.ToInt32(Console.ReadLine());

                //tweede
                header();
                Console.WriteLine("modulo = %, min = -, plus = +");
                Console.WriteLine("schrijf nu je functie");
                nummer1 = Convert.ToInt32(Console.ReadLine());
                //derde

            }
            void header()
            {
                Console.Clear();
                Console.WriteLine("--==========================--");
                Console.WriteLine("--==Welkom in rekenmachine==--"); 
                Console.WriteLine("--==========================--");
            }
        }
    }
}
