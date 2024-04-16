using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Views;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
    }
    
    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        //await CrossFirebaseCloudMessaging.Current.CheckIfValidAsync();
        //var token = await CrossFirebaseCloudMessaging.Current.GetTokenAsync();
        await DisplayAlert("FCM token", "ASA", "OK");
    }
}