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

        }

        private void ButPalka_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButUmnozhenie_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButMinus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButPlus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButRovno_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
