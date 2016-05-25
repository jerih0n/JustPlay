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
using Microsoft.Win32;
namespace justPlay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] _allFiles;
        private int _currentFileIndex = 1;
        private int _loadedFilesNumber;
        private bool _multipleFilesLoaded;
        private double _defaultVolume = 0.5;
        private DispatcherTimer _timer;
        private bool _fileLoaded = false;
        private string _path;
        public MainWindow()
        {
            InitializeComponent();
            this._timer = new DispatcherTimer();
            this._timer.Interval = TimeSpan.FromMilliseconds(500);
            movie_slider.IsMoveToPointEnabled = true;
            volume_slider.IsMoveToPointEnabled = true;
            this._timer.Tick += _timer_Tick;
            this.volume_slider.Value = this._defaultVolume;
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            movie_slider.Value = screen.Position.TotalSeconds;
        }

        private void play_Click(object sender, RoutedEventArgs e)
        {
            if (this._fileLoaded)
            {
                screen.Play();
            }

        }

        private void pause_Click(object sender, RoutedEventArgs e)
        {
            if (this._fileLoaded)
            {
                screen.Pause();
            }

        }

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            if (this._fileLoaded)
            {
                screen.Stop();
            }

        }

        private void volume_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            screen.Volume = (double)volume_slider.Value;
        }

        private void movie_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            screen.Position = TimeSpan.FromSeconds(movie_slider.Value);
        }

        private void screen_MediaOpened(object sender, RoutedEventArgs e)
        {
            try
            {
                TimeSpan ts = screen.NaturalDuration.TimeSpan;
                movie_slider.Maximum = ts.TotalSeconds;
                this._timer.Start();

            }
            catch(InvalidOperationException msg)
            {
                MessageBox.Show("Invalid file type loaded. Load only media files!");
                
            }
            
        }

        private void Grid_Drop(object sender, DragEventArgs e)
        {  
            try
            {
                this._path = (string)((DataObject)e.Data).GetFileDropList()[0];
                screen.Source = new Uri(this._path);
                screen.LoadedBehavior = MediaState.Manual;
                screen.UnloadedBehavior = MediaState.Manual;
                screen.Volume = (double)volume_slider.Value;
                screen.Play();
                this._fileLoaded = true;
            }
            catch( Exception msg)
            {
                MessageBox.Show(String.Format("ERROR! {0}", msg.Message));
            }
           
        }

        private void open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Multimedia (*.avi, *.mkv, *.mp4, *mp3) | *.avi;*.mkv;*.mp4;*.mp3;";
            ofd.Multiselect = true;
            try
            {
                ofd.ShowDialog();
                this._allFiles = ofd.FileNames;
                if (this._allFiles.Length == 1)
                {
                    this._path = this._allFiles[0];
                    screen.Source = new Uri(this._path);
                    screen.LoadedBehavior = MediaState.Manual;
                    screen.LoadedBehavior = MediaState.Manual;
                    screen.Volume = (double)volume_slider.Value;
                    screen.Play();
                    this._fileLoaded = true;
                }
                else
                {
                    this._multipleFilesLoaded = true;
                    this._loadedFilesNumber = this._allFiles.Length;
                    this._path = this._allFiles[0];
                    screen.Source = new Uri(this._path);
                    screen.LoadedBehavior = MediaState.Manual;
                    screen.LoadedBehavior = MediaState.Manual;
                    screen.Volume = (double)volume_slider.Value;
                    screen.Play();
                    this._fileLoaded = true;
                }
            }
            catch (Exception)
            {

            }
        }

       

        private void screen_MediaEnded(object sender, RoutedEventArgs e)
        {

            if (this._multipleFilesLoaded == true)
            {
                if (this._currentFileIndex > this._loadedFilesNumber)
                {
                    this._fileLoaded = false;
                    this._path = String.Empty;
                    screen.Stop();

                }
                else
                {
                    this._path = this._allFiles[this._currentFileIndex];
                    screen.Source = new Uri(this._path);
                    screen.LoadedBehavior = MediaState.Manual;
                    screen.LoadedBehavior = MediaState.Manual;
                    screen.Volume = (double)volume_slider.Value;
                    screen.Play();
                    this._fileLoaded = true;
                    this._currentFileIndex = this._currentFileIndex + 1;
                }
            }
            else
            {
                this._fileLoaded = false;
                this._path = String.Empty;
                screen.Stop();
            }
        }
    
    }
}
