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
	public partial class HiddenPage : ContentPage
	{
        private Questions questions;

        public HiddenPage ()
		{
			InitializeComponent ();
            questions = new Questions();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            label.Text = questions.GetRandomQuestion();
        }
    }
}