using MobileCamoes.Model;
using MobileCamoes.ViewModel;
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
	public partial class DetailVeiw : ContentPage
	{
		public DetailVeiw(Serie serie)
		{
			BindingContext = new DetailViewModel(serie);
			InitializeComponent ();
		}
	}
}