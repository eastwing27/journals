using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Journals.App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void OnLoginClick(object sender, EventArgs e)
        {
            var result = await App.Journals.TryInitAsync(entLogin.Text, entPassword.Text);

            if (!result.Success)
            {
                App.Notify(result.ErrorMessage);
                return;
            }
            //TODO: enter to work mode
        }
    }
}
