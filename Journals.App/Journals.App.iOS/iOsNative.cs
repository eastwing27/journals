using Foundation;
using Journals.App.iOS;
using System;
using Xamarin.Forms;

[assembly: Dependency(typeof(iOsNative))]
namespace Journals.App.iOS
{
    public class iOsNative : INative
    {
        public string BaseUrl => NSBundle.MainBundle.BundlePath;

        public Action<string> Notify => message => {};
    }
}