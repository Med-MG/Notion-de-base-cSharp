using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotionBase
{
    class Operations
    {
      
        /**
         * Internal Method Sum up two variables
         * Operation type "+"
         * @return a decimal value
         */
        internal decimal Sum(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        /**
         * Internal Method Substract two variables
         * Operation type "-"
         * @return a decimal value
         */
        internal decimal Substract(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        /**
         * Internal Method Multiply two variables
         * Operation type "*"
         * @return a decimal value
         */
        internal decimal Multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
        /**
         * Internal Method Devide two variables
         * Operation type "/"
         * @return a decimal value
         */
        internal decimal Devide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
        /**
         * Internal Method Modular two variables
         * Operation type "%"
         * @return a decimal value
         */
        internal decimal Modular(decimal num1, decimal num2)
        {
            return num1 % num2;
        }
    }
}
