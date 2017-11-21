using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Journals.App.UWP
{
    public sealed partial class MainPage
    {
        Natives natives => new Natives()
        {
            Notify = async message =>
            {
                var popup = new MessageDialog(message, Constants.TITLE);
                await popup.ShowAsync();
            }
        };

        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new Journals.App.App(natives));
        }
    }
}
