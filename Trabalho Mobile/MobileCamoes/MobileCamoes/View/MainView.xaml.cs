using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileCamoes.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainView : ContentPage
	{
        public MainView ()
		{
			InitializeComponent ();

		}
		private async void ListView_ItemTapped_1(object sender, ItemTappedEventArgs e)
		{
				await Navigation.PushAsync(new DetailVeiw());
			
		}
	}
}