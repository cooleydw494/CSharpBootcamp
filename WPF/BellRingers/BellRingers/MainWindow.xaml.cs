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

namespace BellRingers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Reset();
        }

        public void Reset()
        {
            firstName.Text = String.Empty;
            lastName.Text = String.Empty;

            towerNames.Items.Clear();
            foreach (string towerName in towers)
            {
                towerNames.Items.Add(towerName);
            }
            towerNames.Text = towerNames.Items[0] as string;

            methods.Items.Clear();
            CheckBox method = null;
            foreach (string methodName in ringingMethods)
            {
                method = new CheckBox();
                method.Margin = new Thickness(0, 0, 0, 10);
                method.Content = methodName;
                methods.Items.Add(method);
            }

            isCaptain.IsChecked = false;

            novice.IsChecked = true;

            memberSince.Text = DateTime.Today.ToString();
        }

        private string[] towers = { "Great Shevington", "Little Mudford", "Upper Gumtree", "Downley Hatch" };
        private string[] ringingMethods = { "Plain Bob", "Reverse Canterbury", "Grandsire", "Stedman", "Kent Treble Bob",
                                            "Old Oxford Delight", "Windchendon Place", "Norwich Surprise", "Crayford Little Court" };

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            string nameAndTower = $"Member name: {firstName.Text} {lastName.Text} from the tower at {towerNames.Text} rings the following methods: ";
            StringBuilder addMessage = new StringBuilder(nameAndTower);
            foreach (CheckBox cb in methods.Items)
            {
                if (cb.IsChecked.Value == true)
                {
                    addMessage.Append(cb.Content.ToString());
                }
            }
            MessageBox.Show(addMessage.ToString(), "Member Information");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult key = MessageBox.Show(
                "Are you sure you want to quit",
                "Confirm",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question,
                MessageBoxResult.No);
            e.Cancel = (key == MessageBoxResult.No);
        }
    }
}
