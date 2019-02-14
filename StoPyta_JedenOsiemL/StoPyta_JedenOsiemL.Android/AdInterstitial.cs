using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Gms.Ads;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using StoPyta_JedenOsiemL.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(AdInterstitial))]

namespace StoPyta_JedenOsiemL.Droid
{
    public class AdInterstitial : IAdInterstitial
    {
        InterstitialAd interstitialAd;

        public AdInterstitial()
        {
            interstitialAd = new InterstitialAd(Android.App.Application.Context);
            interstitialAd.AdUnitId = "ca-app-pub-4133089494678561/4256903420";
            LoadAd();
        }

        void LoadAd()
        {
            var requestbuilder = new AdRequest.Builder();
            interstitialAd.LoadAd(requestbuilder.Build());
        }

        public void ShowAd()
        {
            if (interstitialAd.IsLoaded) interstitialAd.Show();
            LoadAd();
        }
    }
}