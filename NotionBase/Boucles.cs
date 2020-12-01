using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionBase
{
    class Boucles
    {
        public static void Firstloop()
        {
            Console.WriteLine("First loop:\r\n");
            var rand = new Random();
            int b = rand.Next(2, 100);
            for(int i = 1; i < 30; i++)
            {
                Console.Write("{0,15:N0}", i*b);
                
            }
            Console.WriteLine("\r\n*****************\r\n");
        }

        public static void SecondLoop()
        {
            Console.WriteLine("\r\nSecond Loop:\r\n");
            for (float i = 1; i < 10; i++)
            {
                Console.Write("{0,5:N0}", i + (i / 2));
            }
            Console.WriteLine("\r\n*****************\r\n");
        }

        public static void ThirdLoop()
        {
            Console.WriteLine("\r\nThird Loop:\r\n");
            for (int i = 1; i < 15; i++)
            {
                Console.Write("{0,30}", "On y arrive presque...");
            }
            Console.WriteLine("\r\n*****************\r\n");
        }

        public static void FourthLoop()
        {
            Console.WriteLine("\r\nFourth Loop:\r\n");
            for (int i = 20; i > 0; i--)
            {
                Console.Write("{0,30}", "C'est presque bon...");
            }
            Console.WriteLine("\r\n*****************\r\n");
        }

        public static void FifthLoop()
        {
            Console.WriteLine("\r\nFifth Loop:\r\n");
            for (int i = 1; i < 100; i+=15)
            {
                Console.Write("{0,30}", "On tient le bon bout...");
            }
            Console.WriteLine("\r\n*****************\r\n");
        }

        public static void SixthLoop()
        {
            Console.WriteLine("\r\nSixth Loop:\r\n");
            for (int i = 200; i > 0; i -= 12)
            {
                Console.Write("{0,30}", "Enfin ! ! !");
            }
            Console.WriteLine("\r\n*****************\r\n");
        }
    }
}
