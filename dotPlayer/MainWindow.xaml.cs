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
            string mediaFile = videoPlayer.LoadFile();

            if (!mediaFile.Equals(""))
            {
                mScreen.Source = new Uri(mediaFile);
            }            
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            mScreen.Play();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            mScreen.Stop();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            mScreen.Pause();
        }
    }
}
