using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Security.Cryptography;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage;
using Windows.UI;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace mob_apps_2_project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class game : Page
    {
        int playCount = 1;
        int userScore = 0;

        public game()
        {
            this.InitializeComponent();
            makeFile();
            readFile();
        }

        private async void makeFile()
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            StorageFile playlists = await storageFolder.CreateFileAsync("score.txt", CreationCollisionOption.OpenIfExists);
        }

        private async void readFile()
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            StorageFile scoreFile = await storageFolder.GetFileAsync("score.txt");
            var highScores = await FileIO.ReadLinesAsync(scoreFile);
            
            int high = 0;
            
            foreach (var line in highScores)
            {
                int scoreInt = Convert.ToInt32(line); 

                    if (scoreInt > high)
                        high = scoreInt;
            }

            Score.Text = "Current Score: " + userScore.ToString() + Environment.NewLine + "High Score: " + high;
        }

        private async void h_Tapped(object sender, TappedRoutedEventArgs e)
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            StorageFile scoreFile = await storageFolder.GetFileAsync("score.txt");
            var highScores = await FileIO.ReadLinesAsync(scoreFile);

            int high = 0;

            foreach (var line in highScores)
            {
                int scoreInt = Convert.ToInt32(line);

                if (scoreInt > high)
                    high = scoreInt;
            }

            Message.Visibility = Visibility.Visible;

            if (playCount == 2 || playCount == 3 || playCount == 8 || playCount == 9 || playCount == 13 || playCount == 15)
            {
                Message.Text = "Correct";
                Message.Foreground = new SolidColorBrush(Colors.LightGreen);
                userScore++;
                Score.Text = "Current Score: " + userScore.ToString() + Environment.NewLine + "High Score: " + high;
                Audio.Content = "Play Next Sound"; 
                playCount++;
            }

            else
            {
                Message.Text = "Incorrect";
                Message.Foreground = new SolidColorBrush(Colors.OrangeRed);
                Audio.Visibility = Visibility.Collapsed;
                gameover.Visibility = Visibility.Visible;
                halo.Visibility = Visibility.Collapsed;
                halflife.Visibility = Visibility.Collapsed;
                metalgear.Visibility = Visibility.Collapsed;
                startrek.Visibility = Visibility.Collapsed;
                starwars.Visibility = Visibility.Collapsed;
            }

        }

        private async void hl_Tapped(object sender, TappedRoutedEventArgs e)
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            StorageFile scoreFile = await storageFolder.GetFileAsync("score.txt");
            var highScores = await FileIO.ReadLinesAsync(scoreFile);

            int high = 0;

            foreach (var line in highScores)
            {
                int scoreInt = Convert.ToInt32(line);

                if (scoreInt > high)
                    high = scoreInt;
            }
            Message.Visibility = Visibility.Visible;

            if (playCount == 12 || playCount == 19 || playCount == 22)
            {
                Message.Text = "Correct";
                Message.Foreground = new SolidColorBrush(Colors.LightGreen);
                userScore++;
                Score.Text = "Current Score: " + userScore.ToString() + Environment.NewLine + "High Score: " + high;
                Audio.Content = "Play Next Sound";
                playCount++;
            }

            else
            {
                Message.Text = "Incorrect";
                Message.Foreground = new SolidColorBrush(Colors.OrangeRed);
                Audio.Visibility = Visibility.Collapsed;
                gameover.Visibility = Visibility.Visible;
                halo.Visibility = Visibility.Collapsed;
                halflife.Visibility = Visibility.Collapsed;
                metalgear.Visibility = Visibility.Collapsed;
                startrek.Visibility = Visibility.Collapsed;
                starwars.Visibility = Visibility.Collapsed;
            }

            
        }

        private async void mgs_Tapped(object sender, TappedRoutedEventArgs e)
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            StorageFile scoreFile = await storageFolder.GetFileAsync("score.txt");
            var highScores = await FileIO.ReadLinesAsync(scoreFile);

            int high = 0;

            foreach (var line in highScores)
            {
                int scoreInt = Convert.ToInt32(line);

                if (scoreInt > high)
                    high = scoreInt;
            }

            Message.Visibility = Visibility.Visible;

            if (playCount == 6 || playCount == 10 || playCount == 20)
            {
                Message.Text = "Correct";
                Message.Foreground = new SolidColorBrush(Colors.LightGreen);
                userScore++;
                Score.Text = "Current Score: " + userScore.ToString() + Environment.NewLine + "High Score: " + high;
                Audio.Content = "Play Next Sound";
                playCount++;
            }

            else
            {
                Message.Text = "Incorrect";
                Message.Foreground = new SolidColorBrush(Colors.OrangeRed);
                Audio.Visibility = Visibility.Collapsed;
                gameover.Visibility = Visibility.Visible;
                halo.Visibility = Visibility.Collapsed;
                halflife.Visibility = Visibility.Collapsed;
                metalgear.Visibility = Visibility.Collapsed;
                startrek.Visibility = Visibility.Collapsed;
                starwars.Visibility = Visibility.Collapsed;
            }

            
        }

        private async void st_Tapped(object sender, TappedRoutedEventArgs e)
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            StorageFile scoreFile = await storageFolder.GetFileAsync("score.txt");
            var highScores = await FileIO.ReadLinesAsync(scoreFile);

            int high = 0;

            foreach (var line in highScores)
            {
                int scoreInt = Convert.ToInt32(line);

                if (scoreInt > high)
                    high = scoreInt;
            }

            Message.Visibility = Visibility.Visible;

            if (playCount == 1 || playCount == 5 || playCount == 11 || playCount == 16 || playCount == 18)
            {
                Message.Text = "Correct";
                Message.Foreground = new SolidColorBrush(Colors.LightGreen);
                userScore++;
                Score.Text = "Current Score: " + userScore.ToString() + Environment.NewLine + "High Score: " + high;
                Audio.Content = "Play Next Sound";
                playCount++;
            }

            else
            {
                Message.Text = "Incorrect";
                Message.Foreground = new SolidColorBrush(Colors.OrangeRed);
                Audio.Visibility = Visibility.Collapsed;
                gameover.Visibility = Visibility.Visible;
                halo.Visibility = Visibility.Collapsed;
                halflife.Visibility = Visibility.Collapsed;
                metalgear.Visibility = Visibility.Collapsed;
                startrek.Visibility = Visibility.Collapsed;
                starwars.Visibility = Visibility.Collapsed;
            }

            
        }

        private async void sw_Tapped(object sender, TappedRoutedEventArgs e)
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            StorageFile scoreFile = await storageFolder.GetFileAsync("score.txt");
            var highScores = await FileIO.ReadLinesAsync(scoreFile);

            int high = 0;

            foreach (var line in highScores)
            {
                int scoreInt = Convert.ToInt32(line);

                if (scoreInt > high)
                    high = scoreInt;
            }

            Message.Visibility = Visibility.Visible;

            if (playCount == 4 || playCount == 7 || playCount == 14 || playCount == 17 || playCount == 21 || playCount == 23)
            {
                Message.Text = "Correct";
                Message.Foreground = new SolidColorBrush(Colors.LightGreen);
                userScore++;
                Score.Text = "Current Score: " + userScore.ToString() + Environment.NewLine + "High Score: " + high;
                Audio.Content = "Play Next Sound";
                playCount++;
            }

            else
            {
                Message.Text = "Incorrect";
                Message.Foreground = new SolidColorBrush(Colors.OrangeRed);
                Audio.Visibility = Visibility.Collapsed;
                gameover.Visibility = Visibility.Visible;
                halo.Visibility = Visibility.Collapsed;
                halflife.Visibility = Visibility.Collapsed;
                metalgear.Visibility = Visibility.Collapsed;
                startrek.Visibility = Visibility.Collapsed;
                starwars.Visibility = Visibility.Collapsed;
            }

            
        }

        private void play_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Message.Visibility = Visibility.Collapsed;

            switch (playCount)
            {
                case 1:
                    st_transporter.Play();
                    break;
                case 2:
                    Audio.Content = "Play Sound";
                    h_elite.Play();
                    break;
                case 3:
                    Audio.Content = "Play Sound";
                    h_over.Play();
                    break;
                case 4:
                    Audio.Content = "Play Sound";
                    sw_chewy.Play();
                    break;
                case 5:
                    Audio.Content = "Play Sound";
                    st_chirp.Play();
                    break;
                case 6:
                    Audio.Content = "Play Sound";
                    mgs_go.Play();
                    break;
                case 7:
                    Audio.Content = "Play Sound";
                    sw_blaster.Play();
                    break;
                case 8:
                    Audio.Content = "Play Sound";
                    h_rifle.Play();
                    break;
                case 9:
                    Audio.Content = "Play Sound";
                    h_ban.Play();
                    break;
                case 10:
                    Audio.Content = "Play Sound";
                    mgs_found.Play();
                    break;
                case 11:
                    Audio.Content = "Play Sound";
                    st_bridge.Play();
                    break;
                case 12:
                    Audio.Content = "Play Sound";
                    hl_energy.Play();
                    break;
                case 13:
                    Audio.Content = "Play Sound";
                    h_camo.Play();
                    break;
                case 14:
                    Audio.Content = "Play Sound";
                    sw_r2d2.Play();
                    break;
                case 15:
                    Audio.Content = "Play Sound";
                    h_warthog.Play();
                    break;
                case 16:
                    Audio.Content = "Play Sound";
                    st_transbeep.Play();
                    break;
                case 17:
                    Audio.Content = "Play Sound";
                    sw_wilhelm.Play();
                    break;
                case 18:
                    Audio.Content = "Play Sound";
                    st_alien.Play();
                    break;
                case 19:
                    Audio.Content = "Play Sound";
                    hl_cb.Play();
                    break;
                case 20:
                    Audio.Content = "Play Sound";
                    mgs_call.Play();
                    break;
                case 21:
                    Audio.Content = "Play Sound";
                    sw_lightsaber.Play();
                    break;
                case 22:
                    Audio.Content = "Play Sound";
                    hl_phys.Play();
                    break;
                case 23:
                    Audio.Content = "Play Sound";
                    sw_alarm.Play();
                    break;
                case 24:
                    Audio.Visibility = Visibility.Collapsed;
                    halo.Visibility = Visibility.Collapsed;
                    halflife.Visibility = Visibility.Collapsed;
                    metalgear.Visibility = Visibility.Collapsed;
                    startrek.Visibility = Visibility.Collapsed;
                    starwars.Visibility = Visibility.Collapsed;
                    win.Visibility = Visibility.Visible;
                    break;
            }
        }

        private async void gameover_Tapped(object sender, TappedRoutedEventArgs e)
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            StorageFile scoreFile = await storageFolder.CreateFileAsync("score.txt", CreationCollisionOption.OpenIfExists);

            await FileIO.AppendTextAsync(scoreFile, userScore.ToString() + Environment.NewLine);

            Frame.Navigate(typeof(MainPage), UriKind.Relative);
        }
    }
}
