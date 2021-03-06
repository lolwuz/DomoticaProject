﻿   // Xamarin/C# app voor de besturing van een Arduino (Uno met Ethernet Shield) m.b.v. een socket-interface.
// Dit programma werkt samen met het Arduino-programma DomoticaServer.ino
// De besturing heeft betrekking op het aan- en uitschakelen van een Arduino pin, waar een led aan kan hangen of, 
// t.b.v. het Domotica project, een RF-zender waarmee een klik-aan-klik-uit apparaat bestuurd kan worden.
//
// De app heeft twee modes die betrekking hebben op de afhandeling van de socket-communicatie: "simple-mode" en "threaded-mode" 
// Wanneer het statement    //connector = new Connector(this);    wordt uitgecommentarieerd draait de app in "simple-mode",
// Het opvragen van gegevens van de Arduino (server) wordt dan met een Timer gerealisseerd. (De extra classes Connector.cs, 
// Receiver.cs en Sender.cs worden dan niet gebruikt.) 
// Als er een connector wordt aangemaakt draait de app in "threaded mode". De socket-communicatie wordt dan afgehandeld
// via een Sender- en een Receiver klasse, die worden aangemaakt in de Connector klasse. Deze threaded mode 
// biedt een generiekere en ook robuustere manier van communicatie, maar is ook moeilijker te begrijpen. 
// Aanbeveling: start in ieder geval met de simple-mode
//
// Werking: De communicatie met de (Arduino) server is gebaseerd op een socket-interface. Het IP- en Port-nummer
// is instelbaar. Na verbinding kunnen, middels een eenvoudig commando-protocol, opdrachten gegeven worden aan 
// de server (bijv. pin aan/uit). Indien de server om een response wordt gevraagd (bijv. led-status of een
// sensorwaarde), wordt deze in een 4-bytes ASCII-buffer ontvangen, en op het scherm geplaatst. Alle commando's naar 
// de server zijn gecodeerd met 1 char.
//
// Aanbeveling: Bestudeer het protocol in samenhang met de code van de Arduino server.
// Het default IP- en Port-nummer (zoals dat in het GUI verschijnt) kan aangepast worden in de file "Strings.xml". De
// ingestelde waarde is gebaseerd op je eigen netwerkomgeving, hier, en in de Arduino-code, is dat een router, die via DHCP
// in het segment 192.168.1.x IP-adressen uitgeeft.
// 
// Resource files:
//   Main.axml (voor het grafisch design, in de map Resources->layout)
//   Strings.xml (voor alle statische strings in het interface (ook het default IP-adres), in de map Resources->values)
// 
// De software is verder gedocumenteerd in de code. Tijdens de colleges wordt er nadere uitleg over gegeven.
// 
// Versie 1.2, 16/12/2016
// S. Oosterhaven
// W. Dalof (voor de basis van het Threaded interface)
//
// Groep 2 MAM - App.
// Koen Lukkien, Simon Rijpstra, Sybren Politiek, Sjoerd Politiek, Jorrit Heida en Marten Hoekstra
// 21/1/2016 - Finale Versie Technische assesment.
using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Timers;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content.PM;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Android.Graphics;
using System.Threading.Tasks;

