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
    public partial class PageTree : ContentPage
    {
        public PageTree()
        {
            InitializeComponent();
            this.Title = "PageTree";
            this.BackgroundColor = Color.AliceBlue;
        }
        private void MainLabels(object sender, EventArgs e)
        {
            Label a = new Label();
            a.Text = Convert.ToString(a);
        }
    }
}