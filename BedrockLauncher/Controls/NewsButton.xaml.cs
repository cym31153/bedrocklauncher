﻿using System.Windows;

namespace BedrockLauncher.Controls
{
    /// <summary>
    /// Interaction logic for NewsButton.xaml
    /// </summary>
    public partial class NewsButton : ToolbarButtonBase
    {

        public NewsButton()
        {
            InitializeComponent();
        }

        private void SideBarButton_Click(object sender, RoutedEventArgs e)
        {
            ToolbarButtonBase_Click(this, e);
            //ViewModels.MainViewModel.MainThread.ButtonManager_Base(this.Name);
        }
    }
}
