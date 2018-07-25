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
	public partial class EventPage : ContentPage
	{
		public EventPage ()
		{
			InitializeComponent ();

            MemberListView.ItemsSource = new List<Member>
            {
               new Member
               {
                    Name = "Laure H.",
                    Description = "Organizer",
                    MemberNumber = 1
                   
               },
               new Member
               {
                    Name = "Michelle H.",
                    Description = "member",
                    MemberNumber = 2
               },
               new Member
               {
                    Name = "Abe S.",
                    Description = "member",
                    MemberNumber = 3

               },
               new Member
               {
                    Name = "David C.",
                    Description = "member",
                    MemberNumber = 4

               },
               new Member
               {
                    Name = "Joey B.",
                    Description = "member",
                    MemberNumber = 5

               },
               new Member
               {
                    Name = "Stephanie M.",
                    Description = "member",
                    MemberNumber = 6

               },

            };
        }

        async private void MemberList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Selected = e.Item as Member;

            switch (Selected.MemberNumber)
            {
                case 1:
                    await Navigation.PushAsync(new ChatPage());
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }

    ((ListView)sender).SelectedItem = null;
        }

        private void AcceptEvent(object sender, EventArgs e)
        {
            DisplayAlert("Accepted", "You have officially been registered", "Ok");
        }

        private void DeclineEvent(object sender, EventArgs e)
        {
            DisplayAlert("Declined", "You have declined the event", "Ok");
        }
	}
}