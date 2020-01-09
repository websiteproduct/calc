using System;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] operators = new string[] { "+", "-", "×", "÷" };
        private bool t = false;
        private double result = 0;
        private string op = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private double Calc(double a, double b, string operation)
        {
            switch (operation)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "÷":
                    return a / b;
                case "×":
                    return a * b;
                default:
                    return a;
            }
        }

        private void AddText(char content)
        {
            StringBuilder sb = new StringBuilder(execStr.Text);
            int execStrLastIndex = execStr.Text.Length - 1;

            if (content == 'c')
            {
                test.Text = "0";
                execStr.Text = "";
                return;
            }

            if (content == 'b')
            {
                Button_Del_Click(content, new RoutedEventArgs());
                return;
            }

            if (execStr.Text.Length > 0)
            {
                if (!IsNumber(content))
                {
                    execStr.Text += $" {test.Text} {content}";
                    t = false;
                    test.Text = Calc(result, Convert.ToDouble(test.Text), op).ToString();
                    result = Convert.ToDouble(test.Text);
                    op = content.ToString();
                }
                else if (content == '=')
                {
                    t = false;
                    test.Text = Calc(result, Convert.ToDouble(test.Text), GetLastOperation().ToString()).ToString();
                    execStr.Text += $" {test.Text} {content}";
                    result = Convert.ToDouble(test.Text);
                    op = content.ToString();
                }
                else
                {
                    if (t)
                    {
                        test.Text += content.ToString();
                    }
                    else
                    {
                        test.Text = content.ToString();
                        t = true;
                    }
                }
            }
            else
            {
                if (!IsNumber(content))
                {
                    if (test.Text == "0")
                    {
                        execStr.Text = $"0 {content}";
                    }
                    else
                    {
                        execStr.Text = $"{test.Text} {content}";
                        result = Convert.ToDouble(test.Text);
                        op = content.ToString();
                    }
                }
                else if (test.Text != "0")
                {
                    test.Text += content;
                }
                else test.Text = content.ToString();
            }
        }

        private bool IsNumber(char content)
        {
            return !Array.Exists(operators, element => element == content.ToString());
        }

        private bool IsOperation(char content)
        {
            return execStr.Text.Length > 0 && Array.Exists(operators, element => element == execStr.Text[execStr.Text.Length - 1].ToString());
        }

        private char GetLastOperation()
        {
            return execStr.Text[execStr.Text.Length - 1];
        }

        private void Button_Click(object content)
        {
            char calcElem = content.ToString()[0];
            AddText(calcElem);
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(Button_7.Content);
            //if (test.Text == "0")
            //{
            //    test.Text = Button_7.Content.ToString();
            //}
            //else
            //{
            //    test.Text += Button_7.Content.ToString();
            //}
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {

            char digit = ' ';
            switch (e.Key)
            {
                case Key.D1:
                case Key.NumPad1:
                    digit = '1';
                    break;
                case Key.D2:
                case Key.NumPad2:
                    digit = '2';
                    break;
                case Key.D3:
                case Key.NumPad3:
                    digit = '3';
                    break;
                case Key.D4:
                case Key.NumPad4:
                    digit = '4';
                    break;
                case Key.D5:
                case Key.NumPad5:
                    digit = '5';
                    break;
                case Key.NumPad6:
                case Key.D6:
                    digit = '6';
                    break;
                case Key.NumPad7:
                case Key.D7:
                    digit = '7';
                    break;
                case Key.NumPad8:
                case Key.D8:
                    digit = '8';
                    break;
                case Key.NumPad9:
                case Key.D9:
                    digit = '9';
                    break;
                case Key.D0:
                case Key.NumPad0:
                    digit = '0';
                    break;
                case Key.Add:
                case Key.OemPlus:
                    digit = '+';
                    break;
                case Key.Subtract:
                case Key.OemMinus:
                    digit = '-';
                    break;
                case Key.Multiply:
                    digit = '×';
                    break;
                case Key.Divide:
                    digit = '÷';
                    break;
                case Key.Return:
                    digit = '=';
                    break;
                case Key.Escape:
                    digit = 'c';
                    break;
                case Key.Back:
                    digit = 'b';
                    break;
                default:
                    return;
            }
            AddText(digit);
        }

        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(Button_0.Content);
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(Button_1.Content);
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(Button_2.Content);
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(Button_3.Content);
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(Button_4.Content);
        }
        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(Button_5.Content);
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(Button_6.Content);
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(Button_8.Content);
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(Button_9.Content);
        }

        private void Button_Del_Click(object sender, RoutedEventArgs e)
        {
            if (test.Text.Length > 1)
            {
                test.Text = test.Text.Substring(0, test.Text.Length - 1);
            }
            else
            {
                test.Text = "0";
            }
        }

        private void Button_signChange_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(test.Text) > 0)
            {
                test.Text = "-" + test.Text;
            }
            else
            {
                test.Text = test.Text.Substring(1, test.Text.Length - 1);
            }

        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            test.Text = "0";
            execStr.Text = "";
        }

        private void Button_1x_Click(object sender, RoutedEventArgs e)
        {
            if (test.Text == "0")
            {
                test.Text = "Невозможно делить на 0";
            }
            else
            {
                test.Text = (1 / Convert.ToDouble(test.Text)).ToString();
            }
        }

        private void Button_x2_Click(object sender, RoutedEventArgs e)
        {
            test.Text = Math.Pow(Convert.ToInt32(test.Text), 2).ToString();
        }

        private void Button_percent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_sqrt_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(test.Text) > 0)
            {
                test.Text = Math.Sqrt(Convert.ToDouble(test.Text)).ToString();
            }
            else
            {
                test.Text = "nope";
            }
        }

        private void Button_division_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_multiplication_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_minus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_plus_Click(object sender, RoutedEventArgs e)
        {
            AddText('+');
        }

        private void Button_dot_Click(object sender, RoutedEventArgs e)
        {
            if (!test.Text.Contains(","))
            {
                test.Text += ",";
            }
        }
        private void Button_CE_Click(object sender, RoutedEventArgs e)
        {
            test.Text = "0";
            t = false;
        }

        private void EqualBtn_Click(object sender, RoutedEventArgs e)
        {
            AddText('=');
        }
    }
}
