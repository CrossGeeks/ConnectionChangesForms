using System;
using System.Collections.Generic;
using ConnectionChangeFormsSample.ViewModels;
using Xamarin.Forms;

namespace ConnectionChangeFormsSample.Views
{
    public partial class MainDetailPage : ContentPage
    {
        public MainDetailPage()
        {
            InitializeComponent();
            this.BindingContext = new MainDetailPageViewModel();
        }
    }
}
