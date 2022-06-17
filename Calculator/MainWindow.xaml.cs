using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double lastNumber = 0;
        private SelectedOperator operation;
        private bool hasOnePeriod = false;
        private bool isPreviousResult = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAc_Click(object sender, RoutedEventArgs e)
        {
            labelResult.Content = "0";
            lastNumber = 0;
            hasOnePeriod = false;
            isPreviousResult = false;
        }

        private void buttonNegative_Click(object sender, RoutedEventArgs e)
        {
            labelResult.Content = (Convert.ToDouble(labelResult.Content) * -1).ToString();
        }

        private void buttonPercentage_Click(object sender, RoutedEventArgs e)
        {
            labelResult.Content = Convert.ToDouble(labelResult.Content) / 100;
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedValue = int.Parse((sender as Button).Content.ToString());

            ResetResultConditional();

            if (labelResult.Content.ToString() == "0")
            {
                labelResult.Content = selectedValue.ToString();
            }
            else
            {
                labelResult.Content = $"{labelResult.Content.ToString()}{selectedValue.ToString()}";
            }
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            lastNumber = Convert.ToDouble(labelResult.Content.ToString());

            if (sender == buttonAdd) operation = SelectedOperator.Addition;
            if (sender == buttonSubtract) operation = SelectedOperator.Subtraction;
            if (sender == buttonMultiply) operation = SelectedOperator.Multiplication;
            if (sender == buttonDivide) operation = SelectedOperator.Division;

            labelResult.Content = "0";
            hasOnePeriod = false;
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            double currentNumber = Convert.ToDouble(labelResult.Content.ToString());
            double result = Calculations.Calculate(operation, lastNumber, currentNumber);


            if (operation == SelectedOperator.Division && currentNumber == 0)
            {
                MessageBox.Show("Division by 0 is not supported", "Unsupported Operation", MessageBoxButton.OK, MessageBoxImage.Error);
                labelResult.Content = "0";
            } else
            {
                labelResult.Content = result.ToString();
            }

            isPreviousResult = true;
        }

        private void DotButton_Click(object sender, RoutedEventArgs e)
        {
            if (isPreviousResult)
            {
                labelResult.Content = "0";
                isPreviousResult = false;
            }

            if (!labelResult.Content.ToString().Any(x => x == '.'))
            {
                labelResult.Content = $"{labelResult.Content.ToString()}.";
            }
        }

        private void ResetResultConditional()
        {
            if (isPreviousResult)
            {
                labelResult.Content = "0";
                isPreviousResult = false;
            }
        }
    }

    public enum SelectedOperator
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }
}