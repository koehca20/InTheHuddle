using Android.App;
using Android.Widget;
using Android.OS;
using Android.Webkit;

namespace InTheHuddle
{
	[Activity(Label = "In The Huddle", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			//find rules button on main layout
			Button rulesButton = FindViewById<Button>(Resource.Id.rulesButton);
			//attach activity, when rule button is clicked -- send to rule list activity
			rulesButton.Click += delegate
			{
				StartActivity(typeof(RuleList));
			};

			//find scoring button on main layout
			Button scoringButton = FindViewById<Button>(Resource.Id.scoringButton);
			//attach activity, when scoring button is clicked -- send to score activity
			scoringButton.Click += delegate
			{
				StartActivity(typeof(Score));
			};

			//find teams button on main layout
			Button teamsButton = FindViewById<Button>(Resource.Id.teamsButton);
			//attach activity, when teams button is clicked -- send to team list activity
			teamsButton.Click += delegate 
			{
				StartActivity(typeof(TeamList));
			};
		}
	}
}