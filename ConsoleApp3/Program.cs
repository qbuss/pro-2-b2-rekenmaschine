using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nummer1 = 0;
            int nummer2 = 0;
            int resultaat = 0;


            while (true)
            {
                //eerste
                header();
                Console.WriteLine("schrijf nu je eerste cijfer");
                nummer1 = Convert.ToInt32(Console.ReadLine());



                //derde
                header();
                Console.WriteLine("schrijf nu je tweede cijfer");
                nummer2 = Convert.ToInt32(Console.ReadLine());

                //tweede
                header();
                Console.WriteLine("================");
                Console.WriteLine("modulo");
                Console.WriteLine("min");
                Console.WriteLine("plus");
                Console.WriteLine("================");
                Console.WriteLine("schrijf nu je functie");
                switch (Console.ReadLine())
                {
                    case "plus":
                        resultaat = plus(nummer1, nummer2);
                        break;
                    case "min":
                        resultaat = min(nummer1, nummer2);
                        break;
                    case "modulo":
                        resultaat = modulo(nummer1, nummer2);
                        break;
                    case "delen":
                        resultaat = delen(nummer1, nummer2);
                        break;
                    case "keer":
                        resultaat = keer(nummer1, nummer2);
                        break;
                }
                Console.WriteLine("Jouw resultaat is " + resultaat);
                Console.WriteLine("==================================");
                Console.WriteLine("Click een knopje om te continueren");
                Console.ReadKey();

                
            }

            int plus(int int1, int int2)
            {
                return int1 + int2;
            }
            int min(int int1, int int2)
            {
                return int1 - int2;
            }
            int modulo(int int1, int int2)
            {
                return int1 % int2;
            }
            int delen(int int1, int int2)
            {
                return int1 / int2;
            }
            int keer(int int1, int int2)
            {
                return int1 * int2;
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
