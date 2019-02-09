using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StoPyta_JedenOsiemL
{
    public partial class MainPage : ContentPage
    {
        private Page page;

        public MainPage()
        {
            InitializeComponent();
            page = new HiddenPage();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(page);
        }
    }

    public class AdMobView : ContentView
    {
        public AdMobView()
        {

        }
    }
}
