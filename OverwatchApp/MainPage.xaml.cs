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
using Windows.Data.Json;
using Newtonsoft.Json;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace OverwatchApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    public sealed partial class MainPage : Page
    {
        double DeviceWidth;
        double DeviceHeight;
        
        public Hero SelectedHero;
        private List<Hero> heroes;
        public MainPage()
        {
            this.InitializeComponent();
            heroes = HeroManager.GetHeroes();
            System.Diagnostics.Debug.Write(heroes);
            DeviceWidth = Window.Current.Bounds.Width;
            DeviceHeight = Window.Current.Bounds.Height;
            
            //System.Diagnostics.Debug.Write(DeviceWidth);

            // Grabbing File
            //HeroData = JsonValue.Parse(File.ReadAllText(@"./heroData.json"));
            //System.Diagnostics.Debug.Write(HeroData);
            
        }

        private void nameInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MainNav.IsPaneOpen = !MainNav.IsPaneOpen;
        }

        private void MainNav_Loaded(object sender, RoutedEventArgs e)
        {
            // Menu should be 25% of page width
            double width = (DeviceWidth * 0.25) < 150 ? 150 : (DeviceWidth * 0.25);
            MainNav.OpenPaneLength = width;

            
             
            


        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {

            //System.Diagnostics.Debug.Write(  );
            //SelectedHero = (Hero)e.ClickedItem;
            //System.Diagnostics.Debug.Write(SelectedHero.HeroName);
        }
    }
}
