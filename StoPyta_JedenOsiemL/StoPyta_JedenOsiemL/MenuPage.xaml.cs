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
	public partial class MenuPage : ContentPage
	{
        private Page softPage;
        private Page hardPage;
        private bool clicked = true;

		public MenuPage()
		{
			InitializeComponent();
            softPage = new SoftPage();
            hardPage = new HardPage();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            clicked = !clicked;
        }

        private void Soft_Button_Clicked(object sender, EventArgs e)
        {
            if (!clicked) Navigation.PushModalAsync(softPage);
            clicked = true;
        }

        private void Hard_Button_Clicked(object sender, EventArgs e)
        {
            if (!clicked) Navigation.PushModalAsync(hardPage);
            clicked = true;
        }
    }
}