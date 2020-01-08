using System;
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


        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D7 || e.Key == Key.NumPad7)
            {
                Button_7_Click(sender, e);
            }
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
                test.Text = test.Text.Substring(1, test.Text.Length-1);
            }
            
        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            test.Text = "0";
        }
    }
}
