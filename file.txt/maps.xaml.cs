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
using Windows.Devices.Geolocation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace myApplication
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class maps : Page
    {
        Geolocator geo = null;

        public maps()
        {
            this.InitializeComponent();
        }

        private async void geolocator(
            object sender, RoutedEventArgs e)
        {
            if (geo == null)
            {
                geo = new Geolocator();
            }

            double latitude;
            double longitude;
            double accuracy;

            Geoposition pos = await geo.GetGeopositionAsync();
            latitude =  pos.Coordinate.Point.Position.Latitude;
            longitude = pos.Coordinate.Point.Position.Longitude;
            accuracy = pos.Coordinate.Accuracy;


        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(places));
        }

    }
}
