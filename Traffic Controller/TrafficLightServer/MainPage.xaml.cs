using RaspberryPiHw;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TrafficLightServer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        TrafficLightGPIO trafficLight = new TrafficLightGPIO();
        ServerSocket.SocketServer socketServer = new ServerSocket.SocketServer(9000);
        public MainPage()
        {
            this.InitializeComponent();
            socketServer.OnError += socket_OnError;
            socketServer.OnDataRecived += Socket_OnDataRecived;
            socketServer.Star();

        }

        private void Socket_OnDataRecived(string data)
        {
            if (data == "RedOn")
            {
                trafficLight.SetRedLightState(true);
            }
            else if (data == "YellowOn")
            {
                trafficLight.SetYellowLightState(true);
            }
            else if (data == "GreenOn")
            {
                trafficLight.SetGreenLightState(true);
            }
            else if (data == "RedOff")
            {
                trafficLight.SetRedLightState(false);
            }
            else if (data == "YellowOff")
            {
                trafficLight.SetYellowLightState(false);
            }
            else if (data == "GreenOff")
            {
                trafficLight.SetGreenLightState(false);
            }
        }

        private void socket_OnError(string message)
        {

        }
    }
}
