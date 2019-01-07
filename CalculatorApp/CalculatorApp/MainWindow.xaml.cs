using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result;
        SelectedOperator selectedOperator;
        public MainWindow()
        {
            InitializeComponent();
            acBtn.Click += AcBtn_Click;
            negativeBtn.Click += NegativeBtn_Click;
            percentageBtn.Click += PercentageBtn_Click;
            equalsBtn.Click += EqualsBtn_Click;
        }

        private void EqualsBtn_Click(object sender, RoutedEventArgs e)
        {
            double newNumber;
            if (double.TryParse(resultLabel.Content.ToString(), out newNumber))
            {
                switch (selectedOperator)
                {
                    case SelectedOperator.Addition:
                        result = SimpleMath.Add(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Substraction:
                        result = SimpleMath.Substract(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Multiplication:
                        result = SimpleMath.Multiply(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Division:
                        result = SimpleMath.Divide(lastNumber, newNumber);
                        break;
                }

                resultLabel.Content = result.ToString();
            }
        }

        private void PercentageBtn_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber / 100;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void NegativeBtn_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * -1;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void AcBtn_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }

        private void operationBtn_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                resultLabel.Content = "0";
            }

            if (sender == multiplyBtn)
                selectedOperator = SelectedOperator.Multiplication;
            if (sender == divisionBtn)
                selectedOperator = SelectedOperator.Division;
            if (sender == plusBtn)
                selectedOperator = SelectedOperator.Addition;
            if (sender == minusBtn)
                selectedOperator = SelectedOperator.Substraction;
        }

        private void commaBtn_Click(object sender, RoutedEventArgs e)
        {
            if(resultLabel.Content.ToString().Contains("."))
            {

            }
            else
            {
            resultLabel.Content = $"{resultLabel.Content}.";
            }
        }

        private void numberBtn_Click(object sender, RoutedEventArgs e)
        {
            int selectedValue = 0;

            if (sender == zeroBtn)
                selectedValue = 0;
            if (sender == oneBtn)
                selectedValue = 1;
            if (sender == twoBtn)
                selectedValue = 2;
            if (sender == threeBtn)
                selectedValue = 3;
            if (sender == fourBtn)
                selectedValue = 4;
            if (sender == fiveBtn)
                selectedValue = 5;
            if (sender == sixBtn)
                selectedValue = 6;
            if (sender == sevenBtn)
                selectedValue = 7;
            if (sender == eightBtn)
                selectedValue = 8;
            if (sender == nineBtn)
                selectedValue = 9;



            if(resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = $"{selectedValue}";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}{selectedValue}";
            }
        }
    }

    public enum SelectedOperator
    {
        Addition,
        Substraction,
        Multiplication,
        Division
    }

    public class SimpleMath
    {
        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public static double Substract(double number1, double number2)
        {
            return number1 - number2;
        }

        public static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        public static double Divide(double number1, double number2)
        {
            if(number2 == 0)
            {
                MessageBox.Show("Division by 0 is not supported", "Wrong operation", MessageBoxButton.OK, MessageBoxImage.Error);
                return 0;
            }
            return number1 / number2;
        }
    }
}
