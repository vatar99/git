using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TZ
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Label a = new Label();
            var b = a.Text.ToString();
            InitializeComponent();
            this.Title = b;
            this.BackgroundColor = Color.AliceBlue;
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
          await Navigation.PushAsync(new PageTwo());
            await Navigation.PushAsync(new PageTree());
        }
    }
}
