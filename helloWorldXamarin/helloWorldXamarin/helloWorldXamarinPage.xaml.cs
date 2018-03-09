using System;
using Xamarin.Forms;

namespace helloWorldXamarin
{
    public partial class helloWorldXamarinPage : ContentPage
    {
        public helloWorldXamarinPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked (object sender, EventArgs args)
        {
            string userName = nameEntry.Text;
            string userPassword = passwordEntry.Text;
            DisplayAlert("Hello", $"Hello {userName} your password is {userPassword}", "Cancel");
        }
    }
}
