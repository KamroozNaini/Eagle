using System.Collections.Generic;
using Xamarin.Forms;

namespace Eagle
{
	public partial class MasterPage : ContentPage
	{
		public ListView ListView { get { return listView; } }

		public MasterPage ()
		{
			InitializeComponent();

			var masterPageItems = new List<MasterPageItem> ();
			masterPageItems.Add (new MasterPageItem {
				Title = "Test",
				IconSource = "contacts.png",
				TargetType = typeof(TestPage)
			});
			masterPageItems.Add (new MasterPageItem {
				Title = "Prev Tests",
				IconSource = "PrevTest.png",
				TargetType = typeof(PrevTestsPage)
			});
			masterPageItems.Add (new MasterPageItem {
				Title = "About",
				IconSource = "reminders.png",
				TargetType = typeof(AboutPage)
			});

			listView.ItemsSource = masterPageItems;
		}
	}
}
