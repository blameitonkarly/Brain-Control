using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Magneto_Xamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class menuPage : ContentPage
	{
		public menuPage ()
		{
			InitializeComponent ();
		}
        private async void Main_onClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        private async void Page1_onClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
        private async void About_onClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }
        private async void Setting_onClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsPage());
        }
        private async void Contact_onClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new contactPage());
        }
    }
}