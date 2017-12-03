using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Journals.App.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        async void OnClick(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(App.WaitPage);

            var result = await App.Journals.TryInitAsync(LoginEntry.Text, PasswordEntry.Text);
            if (!result.Success)
            {
                await Navigation.PopModalAsync();
                App.Native.Notify(result.ErrorMessage);
                return;
            }
            Navigation.InsertPageBefore(new MasterPage(), this);
            await Navigation.PopAsync();
        }
    }
}