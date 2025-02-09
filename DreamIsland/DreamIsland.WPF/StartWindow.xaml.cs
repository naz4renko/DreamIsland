using DreamIsland.Logic;
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
using System.Windows.Threading;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace DreamIsland.WPF
{
    /// <summary>
    /// Логика взаимодействия для StartWindow.xaml
    /// </summary>
    public partial class StartWindow : UserControl
    {
        public StartWindow()
        {
            InitializeComponent();
        }


        private void md_MediaOpened(object sender, RoutedEventArgs e)
        {
            pbar.Minimum = 0;
            pbar.Maximum = md.NaturalDuration.TimeSpan.TotalMilliseconds;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            pbar.Value = md.Position.TotalMilliseconds;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Content)
            {
                case "Старт": md.Play(); break;
                case "Пауза": md.Pause(); break;
                case "Стоп": md.Stop(); break;
                default: break;
            }
        }

        private void LoadVideo_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Video Files|*.mp4;*.mkv;*.avi|All Files|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                LoadVideo(filePath);
            }
        }
        private void LoadVideo(string filePath)
        {
            try
            {
                md.Source = new Uri(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки видео: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void pbar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ProgressBar bar = (ProgressBar)sender;
            var a = e.GetPosition(bar);
            double x = a.X;
            double max = bar.ActualWidth;
            double value = x / max;
            double timeValue = value * md.NaturalDuration.TimeSpan.TotalMilliseconds;
            md.Position = TimeSpan.FromMilliseconds(timeValue);
        }
    }
}
