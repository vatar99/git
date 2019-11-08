using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TZ
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageTwo : ContentPage
    {
        public PageTwo()
        {
            InitializeComponent();
            this.Title = "PageTwo";
            this.BackgroundColor = Color.AliceBlue;
        }

       public void label ()
        {
            string text = MainEntry.Text;

            
             MainLabel.Text = text;

        }

        async private void Button_Clicked_1(object sender, EventArgs e)
        {
            label();
            await Navigation.PushAsync(new MainPage());

        }

    }
}