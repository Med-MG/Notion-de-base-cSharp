using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionBase
{
    class Collections
    {
        public static void firstQ()
        {
            var months = new List<string> { "January", "February" , "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            //question 1 output
            Console.WriteLine("\r\nquestion 1 output\r\n ______________________\r\n");
            for (var index = 0; index < months.Count; index++)
            {
                Console.Write(months[index] + " ");
            }

            //question 2 output
            Console.WriteLine("\r\nquestion 2 output\r\n ______________________\r\n");
            Console.WriteLine(months[2]);

            //question 3 output
            Console.WriteLine("\r\nquestion 3 output\r\n ______________________\r\n");
            Console.WriteLine(months[5]);

            //question 4 output
            Console.WriteLine("\r\nquestion 4 output\r\n ______________________\r\n");
            foreach (var month in months)
            {
                Console.Write("{0,15:N0}", month);
                Console.WriteLine();
            }

            //question 5 output
            Console.WriteLine("\r\nquestion 5 output\r\n ______________________\r\n");
            months[7] = "Août";
            Console.WriteLine(months[7]);

            //question 6 output
            Console.WriteLine("\r\nquestion 5 output\r\n ______________________\r\n");
            months.Insert(0, "MEDMG");
            foreach (var month in months)
            {
                Console.Write(month + " ");
                Console.WriteLine();
            }

            //question 7 output
            Console.WriteLine("\r\nquestion 7 output\r\n ______________________\r\n");
            months.RemoveAt(2);
            foreach (var month in months)
            {
                Console.Write(month + " ");
                Console.WriteLine();
            }

            //question 8 output
            Console.WriteLine("\r\nquestion 8 output\r\n ______________________\r\n");
            var Fifthmonth = months.Find(x => x.Contains("May"));
            Console.WriteLine(Fifthmonth);

            //question 9 output
            Console.WriteLine("\r\nquestion 9 output\r\n ______________________\r\n");
            months.Sort();
            foreach (var month in months)
            {
                Console.Write(month + " ");
                Console.WriteLine();
            }

            //question 10 output
            Console.WriteLine("\r\nquestion 10 output\r\n ______________________\r\n");
            List<String> Clone = months.ToList();
            foreach (var cl in Clone)
            {
                Console.Write(cl + " ");
                Console.WriteLine();
            }

            Console.WriteLine("\r\nThat's it, have a good day\r\n");
        }
    }
}
