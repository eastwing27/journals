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
	public partial class BookmarksPage : ContentPage
	{
        HtmlWebViewSource bmSource;
        string html;

		public BookmarksPage (string html)
		{
			InitializeComponent ();

            this.html = html;
            bmSource = new HtmlWebViewSource();
        }

        override protected void OnAppearing()
        {
            bmSource.BaseUrl = App.Native.BaseUrl;
            bmSource.Html = html;
            BookmarksWebView.Source = bmSource;

        }
    }
}