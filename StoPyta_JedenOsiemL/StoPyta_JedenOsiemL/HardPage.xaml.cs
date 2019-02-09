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
	public partial class HardPage : ContentPage
	{
        private HardQuestions questions;
        private int x = 1;

        public HardPage ()
		{
			InitializeComponent ();
            questions = new HardQuestions();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            label.Text = questions.GetRandomQuestion();
            if (x > 75) x = 1;
            counter.Text = x + "/75";
            x++;
        }
    }
}