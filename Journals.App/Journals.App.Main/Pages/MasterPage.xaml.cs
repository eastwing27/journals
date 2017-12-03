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
        
        public MasterPage ()
		{
			InitializeComponent ();
        }

        override protected async void OnAppearing()
        {
            var bookmarks = await App.Journals.GetBookmarksAsync();
            
            if (!bookmarks.Success)
            {
                await Navigation.PopModalAsync();
                App.Native.Notify(bookmarks.ErrorMessage);
                return;
            }

            var bmHtml = bookmarks.Content.GetHtml();

            Children.Add(new BookmarksPage(bmHtml));
            Children.Add(new NewPostPage());
            Children.Add(new MyJournalPage());

            await Navigation.PopModalAsync();
        }
	}
}