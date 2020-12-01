using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionBase
{
    class Variables
    {
        public static string price;
        public static string percentage;
        public static decimal finalePrice;

        public static void UserInputs()
        {
            //getting Price value
            Console.WriteLine("Entre Price of item: ");
            price = Console.ReadLine();
            //getting Percentage value
            Console.WriteLine("Entre Percentage of item");
            percentage = Console.ReadLine();
        }

        public static void TaxCalculator()
        {
            decimal priceD = decimal.Parse(price);
            decimal percentageD = decimal.Parse(percentage) / 100;
            finalePrice = priceD + (priceD * percentageD);

        }

        public static void GetMsg()
        {
            Console.WriteLine(string.Format("Initial price: {0} dh, \r\n  After Tax Price:{1} dg", price, finalePrice));
        }
    }
}
