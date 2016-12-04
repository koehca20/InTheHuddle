using Android.App;
using Android.Widget;
using Android.OS;
using Android.Webkit;
using Android.Content;
using Java.IO;

namespace InTheHuddle
{
	[Activity(Label = "Player Positions")]
	public class PlayerPositions : ListActivity
	{
		string[] items;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			items = new string[] { "Offensive Positions", "Defensive Positions", "Special Positions" };
			ListAdapter = new ListAdapter(this, items);
		}

		protected override void OnListItemClick(ListView l, Android.Views.View v, int position, long id)
		{
			switch (position)
			{
				case 0:
					StartActivity(typeof(PlayerPositionsDetailActivity));
					break;
				case 1:
					StartActivity(typeof(PlayerPositionsDetailActivity));
					break;
				case 2:
					StartActivity(typeof(PlayerPositionsDetailActivity));
					break;
			}
		}
	}
}