using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StoPyta_JedenOsiemL
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SoftPage : ContentPage
	{
        private SoftQuestions questions;
        private int x = 1;

        public SoftPage ()
		{
			InitializeComponent ();
            questions = new SoftQuestions();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            label.Text = questions.GetRandomQuestion();
            if (x % 10 == 0) DependencyService.Get<IAdInterstitial>().ShowAd();
            if (x > 25) x = 1;
            counter.Text = x + "/25";
            x++;
        }
    }
}