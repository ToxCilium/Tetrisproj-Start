using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StPage : ContentPage
    {
        public StPage()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            button1.Text = "Нажато!!!";
        }
        private async void OnBackButtonPressed(object sender, EventArgs e)
        {
            await PopupNavigation.PushAsync(new PausePop());
        }
    }
}
