using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System;

namespace alarm
{
	[Activity(Label = "alarm", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.Main);
			Button button = FindViewById<Button>(Resource.Id.edit);
			button.Click += new EventHandler(button_click);

		}
		void button_click(object sender, System.EventArgs e)
		{
			var intent = new Intent(this, typeof(edit));
			base.StartActivity(intent);
		}

	}
}


