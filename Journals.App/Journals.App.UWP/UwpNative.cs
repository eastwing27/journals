using Journals.App.UWP;
using System;
using Windows.UI.Popups;
using Xamarin.Forms;

[assembly: Dependency(typeof(UwpNative))]
namespace Journals.App.UWP
{
    class UwpNative : INative
    {
        public string BaseUrl => "ms-appx-web:///";
        public Action<string> Notify => async message =>
            {
                var popup = new MessageDialog(message, Constants.TITLE);
                await popup.ShowAsync();
            };
}
}
