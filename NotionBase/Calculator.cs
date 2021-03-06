﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionBase
{
    class Calculator : Operations
    {
        public static Decimal Num1, Num2;
        public static byte quit = 0;
       
        public static void calculate()
        {
            /**
             * calculator started message
             * show the user the types of operation available
             * based on the user choice apply the calculation
             */

            Operations Op = new Operations();

            //A while loop, to keep executing the calculator untile the user press The "Q"
            while ( quit == 0)
            {
                Console.WriteLine("Calculator started : \r\n" +
                "______________________\r\n" +
                "choose an operation (+, *, -, / or %)\r\n"
                );
                String operation = Console.ReadLine();
                TakeInput();

                switch (operation)
                {
                    case "+":
                        Console.WriteLine(String.Format("The result of {0} {1} {2} = {3} \r\n", Num1, operation, Num2, Op.Sum(Num1, Num2)) );
                        break;
                    case "-":
                        Console.WriteLine(String.Format("The result of {0} {1} {2} = {3} \r\n", Num1, operation, Num2, Op.Substract(Num1, Num2)));
                        break;
                    case "*":
                        Console.WriteLine(String.Format("The result of {0} {1} {2} = {3} \r\n", Num1, operation, Num2, Op.Multiply(Num1, Num2)));
                        break;
                    case "/":
                        Console.WriteLine(String.Format("The result of {0} {1} {2} = {3} \r\n", Num1, operation, Num2, Op.Devide(Num1, Num2)));
                        break;
                    case "%":
                        Console.WriteLine(String.Format("The result of {0} {1} {2} = {3} \r\n", Num1, operation, Num2, Op.Modular(Num1, Num2)));
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input");

                        //Error message
                        break;
                }
                //User Must press Q to quite the loop
                Console.WriteLine("\r\n### Press Q to (quit) Or Press (Enter) to continue ###\r\n");
                //var choice = Console.ReadKey();
                if(Console.ReadKey().Key == ConsoleKey.Q)
                {
                    quit = 1;
                }
                else
                {
                    quit = 0;
                }
                 


            }

            


        }

        public static void TakeInput()
        {
            Console.WriteLine("First number: ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number: ");
            Num2 = Convert.ToInt32(Console.ReadLine());
        }
    }
}
