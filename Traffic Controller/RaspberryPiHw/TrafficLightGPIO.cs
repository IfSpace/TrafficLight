using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Gpio;

namespace RaspberryPiHw
{




    public class TrafficLightGPIO
    {

        private const int RED_PIN = 19;
        private GpioPin RedLight;
        private GpioPin YellowLight;
        private GpioPin GreenLight;
        private GpioPinValue pinValue;
        private const int YELLOW_PIN = 13;
        private const int GREEN_PIN = 26;

        

        

        public TrafficLightGPIO()
        {
            InitGPIO();
            

        }

        //
        // If lightstate is true, then turn Red light on, if false, turn light off
        //
        public void SetRedLightState(bool lightState)
        {
            // TODO: Add Raspberry Pi Hardware Stuff here to turn on/off the red light pin.   
            if (lightState == false)
            {
                var State = GpioPinValue.Low;
                RedLight.Write(State);
                
            }
            else if (lightState == true)
            {
                var State = GpioPinValue.High;
                RedLight.Write(State);
            }
            

            //RedLight.Dispose();
        }


        public void SetYellowLightState(bool lightState)
        {
            // TODO: Add Raspberry Pi Hardware Stuff here to turn on/off the red light pin.   
            if (lightState == false)
            {
                var State = GpioPinValue.Low;
                YellowLight.Write(State);

            }
            else if (lightState == true)
            {
                var State = GpioPinValue.High;
                YellowLight.Write(State);
            }


            //RedLight.Dispose();
        }



        public void SetGreenLightState(bool lightState)
        {
            // TODO: Add Raspberry Pi Hardware Stuff here to turn on/off the red light pin.   
            if (lightState == false)
            {
                var State = GpioPinValue.Low;
                GreenLight.Write(State);

            }
            else if (lightState == true)
            {
                var State = GpioPinValue.High;
                GreenLight.Write(State);
            }


            //RedLight.Dispose();
        }


        async void InitGPIO()
        {
            var gpio = GpioController.GetDefault();

            // Show an error if there is no GPIO controller
            if (gpio == null)
            {
                RedLight = null;
                //GpioStatus.Text = "There is no GPIO controller on this device.";
                return;
            }

            RedLight = gpio.OpenPin(RED_PIN);
            pinValue = GpioPinValue.High;
            RedLight.Write(GpioPinValue.Low);
            RedLight.SetDriveMode(GpioPinDriveMode.Output);

            GreenLight = gpio.OpenPin(GREEN_PIN);
            pinValue = GpioPinValue.High;
            GreenLight.Write(GpioPinValue.Low);
            GreenLight.SetDriveMode(GpioPinDriveMode.Output);

            YellowLight = gpio.OpenPin(YELLOW_PIN);
            pinValue = GpioPinValue.High;
            YellowLight.Write(GpioPinValue.Low);
            YellowLight.SetDriveMode(GpioPinDriveMode.Output);

            SetGreenLightState(true);
            SetRedLightState(true);
            SetYellowLightState(true);
            await Task.Delay(TimeSpan.FromSeconds(0.3));
            SetGreenLightState(false);
            SetRedLightState(false);
            SetYellowLightState(false);
            await Task.Delay(TimeSpan.FromSeconds(1));
            SetGreenLightState(true);
            SetRedLightState(true);
            SetYellowLightState(true);
            await Task.Delay(TimeSpan.FromSeconds(0.3));
            SetGreenLightState(false);
            SetRedLightState(false);
            SetYellowLightState(false);
            await Task.Delay(TimeSpan.FromSeconds(1));
            SetGreenLightState(true);
            SetRedLightState(true);
            SetYellowLightState(true);
            await Task.Delay(TimeSpan.FromSeconds(0.3));
            SetGreenLightState(false);
            SetRedLightState(false);
            SetYellowLightState(false);
            await Task.Delay(TimeSpan.FromSeconds(1));
            SetGreenLightState(true);
            SetRedLightState(true);
            SetYellowLightState(true);
            await Task.Delay(TimeSpan.FromSeconds(0.3));
            SetGreenLightState(false);
            SetRedLightState(false);
            SetYellowLightState(false);
            await Task.Delay(TimeSpan.FromSeconds(1));
            SetGreenLightState(true);
            SetRedLightState(true);
            SetYellowLightState(true);
            await Task.Delay(TimeSpan.FromSeconds(0.3));
            SetGreenLightState(false);
            SetRedLightState(false);
            SetYellowLightState(false);
            SetGreenLightState(true);
            SetRedLightState(true);
            SetYellowLightState(true);
            await Task.Delay(TimeSpan.FromSeconds(0.3));
            SetGreenLightState(false);
            SetRedLightState(false);
            SetYellowLightState(false);
            await Task.Delay(TimeSpan.FromSeconds(1));
            SetGreenLightState(true);
            SetRedLightState(true);
            SetYellowLightState(true);
            await Task.Delay(TimeSpan.FromSeconds(0.3));
            SetGreenLightState(false);
            SetRedLightState(false);
            SetYellowLightState(false);
            await Task.Delay(TimeSpan.FromSeconds(1));
            SetGreenLightState(true);
            SetRedLightState(true);
            SetYellowLightState(true);
            await Task.Delay(TimeSpan.FromSeconds(0.3));
            SetGreenLightState(false);
            SetRedLightState(false);
            SetYellowLightState(false);
            await Task.Delay(TimeSpan.FromSeconds(1));
            SetGreenLightState(true);
            SetRedLightState(true);
            SetYellowLightState(true);
            await Task.Delay(TimeSpan.FromSeconds(0.3));
            SetGreenLightState(false);
            SetRedLightState(false);
            SetYellowLightState(false);
            await Task.Delay(TimeSpan.FromSeconds(1));
            SetGreenLightState(true);
            SetRedLightState(true);
            SetYellowLightState(true);
            await Task.Delay(TimeSpan.FromSeconds(3));
            SetGreenLightState(false);
            SetRedLightState(false);
            SetYellowLightState(false);

        }
    }
}
