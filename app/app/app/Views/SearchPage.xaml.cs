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
	public partial class SearchPage : ContentPage
	{

	    private readonly List<string> groups = new List<string>
	    {
            "BAM", "HOLA", "AARG", "Football", "Soccer", "Interns", "Drones", "Pro Sports"
	    };

		public SearchPage ()
		{
			InitializeComponent ();
		    GroupListView.ItemsSource = groups;
		}

	    private void SearchBar_OnSearchButtonPressed(object sender, EventArgs e)
	    {
	        if (String.IsNullOrEmpty(SearchBar.Text))
	        {
	            GroupListView.ItemsSource = groups;
	            return;
	        }

	        string keyword = SearchBar.Text;
	        IEnumerable<string> result = groups.Where(group => group.ToLower().Contains(keyword.ToLower()));
	        GroupListView.ItemsSource = result;
	    }

	    private void GroupListView_OnItemTapped(object sender, ItemTappedEventArgs e)
	    {
	        Navigation.PushAsync(new DetailPage("AARG"));
	    }
	}
}