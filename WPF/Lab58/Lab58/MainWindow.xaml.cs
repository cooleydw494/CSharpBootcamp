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
using System.Threading;

namespace Lab58
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

        private void moe_Click(object sender, RoutedEventArgs e)
        {
            stoogeTalk.Text = "Shut up, Curly!";
        }

        private void larry_Click(object sender, RoutedEventArgs e)
        {
            stoogeTalk.Text = ". . .";
            Thread.Sleep(10000);
            stoogeTalk.Text = "You shut up too, knucklehead!";
        }

        private void curly_Click(object sender, RoutedEventArgs e)
        {
            stoogeTalk.Text = "Nyuk Nyuk";
        }
    }
}
