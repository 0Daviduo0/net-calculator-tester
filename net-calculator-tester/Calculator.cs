using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public class Calculator
    {

        public float Addizione(float num1, float num2)
        {
            return num1 + num2;
        }


        public float Sottrazione(float num1, float num2)
        {
            return num1 - num2;
        }


        public float Moltiplicazione(float num1, float num2)
        {
            return num1 * num2;
        }


        public float Divisione(float num1, float num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Non si può dividere per 0");
            }
            return num1 / num2;
        }

    }
}
