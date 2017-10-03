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

namespace Lab63
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CommandBinding myBinding = new CommandBinding(ApplicationCommands.New);

            myBinding.Executed += (source, eventArgs) =>
            {
                MessageBox.Show("New command has been executed");
            };

            myBinding.CanExecute += (source, eventArgs) =>
            {
                eventArgs.CanExecute = checkBox.IsChecked != false;
            };

            CommandBindings.Add(myBinding);

            button1.Content = ApplicationCommands.New.Text;
            button2.Content = ApplicationCommands.New.Text;
        }
    }
}
