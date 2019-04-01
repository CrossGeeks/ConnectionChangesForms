using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectionChangeFormsSample.ViewModels;
using ConnectionChangeFormsSample.Views;
using Xamarin.Forms;

namespace ConnectionChangeFormsSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }

        public async void Handle_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainDetailPage());
        }
    }
}
