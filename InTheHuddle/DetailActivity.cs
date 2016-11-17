
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;

namespace InTheHuddle
{
	[Activity(Label = "DetailActivity")]
	public class DetailActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.TeamDetail);

			WebView lWebView = (WebView)FindViewById(Resource.Id.webView1);
			lWebView.LoadUrl("file:///android_asset/test.html");
		}
	}
}
