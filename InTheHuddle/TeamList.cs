using Android.App;
using Android.Widget;
using Android.OS;
using Android.Webkit;
using Android.Content;
using Java.IO;

namespace InTheHuddle
{
	[Activity(Label = "NFL Teams")]
	public class TeamList : ListActivity
	{
		string[] items;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			items = new string[] { "Team 1", "Team 2", "Team 3", "Team 4", "Team 5", "Team 6" };
			ListAdapter = new ListAdapter(this, items);
		}

		protected override void OnListItemClick(ListView l, Android.Views.View v, int position, long id)
		{
			StartActivity(typeof(TeamDetailActivity));
		}
	}
}