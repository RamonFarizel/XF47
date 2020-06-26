using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF47
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageViewModel();
        }

        void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            OSAppTheme currentTheme = Application.Current.RequestedTheme;

            if (currentTheme == OSAppTheme.Light)
                Application.Current.UserAppTheme = OSAppTheme.Dark;
            else
                Application.Current.UserAppTheme = OSAppTheme.Light;
        }
    }
}
