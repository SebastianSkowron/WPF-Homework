using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace UserInput.Wpf
{
    public partial class MainWindow : Window
    {
        private double? FirstNumber { get; set; }

        private double? SecondNumber { get; set; }

        private Func<double, double, double> SelectedMathFunction { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private double Add(double a, double b)
        {
            double result = a + b;
            return result;
        }

        private double Subtract(double a, double b)
        {
            double result = a - b;
            return result;
        }

        private double Multiply(double a, double b)
        {
            double result = a * b;
            return result;
        }

        private double Divide(double a, double b)
        {
            double result = a / b;
            return result;
        }

        private void FirstNumberBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(FirstNumberBox?.Text))
            {
                FirstNumber = null;
                return;
            }

            if (double.TryParse(FirstNumberBox?.Text, out double parsedNumber))
            {
                FirstNumber = parsedNumber;
            }
            else
            {
                FirstNumberBox.Text = FirstNumberBox.Text.TrimEnd(FirstNumberBox.Text.LastOrDefault());
            }
        }

        private void RadioButton_OnChecked(object sender, RoutedEventArgs e)
        {
            var radioButton = sender as RadioButton;

            string radioButtonContent = radioButton?.Content?.ToString();

            switch (radioButtonContent)
            {
                case "Add":
                    SelectedMathFunction = Add;
                    break;
                case "Subtract":
                    SelectedMathFunction = Subtract;
                    break;
                case "Multiply":
                    SelectedMathFunction = Multiply;
                    break;
                case "Divide":
                    SelectedMathFunction = Divide;
                    break;
                default:
                    SelectedMathFunction = null;
                    break;
            }
        }

        private void SecondNumberBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(SecondNumberBox?.Text))
            {
                SecondNumber = null;
                return;
            }

            if (double.TryParse(SecondNumberBox?.Text, out double parsedNumber))
            {
                SecondNumber = parsedNumber;
            }
            else
            {
                SecondNumberBox.Text = SecondNumberBox.Text.TrimEnd(SecondNumberBox.Text.LastOrDefault());
            }
        }

        private void SecondNumberSlider_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SecondNumberBox.Text = e.NewValue.ToString("N");
        }

        private void IncludeDateCheckBox_OnChecked(object sender, RoutedEventArgs e)
        {
            CalculationDatePicker.Visibility = Visibility.Visible;
            CalculationDatePicker.SelectedDate = DateTime.Now;
        }

        private void IncludeDateCheckBox_OnUnchecked(object sender, RoutedEventArgs e)
        {
            CalculationDatePicker.Visibility = Visibility.Collapsed;
        }

        private void EqualsButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (FirstNumber == null || SecondNumber == null)
            {
                MessageBox.Show("You need to set both numbers to calculate a result.");
                return;
            }

            if (SecondNumber == 0 && SelectedMathFunction == Divide)
            {
                MessageBox.Show("You cannot divide from zero, please pick a different 2nd number.");
                return;
            }

            double result = SelectedMathFunction((double)FirstNumber, (double)SecondNumber);

            if (IncludeDateCheckBox.IsChecked == true)
            {
                ResultsTextBlock.Text = $"Result: {result:N2}, Date: {CalculationDatePicker.SelectedDate:d}";
            }
            else
            {
                ResultsTextBlock.Text = $"Result: {result:N2}";
            }
        }
    }
}