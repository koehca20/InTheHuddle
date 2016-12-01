using Android.App;
using Android.Widget;
using Android.OS;
using Android.Webkit;
using Android.Content;
using Java.IO;

namespace InTheHuddle
{
	[Activity(Label = "NFL Rules")]
	public class RuleList : ListActivity
	{
		string[] items;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			items = new string[] { "Rule 1", "Rule 2", "Rule 3", "Rule 4", "Rule 5", "Rule 6" };
			ListAdapter = new ListAdapter(this, items);
		}

		protected override void OnListItemClick(ListView l, Android.Views.View v, int position, long id)
		{
			StartActivity(typeof(RuleDetailActivity));
		}
	}
}