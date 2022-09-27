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

namespace Calculator_Shovkun_Samkova_PR_2._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        float a, b;
        int count;
        bool znak = true;


        private void But0_Click(object sender, RoutedEventArgs e)
        {
            Text.Text = Text.Text + 0; 
        }

        private void But1_Click(object sender, RoutedEventArgs e)
        {
            Text.Text = Text.Text + 1;
        }

        private void But4_Click(object sender, RoutedEventArgs e)
        {
            Text.Text = Text.Text + 4;
        }

        private void But7_Click(object sender, RoutedEventArgs e)
        {
            Text.Text = Text.Text + 7;
        }

        private void ButC_Click(object sender, RoutedEventArgs e)
        {
            Text.Text = "";
            Label.Content = "";

        }

        private void But_Click(object sender, RoutedEventArgs e)
        {
            Text.Text = Text.Text + ",";
        }

        private void But2_Click(object sender, RoutedEventArgs e)
        {
            Text.Text = Text.Text + 2;
        }

        private void But5_Click(object sender, RoutedEventArgs e)
        {
            Text.Text = Text.Text + 5;
        }

        private void But8_Click(object sender, RoutedEventArgs e)
        {
            Text.Text = Text.Text + 8;
        }

        private void ButStrelra_Click(object sender, RoutedEventArgs e)
        {
            int lenght = Text.Text.Length - 1;
            string text = Text.Text;
            Text.Clear();
            for (int i = 0; i < lenght; i++) ;

        }

        private void But3_Click(object sender, RoutedEventArgs e)
        {
            Text.Text = Text.Text + 3;
        }

        private void But6_Click(object sender, RoutedEventArgs e)
        {
            Text.Text = Text.Text + 6;
        }

        private void But9_Click(object sender, RoutedEventArgs e)
        {
            Text.Text = Text.Text + 9;
        }

        private void ButPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (znak == true)
            {
                Text.Text = "-" + Text.Text;
                znak = false;
            }
            else if (znak == false)
            {
                Text.Text = Text.Text.Replace("-", "");
                znak = true;

            }
        }
            private void ButPalka_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(Text.Text);
            Text.Clear();
            count = 4;
            Label.Content = a.ToString() + "/";
            znak = true;

        }

        private void ButUmnozhenie_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(Text.Text);
            Text.Clear();
            count = 3;
            Label.Content = a.ToString() + "*";
            znak = true;

        }

        private void ButMinus_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(Text.Text);
            Text.Clear();
            count = 2;
            Label.Content = a.ToString() + "-";
            znak = true;

        }

        private void ButPlus_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(Text.Text);
            Text.Clear();
            count = 1;
            Label.Content = a.ToString() + "+";
            znak = true;

        }

        private void ButRovno_Click(object sender, RoutedEventArgs e)
        {
            calculate();
            Label.Content = "";
        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(Text.Text);
                    Text.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(Text.Text);
                    Text.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(Text.Text);
                    Text.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(Text.Text);
                    Text.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }

    }
}