namespace Domotica
{
    [Activity(Label = "@string/application_name", MainLauncher = false, Icon = "@drawable/icon", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]

    public class MainActivity : Activity
    {
        // Variables (components/controls)
        // Controls on GUI
        Button buttonChangePinState;
        public CheckBox button1, button2, button3;
		SeekBar seekBar, seekBarLight;
		public TextView textViewChangePinStateValue, textViewSensorValue, textViewDebugValue,
		textViewPhotoValue, tempMinTextView, lightTextView, textViewStartTime, textViewEndTime, textViewPresentTime;
        Timer timerClock, timerSockets;             // Timers  
        Socket socket = null;                       // Socket   
		Connector connector = null;                 // Connector (simple-mode or threaded-mode.
		// CommandList Variables.
        List<string> commandList = new List<string>();  // List for commands and response places on UI
		int listIndex = 0;
		float minTemp = 0;
        float photoValue = -1;
		bool isGaming = false;
		bool isGamingNow = false;
        // Connection IP from the welcome screen.
        string connectIP;
		string startTime;
		string endTime;
		string startTimeInt;
		string endTimeInt;

	    protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            ActionBar.Title = "Student Room Control";
			ActionBar.SetDisplayHomeAsUpEnabled(true);
			ActionBar.SetHomeButtonEnabled(true); // Enable the back button in the ActionBar.

			connector = new Connector(this); // Activate the Sender and Reciever codes.
			//ActionBar.NavigationMode = ActionBarNavigationMode.Tabs; // Obsulete (should not be used).
			SetContentView(Resource.Layout.Main);          
            buttonChangePinState = FindViewById<Button>(Resource.Id.buttonChangePinState);
			button1 = FindViewById<CheckBox>(Resource.Id.checkBox1);
			button2 = FindViewById<CheckBox>(Resource.Id.checkBox2);
            button3 = FindViewById<CheckBox>(Resource.Id.checkBox3);
   
			// TimeViews
			textViewStartTime = FindViewById<TextView>(Resource.Id.textViewStartTime);
			textViewPresentTime = FindViewById<TextView>(Resource.Id.textViewPresentTime);
			textViewEndTime = FindViewById<TextView>(Resource.Id.textViewEndTime);
			       
            // Sensor view.
            textViewSensorValue = FindViewById<TextView>(Resource.Id.TextViewSensorValue);
            textViewPhotoValue = FindViewById<TextView>(Resource.Id.PhotoresistorValue);
      		
			// Set dynamic values for switching the lights. 
            seekBar = FindViewById<SeekBar>(Resource.Id.minTempSeekBar);
            seekBarLight = FindViewById<SeekBar>(Resource.Id.lightBar);
            tempMinTextView = FindViewById<TextView>(Resource.Id.minTempTextView);
            lightTextView = FindViewById<TextView>(Resource.Id.lightText);

            //UpdateConnectionState(4, "Disconnected");

            // Init commandlist, scheduled by socket timer
            commandList.Add("a"); // Temperature value
            commandList.Add("b"); // PhotoSensor value.
            commandList.Add("q"); // Switch 1
            commandList.Add("w"); // Switch 2
            commandList.Add("e"); // Switch 3

			// Get the connect IP from the welcome screen. If IP differs from the default IP, user input is used.
			connectIP = "192.168.0.99"; // Obi Wlan Kenobi static IP for arduino. :-) 
		    string connectIPDiffert = Intent.GetStringExtra("MyConnectData") ?? "0.0.0.0";
			if (connectIPDiffert != "192.168.1.3") 
			{
				connectIP = connectIPDiffert;
			}

			// Get values from the Settings window. 
			endTime = Intent.GetStringExtra("start") ?? "00:00"; // Display Values
			startTime = Intent.GetStringExtra("end") ?? "00:00";
			endTimeInt = Intent.GetStringExtra("endInt") ?? "0000"; // Value to convert with Int.Parse()
			startTimeInt = Intent.GetStringExtra("startInt") ?? "0000"; 
			                                
            // timer object, running clock. 
            timerClock = new System.Timers.Timer() { Interval = 1000, Enabled = true }; // Interval >= 1000
            timerClock.Elapsed += (obj, args) =>
            {
				
                RunOnUiThread(() =>
                {
					ExecuteCommand();
					checkGamingMode();
					textViewStartTime.Text = endTime;
					textViewPresentTime.Text = DateTime.Now.ToString("HH:mm:ss"); 
					textViewEndTime.Text = startTime;

					checkPhotoValue();	
                });
            };

            // timer object, check Arduino state
            // Only one command can be serviced in an timer tick, schedule from list
            timerSockets = new System.Timers.Timer() { Interval = 1000, Enabled = false }; // Interval >= 750
            timerSockets.Elapsed += (obj, args) =>
            {
                if (socket != null) // only if socket exists
                {
                    ExecuteCommand();
                }
                else timerSockets.Enabled = false;  // If socket broken -> disable timer
            };

			// Start Connecting to the socket. 
			if (CheckValidIpAddress(connectIP) && CheckValidPort("3300"))
			{
				if (connector == null) // -> simple sockets
				{
					try
					{
						ConnectSocket(connectIP, "3300");
					}
					catch
					{
						Console.WriteLine("No Socket found.");
					}
				}
				else // -> threaded sockets
				{
					//Stop the thread If the Connector thread is already started.
					if (connector.CheckStarted()) connector.StopConnector();
						connector.StartConnector(connectIP, "3300");
				}
			}
			else
			{
				Finish();
			}

			if (button1 != null)
            {
                button1.Click += (sender, e) =>
                {           
                    if (button1.Checked)
                    {
                        commandList[2] = "0";
                    }
                    else
                    {
                        commandList[2] = "q";
                    }   
                };
            }
            if (button2 != null)
            {
                button2.Click += (sender, e) =>
                {        
                    if (button2.Checked)
                    {
                        commandList[3] = "1";
                    }
                    else
                    {
                        commandList[3] = "w";
                    }                   
                };
            }
            if (button3 != null)
            {
                button3.Click += (sender, e) =>
                {                    
                    if (button3.Checked)
                    {
                        commandList[4] = "2";

                    }
                    else
                    {
                        commandList[4] = "e";
                    }                             
                };
            }

            seekBar.ProgressChanged += (object sender, SeekBar.ProgressChangedEventArgs e) =>
            {
                if (e.FromUser)
                {
                    minTemp = 15 + (e.Progress / 100.0f) * 10.0f;
					tempMinTextView.Text = string.Format("De minimum temperatuur is gezet op {0} graden celcius.", minTemp);
                }
            };
            seekBarLight.ProgressChanged += (object sender, SeekBar.ProgressChangedEventArgs e) =>
            {
                if (e.FromUser)
                {
                    photoValue = 0 + (e.Progress * 10.24f);
                    lightTextView.Text = string.Format("The light will switch at {0}.", photoValue);
                }
            };

            if (buttonChangePinState != null)
            {
                buttonChangePinState.Click += (sender, e) =>
                {
					isGamingNow = !isGamingNow;
                };
            }
        }
        // Send Command to the server without a response.
        public void ExecuteCommand()
        {
            if (socket == null)
            {				
                string cmd = commandList[listIndex];
				if (cmd == "a")
				{

					if (connector.CheckStarted()) connector.SendMessage(cmd);
				}
				else if (cmd == "b")
				{
					if (connector.CheckStarted()) connector.SendMessage(cmd);
				}
				else
				{
					// socket.Send(Encoding.ASCII.GetBytes(cmd));
					if (connector.CheckStarted()) connector.SendMessage(cmd);
				}
				if (++listIndex >= commandList.Count) listIndex = 0;
            }        
        }
     
        //Update GUI based on Arduino response
        public void UpdateGUI(string photoresult, TextView phototextview)
        {
            RunOnUiThread(() =>
            {
				phototextview.Text = photoresult;
            });
        }

		public void UpdateButton(string text, CheckBox check)
		{
			RunOnUiThread(() =>
			{
				check.Text = text;
			});
		}

		public void UpdateTemp(string tempResult, TextView textview) 
		{ 
			RunOnUiThread(() =>
			{
				string temperatureString = Convert.ToString(tempResult[1]) + Convert.ToString(tempResult[2]) + "°c";
				textview.Text = temperatureString;				
			});
		}



        // Connect to socket ip/prt (simple sockets)
        public void ConnectSocket(string ip, string prt)
        {
            RunOnUiThread(() =>
            {
                if (socket == null)                                       // create new socket
                {
                    //UpdateConnectionState(1, "Connecting...");
                    try  // to connect to the server (Arduino).
                    {
                        socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        socket.Connect(new IPEndPoint(IPAddress.Parse(ip), Convert.ToInt32(prt)));
                        if (socket.Connected)
                        {
                            //UpdateConnectionState(2, "Connected");
                            timerSockets.Enabled = true;                //Activate timer for communication with Arduino     
                        }
                    } catch (Exception) {
                        timerSockets.Enabled = false;
                        if (socket != null)
                        {
                            socket.Close();
                            socket = null;
                        }
                        //UpdateConnectionState(4, exception.Message);
                    }
	            }
                else // disconnect socket
                {
                    socket.Close(); socket = null;
                    timerSockets.Enabled = false;
                    //UpdateConnectionState(4, "Disconnected");
                }
            });
        }

        //Close the connection (stop the threads) if the application stops.
        protected override void OnStop()
        {
            base.OnStop();

            if (connector != null)
            {
                if (connector.CheckStarted())
                {
                    connector.StopConnector();
                }
            }
        }

        //Close the connection (stop the threads) if the application is destroyed.
        protected override void OnDestroy()
        {
            base.OnDestroy();

            if (connector != null)
            {
                if (connector.CheckStarted())
                {
                    connector.StopConnector();
                }
            }
        }

        //Prepare the Screen's standard options menu to be displayed.
        public override bool OnPrepareOptionsMenu(IMenu menu)
        {
            //Prevent menu items from being duplicated.
            menu.Clear();

            MenuInflater.Inflate(Resource.Menu.menu, menu);
            return base.OnPrepareOptionsMenu(menu);
        }

        //Executes an action when a menu button is pressed.
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.exit:
                    //Force quit the application.
                    System.Environment.Exit(0);
                    return true;
                case Resource.Id.abort:

                    //Stop threads forcibly (for debugging only).
                    if (connector != null)
                    {
                        if (connector.CheckStarted()) connector.Abort();
                    }
					return true;
				case Resource.Id.settings:
					Intent settingsIntent = new Intent(this, typeof(SensorsActivity));
					StartActivity(settingsIntent);
					return true;
				case Android.Resource.Id.Home:
					Finish();
					return true;
            }
            return base.OnOptionsItemSelected(item);
        }

        //Check if the entered IP address is valid.
        private bool CheckValidIpAddress(string ip)
        {
            if (ip != "") {
                //Check user input against regex (check if IP address is not empty).
                Regex regex = new Regex("\\b((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)(\\.|$)){4}\\b");
                Match match = regex.Match(ip);
                return match.Success;
            } else return false;
        }

        //Check if the entered port is valid.
        private bool CheckValidPort(string port)
        {
            //Check if a value is entered.
            if (port != "")
            {
                Regex regex = new Regex("[0-9]+");
                Match match = regex.Match(port);

                if (match.Success)
                {
                    int portAsInteger = Int32.Parse(port);
                    //Check if port is in range.
                    return ((portAsInteger >= 0) && (portAsInteger <= 65535));
                }
                else return false;
            } else return false;
        }

		private void checkPhotoValue()
		{
			int et = (int)Convert.ToDouble(textViewPhotoValue.Text);
			try
			{
				et = int.Parse(textViewPhotoValue.Text);
			}
			catch (Exception)
			{
				Console.WriteLine("Could not convert.");
			}

			if (photoValue < et)
			{
				commandList[4] = "2";
				button3.Checked = true;			
			}
			else
			{
				commandList[4] = "e";
				button3.Checked = false;
			}
		}

		private void checkGamingMode()
		{
			int start = 0;
			int present = 0;
			int end = 0;

			try
			{
				string nowTimeInt = Convert.ToString(DateTime.Now.Hour) + Convert.ToString(DateTime.Now.Minute);
				start = int.Parse(endTimeInt);
				present = int.Parse(nowTimeInt);
				end = int.Parse(startTimeInt);
			}
			catch (Exception)
			{
				Console.WriteLine("Could not convert.");
			}

			if (present > start && present < end)
			{
				isGaming = true;
			}
			else 
			{
				isGaming = false;
			}

			if (isGaming || isGamingNow)
			{
				button1.Checked = true;
				button2.Checked = true;

				commandList[2] = "0";
				commandList[3] = "1";
		
				buttonChangePinState.Text = "Gaming Mode - Active";
				button1.Text = "Mother EDS (Early Detection System)";
				button2.Text = "Cooking Sensor";
			}
			else
			{
				button1.Checked = false;
				button2.Checked = false;
			
				commandList[2] = "q";
				commandList[3] = "w";

				buttonChangePinState.Text = "Gaming Mode - Disabled";
				button1.Text = "Mother EDS (Early Detection System)";
				button2.Text = "Cooking Sensor";
			}
		}
    }
}
