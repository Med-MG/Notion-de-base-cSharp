using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionBase
{
    class Calculator
    {

        public static void calculate()
        {
            /**
             * calculator started message
             * show the user the types of operation available
             * based on the user choice apply the calculation
             */

            Console.WriteLine("Calculator started : \r\n" +
                "______________________\r\n" +
                "choose an operation\r\n"
                );
            String operation = Console.ReadLine();
            Console.WriteLine("First number: ");
            Decimal Num1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Second number: ");
            Decimal Num2 = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case "+":
                    Console.WriteLine(String.Format("The result of {0} {1} {2} = {3} ",Num1, operation, Num2, Num1+Num2));
                    break;
                case "-":
                    Console.WriteLine(String.Format("The result of {0} {1} {2} = {3} ", Num1, operation, Num2, Num1 - Num2));
                    break;
                case "*":
                    Console.WriteLine(String.Format("The result of {0} {1} {2} = {3} ", Num1, operation, Num2, Num1 * Num2));
                    break;
                case "/":
                    Console.WriteLine(String.Format("The result of {0} {1} {2} = {3} ", Num1, operation, Num2, Num1 / Num2));
                    break;
                default:
                    Console.WriteLine("there was an Error");
                    //Error message
                    break;
            }


        }
    }
}
