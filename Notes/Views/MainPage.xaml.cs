using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Firebase.CloudMessaging;

namespace Notes.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    
    private void fcmRefresh_Clicked(object sender, EventArgs e)
    {
        // Get Token from "global store" as this is async and I try to keep it simple
        fcmTokenEntry.Text = App.FcmToken;
        // await DisplayAlert("FCM token", token, "OK");
    }
    
    private async void OnCounterClicked(object sender, EventArgs e)
    {
        string token = "";
        try
        {
            token = await CrossFirebaseCloudMessaging.Current.GetTokenAsync();
            await DisplayAlert("FCM token", token, "OK");
        }
        catch(Exception ex)
        {
            await DisplayAlert("Failed", ex.Message, "OK");
            await DisplayAlert("Failed", "failed", "OK");
        }
    }
}