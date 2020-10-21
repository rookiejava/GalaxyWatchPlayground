using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("CuteFont-Regular.ttf")]
[assembly: ExportFont("PTM55FT.ttf")]
[assembly: ExportFont("Dokdo-Regular.ttf")]
[assembly: ExportFont("fa-regular-400.ttf")]

namespace CustomFontDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomFontPage : ContentPage
    {
        public CustomFontPage()
        {
            InitializeComponent();
        }
    }
}