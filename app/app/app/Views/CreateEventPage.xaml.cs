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
	public partial class CreateEventPage : ContentPage
	{
		public CreateEventPage ()
		{
			InitializeComponent ();
		}

	    private void SubmitProcedure(object sender, EventArgs e)
	    {
	        DisplayAlert("Created!", "You've Successfully created your event!", "Okay");
	    }

    }
}