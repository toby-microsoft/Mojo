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
	public partial class DetailPage : MasterDetailPage
	{
        public List<DetailPageMenuItems> menuList { get; set; }

		public DetailPage ()
		{
            InitializeComponent();
            menuList = new List<DetailPageMenuItems>();
            menuList.Add(new DetailPageMenuItems(){
                Title = "Search",
                TargetType = typeof(SearchPage),
                OrderNumber = 1
            });
            menuList.Add(new DetailPageMenuItems()
            {
                Title = "Create Event",
                TargetType = typeof(CreateEventPage),
                OrderNumber = 2
            });
            menuList.Add(new DetailPageMenuItems()
            {
                Title = "Create Group",
                OrderNumber = 3
            });
            menuList.Add(new DetailPageMenuItems() {
                Title = "Chat",
                TargetType = typeof(ChatPage),
                OrderNumber = 4
            });
            menuList.Add(new DetailPageMenuItems()
            {
                Title = "Settings",
                OrderNumber = 5
            });
            menuList.Add(new DetailPageMenuItems()
            {
                Title = "About",
                OrderNumber = 6
            });
            navigationDrawerList.ItemsSource = menuList;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(NewsfeedItems)));
        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (DetailPageMenuItems)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
	}
}