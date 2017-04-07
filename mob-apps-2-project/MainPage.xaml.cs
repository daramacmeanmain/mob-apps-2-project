using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace mob_apps_2_project
{
    /// <summary>
    /// Main menu page to for starting the game
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //Initialise page
        public MainPage()
        {
            this.InitializeComponent();
        }

        //Takes player to the game page
        private void Start_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(game));
        }
    }
}
