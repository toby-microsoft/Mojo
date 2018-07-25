using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using app.Models;

namespace app.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewsfeedItems : ContentPage
	{
		public NewsfeedItems ()
		{
			InitializeComponent ();
            MainListView.ItemsSource = new List<NewsfeedListTemplate>
            {
               new NewsfeedListTemplate
               {
                Name = "HOLA in WA Social Hour",
                    Description = "Social hour for HOLA members",
                    Location = "Building 92 Visitor Center",
                    Date = "8/6/2018",
                    Time = "5pm - 8pm",
                    OrderNumber = 1
               },
               new NewsfeedListTemplate
               {
                   Name = "Asian American Resource Group Quarterly Meeting",
                   Description = "Meeting to introduce new officers and welcome new" +
                   " members",
                   Location = "Building 83/Atrium",
                   Date = "8/1/2018",
                   Time = "3pm - 4pm",
                   OrderNumber = 2
               },
                new NewsfeedListTemplate
                {
                    Name = "Flag Football",
                    Description = "Anyone is invited come to come flag football",
                    Location = "Microsoft soccer fields",
                    Date = "8/5/2018",
                    Time = "10am - 12pm",
                    OrderNumber = 3
               },
               new NewsfeedListTemplate
               {
                   Name = "Iris Team for Burgers",
                   Description = "If you want to come hang out with the Iris team and" +
                   " get some burgers, join this event!",
                   Location = "The Tipsy Cow",
                   Date = "8/5/2018",
                   Time = "6pm-9pm",
                   OrderNumber = 4
               },
               new NewsfeedListTemplate
               {
                   Name = "MKG Team Outing",
                   Description = "Team building event for MKG Employees",
                   Location = "Pike Place Market",
                   Date = "8/17/2018",
                   Time = "9am-3pm",
                   OrderNumber = 5
               },
               new NewsfeedListTemplate
               {
                    Name = "Sand Volleyball",
                    Description = "Come out and enjoy the summer with some sand volleyball!",
                    Location = "Microsoft Sand Volleyball Courts",
                    Date = "7/27/2018",
                    Time = "4pm-6pm",
                    OrderNumber = 6
               }
            };

		}

        async private void MainListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Selected = e.Item as NewsfeedListTemplate;

            switch (Selected.OrderNumber)
            {
                case 1:
                    await Navigation.PushAsync(new EventPage());
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
            }

            ((ListView)sender).SelectedItem = null;
        }

    }
}