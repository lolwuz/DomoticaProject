
#include <NewRemoteTransmitter.h>
#define RFPin 2 // RF Pin for the RF-sender. 

NewRemoteTransmitter transmitter(22708692, RFPin, 265, 3); // Adress for Arduino server klik-aan-uit = 22608692
                                                       


// lowest and highest sensor readings:
const int sensorMin = 0;     // sensor minimum
const int sensorMax = 1024;  // sensor maximum

void setup() {
  // initialize serial communication @ 9600 baud:
  Serial.begin(9600);  
}
void loop() {
  // read the sensor on analog A0:
	int sensorReading = analogRead(A0);
  // map the sensor range (four options):
  // ex: 'long int map(long int, long int, long int, long int, long int)'
	int range = map(sensorReading, sensorMin, sensorMax, 0, 3);
  
  // range value:
  switch (range) {
  case 0:    // A fire closer than 1.5 feet away.
    transmitter.sendGroup(true);
    Serial.println("** Close Fire **");
    break;
  case 1:    // A fire between 1-3 feet away.
    transmitter.sendGroup(true);
    Serial.println("** Distant Fire **");
    break;
  case 2:    // No fire detected.
    Serial.println("No Fire");
    break;
  }
  delay(1);  // delay between reads
}
