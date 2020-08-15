using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Magneto_Xamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void NavigateButton_onClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
        private async void menu_onClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new menuPage());
        }
    }

}


