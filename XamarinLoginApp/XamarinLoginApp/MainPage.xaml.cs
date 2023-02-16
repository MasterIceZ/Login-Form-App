using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: ExportFont("Ethan.ttf", Alias ="Ethan")]
[assembly: ExportFont("FCParagraph.ttf", Alias ="Paragraph")]

namespace XamarinLoginApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void handleLoginButton(object sender, EventArgs e)
        {

        }
        async void handleRegisterButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Register());
        }
        async void handleAboutButton(object sender, EventArgs e)
        {
            // Navigation.PushAsync(new About());
        }
    }
}
