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
using System.Threading.Tasks;
using System;
using System.Diagnostics;
using Windows.Networking.Sockets;
using Windows.Storage.Streams;
using RaspberryPiHw;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Traffic_Controller
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 




public sealed partial class MainPage : Page
    {
        TrafficLightGPIO trafficLight = new TrafficLightGPIO();
        public MainPage()
        {
            
        }

        private void InitializeComponent()
    {
        //throw new NotImplementedException();
    }

    private async void RedButton_Click(object sender, RoutedEventArgs e)
        {
            
            // Call Function: Turn on Red Light or Turn Off Red Light
            trafficLight.SetRedLightState(true);
            trafficLight.SetGreenLightState(false);
            trafficLight.SetYellowLightState(false);
        }

        private void YellowButton_Click(object sender, RoutedEventArgs e)
        {
            //textBlock.Text = "Status, Yellow Light ON, Don't Walk Light ON.";
            trafficLight.SetYellowLightState(true);
            trafficLight.SetRedLightState(false);
            trafficLight.SetGreenLightState(false);
        }

        private void Green_Click(object sender, RoutedEventArgs e)
        {
            //textBlock.Text = "Status, Green Light ON, Don't Walk Light ON.";
            trafficLight.SetGreenLightState(true);
            trafficLight.SetRedLightState(false);
            trafficLight.SetYellowLightState(false);
        }

        private async void WalkButton_Click(object sender, RoutedEventArgs e)
        {
            //textBlock.Text = "Status, Yellow Light ON, Don't Walk Light ON. Please Wait.";
            await System.Threading.Tasks.Task.Delay(TimeSpan.FromSeconds(7));
            //textBlock.Text = "Status, Red Light ON, Don't Walk Light ON. Please Wait";
            await System.Threading.Tasks.Task.Delay(TimeSpan.FromSeconds(2));
            //textBlock.Text = "Status, Red Light ON, Walk Light ON. Operation Successful.";
            
            }
        }
             

