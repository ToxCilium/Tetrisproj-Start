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
        static int compli=0;
        static string change = "";
        public MainPage()
        {

            InitializeComponent();
        }
        private void change_compli(object sender, System.EventArgs e)
        {
            compli++;
            if (compli > 2) compli = 0;
            switch (compli)
            {
                case 0:
                    change = "<Button Text=\"Ez\" TextColor=\"Green\" />";
                    EMH.LoadFromXaml(change);
                    break;
                case 1:
                    change = "<Button Text=\"Medium\" TextColor=\"Yellow\" />";
                    EMH.LoadFromXaml(change);
                    break;
                case 2:
                    change = "<Button Text=\"Hard\" TextColor=\"Red\" />";
                    EMH.LoadFromXaml(change);
                    break;
            }

        }
    }
}
