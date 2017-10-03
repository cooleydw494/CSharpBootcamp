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

namespace Lab65
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

        private void cmdAnswer_Click(object sender, RoutedEventArgs e)
        {
            textAnswer.Text = "...";
            Cursor = Cursors.Wait;
            Thread.Sleep(TimeSpan.FromSeconds(1));
            AnswerGenerator generator = new AnswerGenerator();
            textAnswer.Text = generator.GetRandomAnswer(textQuestion.Text);
            Cursor = null;
        }
    }
}
