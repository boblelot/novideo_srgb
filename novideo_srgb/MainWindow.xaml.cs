﻿using System.Windows;

namespace novideo_srgb
{
    public partial class MainWindow
    {
        private readonly MainViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = (MainViewModel) DataContext;
        }

        private void MonitorRefreshButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _viewModel.UpdateMonitors();
        }

        private void OverrideButton_click(object sender, System.Windows.RoutedEventArgs e)
        {
            new InfoWindow(((FrameworkElement) sender).DataContext as MonitorData).Show();
        }
    }
}