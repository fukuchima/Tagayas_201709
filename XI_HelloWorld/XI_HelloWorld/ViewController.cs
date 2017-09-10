using System;

using UIKit;

namespace XI_HelloWorld
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            Button1.TouchUpInside += Button1_TouchUpInside; 
        }

        private void Button1_TouchUpInside(object sender, EventArgs e)
        {
            Label1.Text = "こんにちは Xamarin.iOS";
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}