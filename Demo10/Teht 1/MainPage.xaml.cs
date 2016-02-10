using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Teht_1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            ApplicationView.PreferredLaunchWindowingMode
               = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            ApplicationView.PreferredLaunchViewSize = new Size(450, 350);

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)milkCheckBox.IsChecked)
            {
                Debug.WriteLine("milk");
            }
            if ((bool)butterCheckBox.IsChecked)
            {
                Debug.WriteLine("butter");
            }
            if ((bool)beerCheckBox.IsChecked)
            {
                Debug.WriteLine("beer");
            }
            if ((bool)chickenCheckBox.IsChecked)
            {
                Debug.WriteLine("chicken");
            }
            if ((bool)lemonadeCheckBox.IsChecked)
            {
                Debug.WriteLine("lemonade");
            }



        }
    }
}
