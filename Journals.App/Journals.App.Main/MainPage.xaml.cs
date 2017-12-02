using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Journals.App.Pages;

namespace Journals.App
{
    public partial class MainPage : NavigationPage
    {
        public MainPage(Page Page)
            : base(Page)
        {
            InitializeComponent();
        }
    }
}
