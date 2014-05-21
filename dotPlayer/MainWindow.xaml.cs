using Microsoft.Win32;
using System;
using System.Windows;
using dotPlayer.Core;

namespace dotPlayer
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Player videoPlayer = new Player();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLoadFile_Click(object sender, RoutedEventArgs e)
        {
            mScreen.Source = videoPlayer.LoadFile();
        }
    }
}
