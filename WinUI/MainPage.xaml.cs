using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Syncfusion.UI.Xaml.Grids.ScrollAxis;
using Syncfusion.UI.Xaml.DataGrid;
using Syncfusion.UI.Xaml.TreeGrid.Helpers;
using Syncfusion.UI.Xaml.TreeGrid;
using System.Globalization;
using Syncfusion.UI.Xaml.Grids;
using Microsoft.UI;
using Microsoft.UI.Xaml.Media.Imaging;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI_TreeGrid
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
    }
    class StringToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string imageName = value.ToString();
            if (imageName == "US.jpg")
            {
                Uri uri = new Uri("ms-appx:///Images/US.jpg");
                BitmapImage image = new BitmapImage(uri);
                return image;
            }

            else if (imageName == "UK.jpg")
            {
                Uri uri1 = new Uri("ms-appx:///Images/UK.jpg");
                BitmapImage image = new BitmapImage(uri1);
                return image;
            }

            else
            {
                Uri uri1 = new Uri("ms-appx:///Images/Japan.jpg");
                BitmapImage image = new BitmapImage(uri1);
                return image;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
