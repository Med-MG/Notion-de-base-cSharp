using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionBase
{
    class Program
    {
        

        static void Main(string[] args)
        {

            //run our console app
            Run();

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
                "\r\n [ 4 ] Les collections "
                );
            int Exercice = Convert.ToInt32(Console.ReadLine());
            switch (Exercice)
            {
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
                    //code block
                    Console.WriteLine("There was an Error please choose one of the above choices:");
                    Run();
                    break;
            }
        }



    }
}
