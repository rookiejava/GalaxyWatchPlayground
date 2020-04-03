using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TImage = Xamarin.Forms.PlatformConfiguration.TizenSpecific.Image;

namespace ButtonDemo
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContentButtonPage : ContentPage
    {
        int num;

        public ContentButtonPage()
        {
            InitializeComponent();
            num = 0;
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            label.Text = "Clicked:"+ num++;
        }

        private void OnButtonPressed(object sender, EventArgs e)
        {
            TImage.SetBlendColor(buttonBg, Color.Gray);
        }

        private void OnButtonReleased(object sender, EventArgs e)
        {
            TImage.SetBlendColor(buttonBg, Color.Transparent);
        }
    }
}