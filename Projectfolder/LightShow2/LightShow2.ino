/**
 * Demo for RF remote switch receiver.
 * For details, see NewRemoteReceiver.h!
 *
 * Connect the transmitter to digital pin 11.
 *
 * This sketch demonstrates the use of the NewRemoteTransmitter class.
 *
 * When run, this sketch switches some pre-defined devices on and off in a loop.
 *
 * NOTE: the actual receivers have the address and group numbers in this example
 * are only for demonstration! If you want to duplicate an existing remote, please
 * try the "retransmitter"-example instead.
 * 
 * To use this actual example, you'd need to "learn" the used code in the receivers
 * This sketch is unsuited for that.
 * 
 */

#include <NewRemoteTransmitter.h>

// Create a transmitter on address 123, using digital pin 11 to transmit, 
// with a period duration of 260ms (default), repeating the transmitted
// code 2^3=8 times.
NewRemoteTransmitter transmitter(22708690, 11, 265, 3);

void setup() {
}

void loop() {  
  transmitter.sendUnit(0, true);
  transmitter.sendUnit(1, false);
  transmitter.sendUnit(2, false);
  delay(2000);

  transmitter.sendUnit(0, false);
  transmitter.sendUnit(1, true);
  transmitter.sendUnit(2, false);
  delay(2000);

  transmitter.sendUnit(0, false);
  transmitter.sendUnit(1, false);
  transmitter.sendUnit(2, true);
  delay(2000);
}
