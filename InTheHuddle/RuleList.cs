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

			items = new string[] { "A-Z Terms Glossary", "Penalties", "Player Positions"};
			ListAdapter = new ListAdapter(this, items);
		}

		protected override void OnListItemClick(ListView l, Android.Views.View v, int position, long id)
		{

			var activity2 = new Intent(this, typeof(RuleDetailActivity));
			activity2.PutExtra("My Data",l.GetItemAtPosition(position).ToString());

			StartActivity(activity2);

		}
	}
}