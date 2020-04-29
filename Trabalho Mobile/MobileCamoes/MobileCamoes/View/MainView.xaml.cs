using MobileCamoes.Model;
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
			//ListView listView = sender as ListView;
			Serie serie = e.Item as Serie;
			//Serie serie = serie.SelectedItem as Serie;
			await Navigation.PushAsync(new DetailVeiw(serie));
			
		}
	}
}