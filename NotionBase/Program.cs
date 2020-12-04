using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionBase
{
    class Program
    {
        private static byte Quit = 0;

        public static int Quite { get; private set; }

        static void Main(string[] args)
        {
            while(Quit == 0)
            {
                Run();
                //User Must press Q to quite the loop
                Console.WriteLine("\r\n### Press Q to (quit) Or Press (Enter) to continue ###\r\n");
                //var choice = Console.ReadKey();
                if (Console.ReadKey().Key == ConsoleKey.Q)
                {
                    Quit = 1;
                }
                else
                {
                    Quit = 0;
                }
            }
            //run our console app
            

        }


        public static void Run()
        {
            /**
             * We have 4 exercices, we are going to ask the user 
             * which one he would like to test
             */

            //Display the user options
            Console.WriteLine("" +
                "Choose which exercice you want to see :" +
                "\r\n [ 1 ] Varibales" +
                "\r\n [ 2 ] Les boucles " +
                "\r\n [ 3 ] Les fonctions et les Conditions " +
                "\r\n [ 4 ] Les collections "+
                "\r\n [ 0 ] Logout " +
                "\r\n_________________________________________ \r\n"
                );
            int Exercice = Convert.ToInt32(Console.ReadLine());
            switch (Exercice)
            {
                case 0:
                    Quite = 1;
                    Console.Write("You logged out");
                    break;
                case 1:
                    //Take user input
                    Variables.UserInputs();
                    //Calculate TTC
                    Variables.TaxCalculator();
                    //Display Message
                    Variables.GetMsg();
                    break;
                case 2:
                    //Execute First Loop
                    Boucles.Firstloop();
                    //Execute Second loop
                    Boucles.SecondLoop();
                    //Execute Third Loop
                    Boucles.ThirdLoop();
                    //Execute Fourth Loop
                    Boucles.FourthLoop();
                    //Execute Fifth Loop
                    Boucles.FifthLoop();
                    //Execute Sixth Loop
                    Boucles.SixthLoop();

                    break;
                case 3:
                    //calculator
                    Calculator.calculate();
                    break;
                case 4:
                    //first question
                    Collections.CollectionQ();
                    break;
                default:
                    //Default value in case there's an error
                    Console.WriteLine("There was an Error please choose one of the above choices:");
                    Run();
                    break;
            }
        }



    }
}
