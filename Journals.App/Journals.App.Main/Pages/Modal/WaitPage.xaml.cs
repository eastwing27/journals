using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Journals.App.Pages.Modal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WaitPage : ContentPage
	{
		public WaitPage ()
		{
			InitializeComponent ();
		}

        protected override bool OnBackButtonPressed()
        {
            return false;
        }
    }
}