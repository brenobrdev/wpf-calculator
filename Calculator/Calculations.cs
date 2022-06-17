﻿namespace Calculator
{
    /// <summary>
    /// Class that does calculations based on operator selected
    /// </summary>
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