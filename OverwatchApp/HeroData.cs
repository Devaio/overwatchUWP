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

namespace OverwatchApp
{
    
    public class Hero
    {
        public string HeroName { get; set; }
        //ublic string CompositionName { get; set; }
        //ublic DateTime ReleaseDateTime { get; set; }
    }
    public class HeroManager
    {
        public static JsonValue HeroData;
        public static List<Hero> GetHeroes()
        {
            
            var heroes = new List<Hero>();

            HeroData = JsonValue.Parse(File.ReadAllText(@"./heroData.json"));
            //HeroData.GetArray().ToList;


            heroes.Add(new Hero
            {
                HeroName = "Winston",

            });
            heroes.Add(new Hero
            {
                HeroName = "Reinhardt",

            });
            heroes.Add(new Hero
            {
                HeroName = "Mei",

            });

            return heroes;
        }


    }

        //public class HeroViewModel
        //{
        //    private Hero defaultHero = new Hero();
        //    public Hero DefaultHero { get { return this.defaultHero; } }
        //}
    
}
