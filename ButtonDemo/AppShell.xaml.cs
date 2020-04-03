using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tizen.Wearable.CircularUI.Forms;

namespace ButtonDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("ButtonStylePage", typeof(ButtonStylePage));
            Routing.RegisterRoute("ImageButtonPage", typeof(ImageButtonPage));
            Routing.RegisterRoute("ContentButtonPage", typeof(ContentButtonPage));
        }
    }
}

