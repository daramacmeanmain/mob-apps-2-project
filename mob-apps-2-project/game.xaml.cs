using System;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace mob_apps_2_project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class game : Page
    {
        int playCount = 1;

        public game()
        {
            this.InitializeComponent();

        }

        private void h_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Message.Visibility = Visibility.Visible;

            if (playCount == 2 || playCount == 3 || playCount == 8 || playCount == 9 || playCount == 13 || playCount == 15)
            {
                Message.Text = "Correct";
                playCount++;
            }

            else
            {
                Message.Text = "Incorrect";
            }

            //playCount++;
        }

        private void hl_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Message.Visibility = Visibility.Visible;

            if (playCount == 12 || playCount == 19 || playCount == 22)
            {
                Message.Text = "Correct";
                playCount++;
            }

            else
            {
                Message.Text = "Incorrect";
            }

            
        }

        private void mgs_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Message.Visibility = Visibility.Visible;

            if (playCount == 6 || playCount == 10 || playCount == 20)
            {
                Message.Text = "Correct";
                playCount++;
            }

            else
            {
                Message.Text = "Incorrect";
            }

            
        }

        private void st_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Message.Visibility = Visibility.Visible;

            if (playCount == 1 || playCount == 5 || playCount == 11 || playCount == 16 || playCount == 18)
            {
                Message.Text = "Correct";
                playCount++;
            }

            else
            {
                Message.Text = "Incorrect";
            }

            
        }

        private void sw_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Message.Visibility = Visibility.Visible;

            if (playCount == 4 || playCount == 7 || playCount == 14 || playCount == 17 || playCount == 21 || playCount == 23)
            {
                Message.Text = "Correct";
                playCount++;
            }

            else
            {
                Message.Text = "Incorrect";
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
                    h_elite.Play();
                    break;
                case 3:
                    h_over.Play();
                    break;
                case 4:
                    sw_chewy.Play();
                    break;
                case 5:
                    st_chirp.Play();
                    break;
                case 6:
                    mgs_go.Play();
                    break;
                case 7:
                    sw_blaster.Play();
                    break;
                case 8:
                    h_rifle.Play();
                    break;
                case 9:
                    h_ban.Play();
                    break;
                case 10:
                    mgs_found.Play();
                    break;
                case 11:
                    st_bridge.Play();
                    break;
                case 12:
                    hl_energy.Play();
                    break;
                case 13:
                    h_camo.Play();
                    break;
                case 14:
                    sw_r2d2.Play();
                    break;
                case 15:
                    h_warthog.Play();
                    break;
                case 16:
                    st_transbeep.Play();
                    break;
                case 17:
                    sw_wilhelm.Play();
                    break;
                case 18:
                    st_alien.Play();
                    break;
                case 19:
                    hl_cb.Play();
                    break;
                case 20:
                    mgs_call.Play();
                    break;
                case 21:
                    sw_lightsaber.Play();
                    break;
                case 22:
                    hl_phys.Play();
                    break;
                case 23:
                    sw_alarm.Play();
                    break;
            }
        }
    }
}
