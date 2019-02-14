using Xamarin.Forms;
using StoPyta_JedenOsiemL;
using StoPyta_JedenOsiemL.Droid;
using Xamarin.Forms.Platform.Android;
using Android.Gms.Ads;

[assembly: ExportRenderer(typeof(AdMobView), typeof(AdMobBanner))]

namespace StoPyta_JedenOsiemL.Droid
{
    public class AdMobBanner : ViewRenderer<AdMobView, Android.Gms.Ads.AdView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<AdMobView> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
            {
                var ad = new AdView(Android.App.Application.Context);
                ad.AdSize = AdSize.Banner;
                ad.AdUnitId = "ca-app-pub-4133089494678561/3982703152";

                var requestBuilder = new AdRequest.Builder();
                ad.LoadAd(requestBuilder.Build());
                SetNativeControl(ad);
            }
        }

        public AdMobBanner()
        {

        }
    }
}