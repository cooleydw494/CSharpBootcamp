﻿using System;
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
using System.IO;
using Microsoft.Win32;
using System.Threading;
using System.Windows.Threading;

namespace BellRingers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ContextMenu windowContextMenu = null;

        public MainWindow()
        {
            InitializeComponent();
            Reset();

            MenuItem saveMemberMenuItem = new MenuItem();
            saveMemberMenuItem.Header = "Save Member Details";
            saveMemberMenuItem.Click += new RoutedEventHandler(saveMember_Click);

            MenuItem clearFormMenuItem = new MenuItem();
            clearFormMenuItem.Header = "Clear Form";
            clearFormMenuItem.Click += new RoutedEventHandler(clear_Click);

            windowContextMenu = new ContextMenu();
            windowContextMenu.Items.Add(saveMemberMenuItem);
            windowContextMenu.Items.Add(clearFormMenuItem);
        }

        private void saveData(string fileName, Member member)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine($"First Name: {member.FirstName}\r\nLastName: {member.LastName}\r\nTower: {member.TowerName}");
                writer.WriteLine($"Captain: {member.IsCaptain.ToString()}\r\nMember Since: {member.MemberSince.ToString()}\r\nMethods: ");
                foreach (string method in member.Methods)
                {
                    writer.WriteLine(method);
                }
                Thread.Sleep(10000);
                Action action = new Action(() =>
                {
                    status.Items.Add("Member details saved");
                });
                Dispatcher.Invoke(action, DispatcherPriority.ApplicationIdle);
            }
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

        //private void add_Click(object sender, RoutedEventArgs e)
        //{
        //    string nameAndTower = $"Member name: {firstName.Text} {lastName.Text} from the tower at {towerNames.Text} rings the following methods: ";
        //    StringBuilder addMessage = new StringBuilder(nameAndTower);
        //    foreach (CheckBox cb in methods.Items)
        //    {
        //        if (cb.IsChecked.Value == true)
        //        {
        //            addMessage.Append(cb.Content.ToString());
        //        }
        //    }
        //    MessageBox.Show(addMessage.ToString(), "Member Information");
        //}

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

        private void newMember_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            saveMember.IsEnabled = true;
            firstName.IsEnabled = true;
            lastName.IsEnabled = true;
            towerNames.IsEnabled = true;
            isCaptain.IsEnabled = true;
            memberSince.IsEnabled = true;
            yearsExperience.IsEnabled = true;
            methods.IsEnabled = true;
            clear.IsEnabled = true;

            this.ContextMenu = windowContextMenu;
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void saveMember_Click(object sender, RoutedEventArgs e)
        {
            Member member = new Member();
            member.FirstName = firstName.Text;
            member.LastName = lastName.Text;
            member.TowerName = towerNames.Text;
            member.IsCaptain = isCaptain.IsChecked.Value;
            member.MemberSince = memberSince.SelectedDate.Value;
            member.Methods = new List<string>();
            foreach (CheckBox cb in methods.Items)
            {
                if (cb.IsChecked.Value)
                {
                    member.Methods.Add(cb.Content.ToString());
                }
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "txt";
            saveDialog.AddExtension = true;
            saveDialog.FileName = "Members";
            saveDialog.InitialDirectory = @"C:\Users\David\Documents\";
            saveDialog.OverwritePrompt = true;
            saveDialog.Title = "Bell Ringers";
            saveDialog.ValidateNames = true;

            if (saveDialog.ShowDialog().Value)
            {
                Thread workerThread = new Thread(O => this.saveData(saveDialog.FileName, member));
                workerThread.Start();
            }
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            About aboutWindow = new About();
            aboutWindow.ShowDialog();
        }

        private void clearName_Click(object sender, RoutedEventArgs e)
        {
            firstName.Clear();
            lastName.Clear();
        }
    }
}
