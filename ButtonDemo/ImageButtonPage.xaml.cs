using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ButtonDemo
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageButtonPage : ContentPage
    {
        int num;
        public ImageButtonPage()
        {
            InitializeComponent();
            num = 0;
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            label.Text = "Clicked:"+ num++;
        }
    }
}