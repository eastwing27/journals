using Android.Widget;
using Journals.App.Android;
using Journals.App.Droid;
using System;
using Xamarin.Forms;

[assembly: Dependency(typeof(AndroidNative))]
namespace Journals.App.Android
{
    public class AndroidNative : INative
    {
        public string BaseUrl => "file:///android_asset/";

        public Action<string> Notify => 
            message => Toast.MakeText(MainActivity.Instance, message, ToastLength.Long).Show();

    }
}