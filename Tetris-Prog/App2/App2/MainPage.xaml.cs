using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, System.EventArgs e)
        {
            string xaml = "<Label Text=\"Xamarin Forms\" FontSize=\"24\" TextColor=\"Red\" />";
            lbl.LoadFromXaml(xaml);
        }

    }
}
