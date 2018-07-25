using app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        async void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckLoginInfo())
            {
                DisplayAlert("Login", "Login Success", "Ok");
                Application.Current.MainPage = new DetailPage();
            }
            else
            {
                DisplayAlert("Login", "Login Not Correct", "Ok");
            }

        }
	}
}