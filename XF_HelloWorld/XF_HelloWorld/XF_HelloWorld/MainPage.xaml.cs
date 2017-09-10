using System;
using Xamarin.Forms;

namespace XF_HelloWorld
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Button1.Clicked += Button1_Clicked;
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            Label1.Text = "こんにちは Xamarin.Forms";
        }
    }
}
