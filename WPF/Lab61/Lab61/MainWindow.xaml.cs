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
using System.Media;

namespace Lab61
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

        private void goButton_Click(object sender, RoutedEventArgs e)
        {
            if (minBox.Text == "" || lapBox.Text == "" || lengthBox.Text == "" || calBox.Text == "")
            {
                textBlock.Text = "Please populate all values...";
                SystemSounds.Beep.Play();
            }
            else
            {
                double min = Convert.ToDouble(minBox.Text);
                double lap = Convert.ToDouble(lapBox.Text);
                double length = Convert.ToDouble(lengthBox.Text);
                double cal = Convert.ToDouble(calBox.Text);

                bool isMinPos = (min >= 0);
                bool isLapPos = (lap >= 0);
                bool isLengthPos = (length >= 0);
                bool isCalPos = (cal >= 0);

                if (isMinPos && isLapPos && isLengthPos && isCalPos)
                {
                    float distance = (float)lap * (float)length * 0.00062137119223733f;
                    float caloriesBurned = ((float)min / 60f) * (float)cal;
                    float pace = ((float)min * 60f) / (float)lap;

                    StringBuilder result = new StringBuilder();

                    result.Append($"Distance completed: {distance:F2} miles");
                    result.Append($"\r\nCalories Burned: {caloriesBurned:F0} calories");
                    result.Append($"\r\nAverage Pace: {pace:F0} seconds/lap");

                    textBlock.Text = result.ToString();
                }
                else
                {
                    textBlock.Text = "Please use positive values!";
                    SystemSounds.Beep.Play();
                }
            }
        }

        private void text_KeyDown(object sender, KeyEventArgs e)
        {
            bool isNumber = ((e.Key >= Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9));
            bool isDelete = (e.Key == Key.Back || e.Key == Key.Delete);
            bool isTab = (e.Key == Key.Tab);
            bool isDecimal = (e.Key == Key.Decimal);

            if (!isNumber && !isDelete && !isTab)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
