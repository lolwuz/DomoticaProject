
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

namespace Domotica
{
	[Activity(Label = "@string/application_name", MainLauncher = true, Icon = "@drawable/icon", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
	public class WelcomeActivty : Activity
	{
		Button connectButton;
		EditText editTextIp;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Welcome);

			ActionBar.Hide();
			// ActionBar.Title = "SCR Welcome";
			connectButton = FindViewById<Button>(Resource.Id.button1);
			editTextIp = FindViewById<EditText>(Resource.Id.editText1);
			//ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;

			if (connectButton != null)
			{
				connectButton.Click += (sender, e) =>
				{
					var mainActivity = new Intent(this, typeof(MainActivity));
					mainActivity.PutExtra("MyConnectData", editTextIp.Text);
					StartActivity(mainActivity);
				};
			}
		}
	}
}
