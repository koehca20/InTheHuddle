﻿
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;

namespace InTheHuddle
{
	[Activity(Label = "")]
	public class PlayerPositionsDetailActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.TeamDetail);

			WebView lWebView = (WebView)FindViewById(Resource.Id.webView1);
			lWebView.LoadUrl("file:///android_asset/Player Positions.html");
		}
	}
}