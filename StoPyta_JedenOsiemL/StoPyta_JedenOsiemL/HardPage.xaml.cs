using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StoPyta_JedenOsiemL
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HardPage : ContentPage
	{
        private HardQuestions questions;
        private int x = 1;
        private static readonly string dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Rate");
        DirectoryInfo d;

        public HardPage ()
		{
			InitializeComponent ();
            questions = new HardQuestions();
            d = new DirectoryInfo(dir);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            label.Text = questions.GetRandomQuestion();
            if (x % 10 == 0) DependencyService.Get<IAdInterstitial>().ShowAd();
            if (x > 75) x = 1;
            if (x == 75 && !d.Exists)
            {
                Directory.CreateDirectory(dir);
                d = new DirectoryInfo(dir);
                RateUs();
            } 
            counter.Text = x + "/75";
            x++;
        }

        public async Task RateUs()
        {
            var action = await App.Current.MainPage.DisplayAlert("Oceń nas!", "Podziel się z nami swoją oceną naszej aplikacji.", "Wystaw ocenę", "Nie, dziękuję");
            if (action)
            {
                Device.OpenUri(new Uri("https://play.google.com/store/apps/details?id=com.Billog.Studio.StoPyta_JedenOsiemL"));
            }
        }

    }
}