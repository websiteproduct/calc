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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addText(char content)
        {
            char[] operators = new char[] { '+', '-', '×', '÷' };
            int execStrLength = 0;

            //            ввод content или знак операции

            //если test == "" && знак операции в массиве операций, то return
            //иначе если test == "0", то test = content
            //иначе если Exec_Str && знак операции в массиве операций, то Exec_Str.text = "${test} ${content}"
            //иначе если Exec_Str, то
            //иначе если знак операции в массиве операций, то

            //    если Exec_Str, то {
            //                если Exec_Str[Exec_Str.length - 1] в массиве операций, то Exec_Str.text = "${test} ${content}"

            //    }
            //            иначе Exec_Str.text = "${test} ${content}"
            //иначе если Exec_Str[Exec_Str.length - 1] в массиве операций, то test.text = content
            //иначе
            //test.text += content

            //0 +

            if (test.Text == "0")
            {
                test.Text = content.ToString();
            }
            else if (Array.Exists(operators, element => element == content))
            {
                execStrLength = Exec_Str.Text.Length;
                if (execStrLength >= 2 && Array.Exists(operators, element => element == Exec_Str.Text[execStrLength - 2]))
                {
                    Exec_Str.Text = test.Text;
                    test.Text
                }
                //if (Exec_Str.Text[Exec_Str.Text.Length - 1] == '+')
                if (execStrLength >= 2 && Array.Exists(operators, element => element == Exec_Str.Text[execStrLength - 2]))
                {
                    StringBuilder sb = new StringBuilder(Exec_Str.Text);
                    sb[execStrLength] = content;

                    //Exec_Str.Text[Exec_Str.Text.Length - 2] = content;
                }
                else Exec_Str.Text = Exec_Str.Text + " " + content + " ";
            }
            else
            {
                test.Text += content;
                //Exec_Str.Text += content;
            }
        }

        private void Button_Click(object content)
        {
            if (test.Text == "0")
            {
                test.Text = content.ToString();
            }
            else
            {
                test.Text += content.ToString();
            }
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
                default:
                    return;
            }
            addText(digit);
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
            if (Convert.ToInt32(test.Text) > 0)
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
        }
    }
}
