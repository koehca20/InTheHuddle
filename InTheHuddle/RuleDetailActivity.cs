﻿
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
	[Activity(Label = "")]
	public class RuleDetailActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			string text = Intent.GetStringExtra("My Data") ?? "Data not available";
			this.Title =text;
			SetContentView(Resource.Layout.RuleDetail);

			WebView lWebView = (WebView)FindViewById(Resource.Id.webView1);


			lWebView.LoadUrl("file:///android_asset/"+text+".html");
		}
	}
}
