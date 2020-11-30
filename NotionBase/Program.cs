using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionBase
{
    class Program
    {
        private static decimal price;
        private static decimal percentage;
        private static decimal finalePrice;

        static void Main(string[] args)
        {
            //getting Price value
            Console.WriteLine("Entre Price of item: ");
            string price = Console.ReadLine();
            //getting Percentage value
            Console.WriteLine("Entre Percentage of item");
            string percentage = Console.ReadLine();

            //var finalePrice = decimal.Parse(price) + (decimal.Parse(price) * (decimal.Parse(percentage) / 100));

            //Console.WriteLine(string.Format("Initial price: {0} dh, \r\n After Tax Price:{1} dh", price, finalePrice));
            TaxCalculator(price, percentage);
            GetMsg();

        }

        public static void TaxCalculator(string inputPrice, string taxRate)
        {
            price = decimal.Parse(inputPrice);
            percentage = decimal.Parse(taxRate) / 100;
            finalePrice = price + (price * percentage);

        }

        public static void GetMsg()
        {
            Console.WriteLine(string.Format("Initial price: {0} dh, \r\n  After Tax Price:{1} dg", price, finalePrice));
        }




    }
}
