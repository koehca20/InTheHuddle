﻿using Android.App;
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
			switch (position)
			{
				case 0:
					StartActivity(typeof(RuleGlossary));
					break;
				case 1:
					StartActivity(typeof(Penalties));
					break;
				case 2:
					StartActivity(typeof(PlayerPositions));
					break;
			}
		}
	}
}