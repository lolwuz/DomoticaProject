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
    [Activity(Label = "SensorsActivity")]
    public class SensorsActivity : Activity
    {
		TimePicker timePicker1;
		Button setTimeStartButton, setTimeEndButton;
		TextView textViewStart, textViewEnd;

		string startTime;
		string endTime;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Sensor);
			ActionBar.Title = "Sensors";
			ActionBar.SetDisplayHomeAsUpEnabled(true);
			ActionBar.SetHomeButtonEnabled(true);

			timePicker1 = FindViewById<TimePicker>(Resource.Id.timePicker1);
			setTimeStartButton = FindViewById<Button>(Resource.Id.buttonStart);
			setTimeEndButton = FindViewById<Button>(Resource.Id.buttonEnd);

			textViewStart = FindViewById<TextView>(Resource.Id.textViewStart);
			textViewEnd = FindViewById<TextView>(Resource.Id.textViewEnd);

			timePicker1.SetIs24HourView(Java.Lang.Boolean.True);

			if (setTimeStartButton != null)
			{
				setTimeStartButton.Click += (sender, e) =>
				{
					startTime = convertPicker();
					textViewStart.Text = convertPicker();
				};
			}

			if (setTimeEndButton != null)
			{
				setTimeEndButton.Click += (sender, e) =>
				{
					endTime = convertPicker();
					textViewEnd.Text = convertPicker();
				};
			}

			//textViewTimerStateValue.Text = DateTime.Now.ToString("h:mm:ss");

         
            // Create your application here
        }

		public string convertPicker()
		{
			String formattedTime = "";
			int hour = timePicker1.Hour;
			String sHour = "00";
			if (hour < 10)
			{
				sHour = "0" + hour;
			}
			else {
				sHour = Convert.ToString(hour);
			}

			int minute = timePicker1.Minute;
			String sMinute = "00";
			if (minute < 10)
			{
				sMinute = "0" + minute;
			}
			else {
				sMinute = Convert.ToString(minute);
			}
			formattedTime = sHour + ":" + sMinute;

			return formattedTime;
		}

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
			if (item.ItemId == Android.Resource.Id.Home)
			{
				Intent mainIntent = new Intent(this, typeof(MainActivity));
				mainIntent.PutExtra("start", startTime);
				mainIntent.PutExtra("end", endTime);
				StartActivityForResult(mainIntent, 1);
				Finish();
			}
            return base.OnOptionsItemSelected(item);
        }
    }
}