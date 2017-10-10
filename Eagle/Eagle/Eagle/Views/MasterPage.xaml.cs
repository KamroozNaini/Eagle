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
				Title = "New Test",
				IconSource = "Alcoholimetro.jpg",
				TargetType = typeof(NewTestPage)
			});
			masterPageItems.Add (new MasterPageItem {
				Title = "Prev Tests",
				IconSource = "PrevTest.png",
				TargetType = typeof(PrevTestsPage)
			});
			masterPageItems.Add (new MasterPageItem {
				Title = "About Us",
				IconSource = "AboutUs.png",
				TargetType = typeof(AboutPage)
			});

			listView.ItemsSource = masterPageItems;
		}
	}
}
