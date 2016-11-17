using Android.App;
using Android.Widget;
using Android.OS;
using Android.Webkit;

namespace InTheHuddle
{
	[Activity(Label = "RuleList")]
	public class RuleList : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your application here
			SetContentView(Resource.Layout.RuleList);

			WebView RuleListWebView = FindViewById<WebView>(Resource.Id.RuleListWebView);
			// the below code opens a local html file within the assets
			//RuleListWebView.LoadUrl("file:///android_asset/Content/Home.html");
		}
	}
}
