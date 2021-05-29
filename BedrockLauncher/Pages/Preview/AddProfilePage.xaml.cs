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
using BedrockLauncher.Methods;

namespace BedrockLauncher.Pages.Preview
{
    /// <summary>
    /// Логика взаимодействия для WelcomePageOne.xaml
    /// </summary>
    public partial class AddProfilePage : Page
    {
        public AddProfilePage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            ViewModels.LauncherModel.Default.SetOverlayFrame(null, false, false);
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (ProfileNameTextbox.Text.Length >= 1) { CreateProfile(ProfileNameTextbox.Text); };
            }
        }

        private void CreateProfileButton_Click(object sender, RoutedEventArgs e)
        {
            if (ProfileNameTextbox.Text.Length >= 1) { CreateProfile(ProfileNameTextbox.Text); };
        }
        public void CreateProfile(string profileName)
        {
            if (ConfigManager.CreateProfile(profileName))
            {
                Properties.LauncherSettings.Default.CurrentProfile = profileName;
                Properties.LauncherSettings.Default.Save();
                ViewModels.LauncherModel.Default.SetOverlayFrame(null, false, false);
            }
            else
            {
                CreateProfileText.SetResourceReference(TextBlock.TextProperty, "NewProfile_CreateProfileText_Error");
                CreateProfileText.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Red);
            }
        }
    }
}
