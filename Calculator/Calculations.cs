using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal static class Calculations
    {
        public static double Calculate(SelectedOperator selectedOperator, double num1, double num2)
        {
            switch (selectedOperator)
            {
                case SelectedOperator.Addition:
                    return num1 + num2;
                    break;
                case SelectedOperator.Subtraction:
                    return num1 - num2;
                    break;
                case SelectedOperator.Multiplication:
                    return num1 * num2;
                    break;
                case SelectedOperator.Division:
                    return num1 / num2;
                    break;
                default:
                    return num1 + num2;
                    break;
            }
        }
    }
}
