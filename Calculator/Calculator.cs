using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public static double Addition(double[] values)
        {
            double sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            return sum;
        }

        public static double Substraction(double[]values)
        {
            return values[0] - values[1];
        }

        public static double Dividing(double[]values)
        {
            if (values[1] == 0)
            {
                Console.WriteLine("Error: you tried to devide by 0");
                return 0;
            }

            else if (values[0] == 0)
            {
                return 0;
            }

            return values[0] / values[1];
        }
        public static double Multiplication(double[]values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == 0)
                {
                    return 0;
                }
            }

            double sum = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                sum *= values[i];
            }

            return sum;
        }
        public static double PercentCalculation(double value, double percent)
        {
            return value * percent / 100;
        }
    }
}
