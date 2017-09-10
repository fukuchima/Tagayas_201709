using Android.App;
using Android.Widget;
using Android.OS;

namespace XA_HelloWorld
{
    [Activity(Label = "XA_HelloWorld", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button btn = FindViewById((Resource.Id.button1)) as Button;

            btn.Click += (object sender, System.EventArgs e) =>
            {
                var mesText = FindViewById<TextView>(Resource.Id.textView1);
                mesText.Text = "こんにちは Xamarin.Android";
            };
        }
    }
}

