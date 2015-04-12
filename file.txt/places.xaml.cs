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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace myApplication
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class places : Page
    {
        public places()
        {
            this.InitializeComponent();
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void charminar_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(charminar));
        }

        private void zoo_click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(zoo));
        }

        private void filmcity_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(filmcity));
        }

        private void Hussain_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(hussain));
        }

        private void birla_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(birla));
        }

        private void hitex_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(hitex));
        }

        private void mount_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(mount));
        }

       
        private void nr_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(nr));
        }

       
    }
}
