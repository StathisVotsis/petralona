using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Particle;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace petralona
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ThirdPage : ContentPage
	{
        public string st6;
        ParticleDevice myDevice1 = null;
        ParticleDevice myDevice2 = null;
        public ThirdPage (string st5)
		{
			InitializeComponent ();
            //NavigationPage.SetBackButtonTitle(this, "");
            //NavigationPage.SetHasBackButton(this, false);
            //NavigationPage.SetHasNavigationBar(this, false);
            st6 = st5;
            Title = st6;
            Task1();
		}

        async void Task1()
        {
            if(st6=="Room 1")
            {
                List<ParticleDevice> devices = await ParticleCloud.SharedInstance.GetDevicesAsync();
                foreach (ParticleDevice device in devices)
                {
                    if (device.Name.Equals("Room1_1"))
                    {
                        myDevice1 = device;
                    }
                    if (device.Name.Equals("Room1.2"))
                    {
                        myDevice2 = device;
                    }

                }
            }
            else if (st6 == "Room2")
            {
                List<ParticleDevice> devices = await ParticleCloud.SharedInstance.GetDevicesAsync();
                foreach (ParticleDevice device in devices)
                {
                    if (device.Name.Equals("Room2.1"))
                    {
                        myDevice1 = device;
                    }
                    if (device.Name.Equals("Room2.2"))
                    {
                        myDevice2 = device;
                    }

                }
            }
            else if (st6 == "Room3")
            {
                List<ParticleDevice> devices = await ParticleCloud.SharedInstance.GetDevicesAsync();
                foreach (ParticleDevice device in devices)
                {
                    if (device.Name.Equals("Room3.1"))
                    {
                        myDevice1 = device;
                    }
                    if (device.Name.Equals("Room3.2"))
                    {
                        myDevice2 = device;
                    }

                }
            }
            else if (st6 == "Room4")
            {
                List<ParticleDevice> devices = await ParticleCloud.SharedInstance.GetDevicesAsync();
                foreach (ParticleDevice device in devices)
                {
                    if (device.Name.Equals("Room4.1"))
                    {
                        myDevice1 = device;
                    }
                    if (device.Name.Equals("Room4.2"))
                    {
                        myDevice2 = device;
                    }

                }
            }
            else if (st6 == "Room5")
            {
                List<ParticleDevice> devices = await ParticleCloud.SharedInstance.GetDevicesAsync();
                foreach (ParticleDevice device in devices)
                {
                    if (device.Name.Equals("Room5.1"))
                    {
                        myDevice1 = device;
                    }
                    if (device.Name.Equals("Room5.2"))
                    {
                        myDevice2 = device;
                    }

                }
            }
            else if (st6 == "Room6")
            {
                List<ParticleDevice> devices = await ParticleCloud.SharedInstance.GetDevicesAsync();
                foreach (ParticleDevice device in devices)
                {
                    if (device.Name.Equals("Room6.1"))
                    {
                        myDevice1 = device;
                    }
                    if (device.Name.Equals("Room6.2"))
                    {
                        myDevice2 = device;
                    }

                }
            }
            else if (st6 == "Room7")
            {
                List<ParticleDevice> devices = await ParticleCloud.SharedInstance.GetDevicesAsync();
                foreach (ParticleDevice device in devices)
                {
                    if (device.Name.Equals("Room7.1"))
                    {
                        myDevice1 = device;
                    }
                    if (device.Name.Equals("Room7.2"))
                    {
                        myDevice2 = device;
                    }

                }
            }
            else if (st6 == "Room8")
            {
                List<ParticleDevice> devices = await ParticleCloud.SharedInstance.GetDevicesAsync();
                foreach (ParticleDevice device in devices)
                {
                    if (device.Name.Equals("Room8.1"))
                    {
                        myDevice1 = device;
                    }
                    if (device.Name.Equals("Room8.2"))
                    {
                        myDevice2 = device;
                    }

                }
            }
        }
        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Relay3_On();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            //Relay4_Off();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            //Relay1_On();
        }

        async void Relay3_On()
        {
            var response = await myDevice1.CallFunctionAsync("relayOn_door", "1");

        }

        async void Relay1_On()
        {
            var response = await myDevice2.CallFunctionAsync("relayOn", "1");

        }

        async void Relay2_Off()
        {
            var response = await myDevice2.CallFunctionAsync("relayOff", "1");

        }
    }
}