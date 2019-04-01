using System;
using System.ComponentModel;
using Acr.UserDialogs;
using Plugin.Toasts;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ConnectionChangeFormsSample.ViewModels
{
    public class BaseViewModel: INotifyPropertyChanged
    {
        public bool IsNotConnected { get; set; }
        public BaseViewModel()
        {
            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
            IsNotConnected = Connectivity.NetworkAccess != NetworkAccess.Internet; 
        }

        ~BaseViewModel()
        {
            Connectivity.ConnectivityChanged -= Connectivity_ConnectivityChanged;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            IsNotConnected = e.NetworkAccess != NetworkAccess.Internet;

            /*
           DependencyService.Get<IToastNotificator>().Notify(new NotificationOptions()
            {
                Description = "Oops, looks like you don't have internet connection :(",
                Title = "Connection lost"
            });
            if (e.NetworkAccess != NetworkAccess.Internet)
                UserDialogs.Instance.Toast("Oops, looks like you don't have internet connection :(");
            else
                UserDialogs.Instance.Toast("Your internet connection is back :)");*/
        }
    }
}
