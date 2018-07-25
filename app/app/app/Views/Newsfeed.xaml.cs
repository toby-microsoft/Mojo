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
	public partial class Newsfeed : MasterDetailPage
	{
        public List<NewsfeedMenuItems> menuList { get; set; }

		public Newsfeed ()
		{
            InitializeComponent();
            menuList = new List<NewsfeedMenuItems>();
            menuList.Add(new NewsfeedMenuItems(){
                Title = "Home"
            });
            menuList.Add(new NewsfeedMenuItems() {
                Title = "Chat" 
            });
            menuList.Add(new NewsfeedMenuItems()
            {
                Title = "Create"
            });
            navigationDrawerList.ItemsSource = menuList;
        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (NewsfeedMenuItems)e.SelectedItem;
            DisplayAlert("item", item.Title, "ok");
        }
	}
}