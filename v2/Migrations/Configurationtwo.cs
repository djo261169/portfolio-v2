namespace v2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using v2.Models;

    internal sealed class Configurationtwo : DbMigrationsConfiguration<v2.Models.ProjectDBContext>
    {
        public Configurationtwo()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "v2.Models.ProjectDBContext";
        }

        protected override void Seed(v2.Models.ProjectDBContext context)
        {
            context.Projects.AddOrUpdate(x => x.ProjectID,
                new Project()
                {
                    ProjectID = 1,
                    Title = "Generating electricity from microbial reactions from effluent only wastewater system.",
                    URL = "reposit.jpg",
                    Story = "Analog Devices LM35 Temp Sensor ×	1	Adafruit HC-05 Bluetooth Module ×	1	 An Android application is used in the smartphone to display temperature data. The system provides easy monitoring of process data on a smartphone. You can connect the smartphone wirelessly with the system and monitor the process variable, when desired. The system can easily be customised to monitor other process variables also. Authors’ prototype of the transmitter side is shown in Fig. 1. The receiver side consists of the smartphone. A screenshot of the Android app is shown in Fig. 2. Block diagram of the project is shown in Fig. 1. Circuit and Working for Temperature Monitoring System (Connect RX & TX pin after uploading the code) (Connect RX & TX pin after uploading the code) Components Requirement : Arduino Uno LM35 Temp Sensor Bluetooth Module HC - 05 Android App ( TemperatureMonitroing ) apk file Jumper Wires Connections of HC-05 Bluetooth Module: VCC – to VCC of Arduino.GND – to GND of Arduino.RX – to digital pin 0(TX pin) of Arduino.(connect RX & TX pin after uploading the code)TX – to digital pin 1(RX pin) of Arduino. (connect RX & TX pin after uploading the code) Procedure: Make the connections as shown in the above image. Don’t connect the RX & TX pins WHILE/BEFORE uploading the code! Copy the code given below. Select proper COM port and Board from Tools menu in the IDE. Download the app called BlueControl (It’s free). Here is the Link When you are connecting to the Bluetooth module for the first time, it will ask you the password. Enter 0000 OR 1234. Open the app TemperatureMonitoring Go to options. Click on “click on Bluetooth logo ”. Choose the device – HC 05. The paired devices list will appear. Select the HC-05 device from the list to connect the smartphone with HC-05 Bluetooth module. When the device gets successfully paired with the sensor, the LED lights on sensor will start blinking at a slower rate than usual. After successful connection, ‘connected’ message will be displayed on the main screen of the application. DONE. Copy the code given below & test it out ! Connect RX & TX pin Connect RX & TX pin Connect RX & TX pin Android app will start to display the data received from the transmitter side. Android app will start to display the data received from the transmitter side. Android app will start to display the data received from the transmitter side.",
                    DepartmentID = 1
                },
                new Project()
                {
                    ProjectID = 2,
                    Title = "Learn how to automate your home with XinaBox and Blynk with a simple demonstration of turning lights ON and OFF using the Blynk app button.",
                    URL = "daf2631a0229653845f4192012e5c136.png",
                    Story = "Hardware components Arduino UNO & Genuino UNO	Arduino UNO & Genuino UNO ×	1	Analog Devices LM35 Temp Sensor ×	1	Adafruit HC-05 Bluetooth Module ×	1	Story This article describes a temperature monitoring system on an Android smartphone. Temperature is sensed by a temperature sensor installed in the circuit and is sent over Bluetooth to the smartphone. An Android application is used in the smartphone to display temperature data. The system provides easy monitoring of process data on a smartphone. You can connect the smartphone wirelessly with the system and monitor the process variable, when desired. The system can easily be customised to monitor other process variables also. Authors’ prototype of the transmitter side is shown in Fig. 1. The receiver side consists of the smartphone. A screenshot of the Android app is shown in Fig. 2. Block diagram of the project is shown in Fig. 1. Circuit and Working for Temperature Monitoring System (Connect RX & TX pin after uploading the code) (Connect RX & TX pin after uploading the code) Components Requirement : Arduino Uno LM35 Temp Sensor Bluetooth Module HC - 05 Android App ( TemperatureMonitroing ) apk file Jumper Wires Connections of HC-05 Bluetooth Module: VCC – to VCC of Arduino.GND – to GND of Arduino.RX – to digital pin 0(TX pin) of Arduino.(connect RX & TX pin after uploading the code)TX – to digital pin 1(RX pin) of Arduino. (connect RX & TX pin after uploading the code) Procedure: Make the connections as shown in the above image. Don’t connect the RX & TX pins WHILE/BEFORE uploading the code! Copy the code given below. Select proper COM port and Board from Tools menu in the IDE. Download the app called BlueControl (It’s free). Here is the Link When you are connecting to the Bluetooth module for the first time, it will ask you the password. Enter 0000 OR 1234. Open the app TemperatureMonitoring Go to options. Click on “click on Bluetooth logo ”. Choose the device – HC 05. The paired devices list will appear. Select the HC-05 device from the list to connect the smartphone with HC-05 Bluetooth module. When the device gets successfully paired with the sensor, the LED lights on sensor will start blinking at a slower rate than usual. After successful connection, ‘connected’ message will be displayed on the main screen of the application. DONE. Copy the code given below & test it out ! Connect RX & TX pin Connect RX & TX pin Connect RX & TX pin Android app will start to display the data received from the transmitter side. Android app will start to display the data received from the transmitter side. Android app will start to display the data received from the transmitter side.",
                    DepartmentID = 3
                },
                new Project()
                {
                    ProjectID = 3,
                    Title = "Using Teensy (small Arduino) to power NeoPixels off of an electric battery.",
                    URL = "wicard.jpg",
                    Story = "This article describes a temperature monitoring system on an Android smartphone. Temperature is sensed by a temperature sensor installed in the circuit and is sent over Bluetooth to the smartphone. An Android application is used in the smartphone to display temperature data. The system provides easy monitoring of process data on a smartphone. You can connect the smartphone wirelessly with the system and monitor the process variable, when desired. The system can easily be customised to monitor other process variables also. Authors’ prototype of the transmitter side is shown in Fig. 1. The receiver side consists of the smartphone. A screenshot of the Android app is shown in Fig. 2. Block diagram of the project is shown in Fig. 1. Circuit and Working for Temperature Monitoring System (Connect RX & TX pin after uploading the code) (Connect RX & TX pin after uploading the code) Components Requirement : Arduino Uno LM35 Temp Sensor Bluetooth Module HC - 05 Android App ( TemperatureMonitroing ) apk file Jumper Wires Connections of HC-05 Bluetooth Module: VCC – to VCC of Arduino.GND – to GND of Arduino.RX – to digital pin 0(TX pin) of Arduino.(connect RX & TX pin after uploading the code)TX – to digital pin 1(RX pin) of Arduino. (connect RX & TX pin after uploading the code) Procedure: Make the connections as shown in the above image. Don’t connect the RX & TX pins WHILE/BEFORE uploading the code! Copy the code given below. Select proper COM port and Board from Tools menu in the IDE. Download the app called BlueControl (It’s free). Here is the Link When you are connecting to the Bluetooth module for the first time, it will ask you the password. Enter 0000 OR 1234. Open the app TemperatureMonitoring Go to options. Click on “click on Bluetooth logo ”. Choose the device – HC 05. The paired devices list will appear. Select the HC-05 device from the list to connect the smartphone with HC-05 Bluetooth module. When the device gets successfully paired with the sensor, the LED lights on sensor will start blinking at a slower rate than usual. After successful connection, ‘connected’ message will be displayed on the main screen of the application. DONE. Copy the code given below & test it out ! Connect RX & TX pin Connect RX & TX pin Connect RX & TX pin Android app will start to display the data received from the transmitter side. Android app will start to display the data received from the transmitter side. Android app will start to display the data received from the transmitter side.",
                    DepartmentID = 2
                }
                );

            context.Departments.AddOrUpdate(x => x.DepartmentID,
                new Department()
                {
                    DepartmentID = 1,
                    DepartmentName = "Arduino",
                },
                new Department()
                {
                    DepartmentID = 2,
                    DepartmentName = "Raspberry Pi",
                },
                new Department()
                {
                    DepartmentID = 3,
                    DepartmentName = "Internet Of Things",
                }
                );
        }
    }
}
