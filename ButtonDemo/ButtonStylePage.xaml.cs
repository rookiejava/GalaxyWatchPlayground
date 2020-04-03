using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;

namespace ButtonDemo
{
    using Xamarin.Forms.PlatformConfiguration;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ButtonStylePage : ContentPage
    {
        public ButtonStylePage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs args)
        {
            var style = GetNextButtonStyle(button.On<Tizen>().GetStyle());
            button.On<Tizen>().SetStyle(style);
            label.Text = style;
        }

        private string GetNextButtonStyle(string style)
        {
            if (style == default(string) || (style == ButtonStyle.Default))
            {
                button.ImageSource = "xamarin.png";
                return ButtonStyle.Circle;
            }
            else if (style == ButtonStyle.Circle)
            {
                //ImageSource doesn't work properly on other button style except default and circle.
                button.ImageSource = "";
                return ButtonStyle.Bottom;
            }
            else if (style == ButtonStyle.Bottom)
            {
                return ButtonStyle.Text;
            }
            else if (style == ButtonStyle.Text)
            {
                return ButtonStyle.SelectMode;
            }
            button.ImageSource = "xamarin.png";
            return ButtonStyle.Default;
        }
    }
}