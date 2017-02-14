/*
 * RF Demo Saboteur
 * 
 * Receives switchType, reverses it, and sends it back.
 * So when receiving group on, it will send a unit off back.
 * 
 * Transmitter:   digital pin 11
 * Receiver:      digital pin 2
 */

#include <NewRemoteReceiver.h>
#include <NewRemoteTransmitter.h>

void setup() {
  Serial.begin(115200);
  NewRemoteReceiver::init(0, 0, saboteur);
  Serial.println("RF Saboteur gestart!");
  Serial.println();
}

void loop() {
}

void saboteur(NewRemoteCode receivedCode) {
  // Disable the receiver; otherwise it might pick up the retransmit as well.
  NewRemoteReceiver::disable();

  // Need interrupts for delay()
  interrupts();

  // Wait 750 milliseconds before sending.
  delay(150);

  // Create a new transmitter with the received address and period, use digital pin 11 as output pin
  NewRemoteTransmitter transmitter(receivedCode.address, 11, receivedCode.period);

  // Switch type 0 = switch off, type 1 = switch on
  // Explanation: 
  // If original value = 1, do minus 1, makes 0, abs(0) makes 0
  // If original value = 0, do minus 1, makes -1, abs(-1) makes 1.
  if (receivedCode.groupBit) {
    Serial.print("Received group ");
    if (receivedCode.switchType == 0)
    {
      Serial.print("off from addr ");
    } else {
      Serial.print("on from address ");
    }
    Serial.println(receivedCode.address);
    
    // Send to the group
    transmitter.sendGroup(abs(receivedCode.switchType - 1));

    Serial.print("Sent group ");
    if (abs(receivedCode.switchType - 1) == 0)
    {
      Serial.print("off to addr ");
    } else {
      Serial.print("on to addr ");
    }
    Serial.println(receivedCode.address);
    Serial.println();
  } 
  else {
    Serial.print("Received unit ");
    Serial.print(receivedCode.unit);
    if (receivedCode.switchType == 0)
    {
      Serial.print(" off from addr ");
    } else {
      Serial.print(" on from address ");
    }
    Serial.println(receivedCode.address);
    
    // Send to a single unit
    transmitter.sendUnit(receivedCode.unit, abs(receivedCode.switchType - 1 ));

    Serial.print("Sent unit ");
    Serial.print(receivedCode.unit);
    if (abs(receivedCode.switchType - 1) == 0)
    {
      Serial.print(" off to addr ");
    } else {
      Serial.print(" on to addr ");
    }
    Serial.println(receivedCode.address);
    Serial.println();
  }
  // Re-enable receiver
  NewRemoteReceiver::enable();
}

