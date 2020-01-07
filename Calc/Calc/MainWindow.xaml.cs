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

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            if (test.Text == "0")
            {
                test.Text = Button_7.Content.ToString();
            }
            else
            {
                test.Text += Button_7.Content.ToString();
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D7 || e.Key == Key.NumPad7)
            {
                Button_7_Click(sender, e);
            }
        }
    }
}
