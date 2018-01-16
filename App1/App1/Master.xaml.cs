﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : ContentPage
	{
		public Master ()
		{
			InitializeComponent ();

            pageTables.Clicked += async (sender, e) =>
            {
                App.MasterDetail.IsPresented = false;
                await App.NavigateMasterDetail(new xPageTables());
            };

            pagePrognozi.Clicked += async (sender, e) =>
            {
                App.MasterDetail.IsPresented = false;
                await App.NavigateMasterDetail(new xPagePrognozi());
            };

        }
	}
}