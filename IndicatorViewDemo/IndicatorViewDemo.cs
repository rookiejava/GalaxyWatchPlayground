using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Tizen;
using Tizen.Wearable.CircularUI.Forms;

namespace IndicatorViewDemo
{
    class Program : FormsApplication
    {
        protected override void OnCreate()
        {
            base.OnCreate();
            LoadApplication(new App());
        }

        static void Main(string[] args)
        {
            var app = new Program();
            Forms.SetFlags("IndicatorView_Experimental");
            Forms.Init(app);
            FormsCircularUI.Init();
            app.Run(args);
        }
    }
}
