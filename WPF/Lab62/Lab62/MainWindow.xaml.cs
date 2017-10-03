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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab62
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

        private void alice_Click(object sender, RoutedEventArgs e)
        {
            //DoubleAnimation myWidthAnimation = new DoubleAnimation(alice.Width, alice.Width + 50, new Duration(TimeSpan.FromSeconds(1)));
            DoubleAnimation myHeightAnimation = new DoubleAnimation(alice.Height, alice.Height + 25, new Duration(TimeSpan.FromSeconds(2)));

            DoubleAnimation myWidthAnimation = new DoubleAnimation();
            myWidthAnimation.To = alice.Width + 50;
            myWidthAnimation.From = alice.Width;
            myWidthAnimation.Duration = TimeSpan.FromSeconds(1);

            alice.Content = "Alice is getting bigger";

            alice.BeginAnimation(WidthProperty, myWidthAnimation);
            alice.BeginAnimation(HeightProperty, myHeightAnimation);
        }
    }
}
