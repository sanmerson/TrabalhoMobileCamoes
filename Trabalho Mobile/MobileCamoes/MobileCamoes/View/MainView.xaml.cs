﻿using System;
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

		private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
		{

		}
	}
}