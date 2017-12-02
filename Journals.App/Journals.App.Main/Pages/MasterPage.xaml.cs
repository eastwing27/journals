using Journals.App.Extensions;
using Journals.Core;
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
	public partial class MasterPage : CarouselPage
	{
        HtmlWebViewSource bmSource;
        
        public MasterPage ()
		{
			InitializeComponent ();

            bmSource = new HtmlWebViewSource();
        }

        override protected async void OnAppearing()
        {
            var bookmarks = await App.Journals.GetBookmarksAsync();
            
            if (!bookmarks.Success)
            {
                App.Native.Notify(bookmarks.ErrorMessage);
                return;
            }

            var html = bookmarks.Content.GetHtml();

            bmSource.BaseUrl = App.Native.BaseUrl;
            bmSource.Html = html;
            BookmarksWebView.Source = bmSource;

        }
	}
}