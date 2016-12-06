using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace InTheHuddle
{
	[Activity(Label = "Score")]
	public class Score : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.ScoreDetail);
			var videoView = FindViewById<VideoView>(Resource.Id.ScoreVideoView);

			var uri = Android.Net.Uri.Parse("https://dl.dropboxusercontent.com/u/46250806/Scoring.mp4");

			videoView.SetVideoURI(uri);
			videoView.Visibility = ViewStates.Visible;
			videoView.Start();
		}
	}
}
