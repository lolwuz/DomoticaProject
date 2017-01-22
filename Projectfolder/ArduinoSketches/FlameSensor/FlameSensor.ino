int buzzer = 8 ;// define LED Interface
int buttonpin = 4; // define the flame sensor interface
int analog = A3; // define the flame sensor interface
int sound = 0;
 
int val ;// define numeric variables val
float sensor; //read analoog value
 
void setup ()
{
  pinMode (buzzer, OUTPUT) ;// define LED as output interface
  pinMode (buttonpin, INPUT) ;// output interface defines the flame sensor
  pinMode (analog, INPUT) ;// output interface defines the flame sensor
  Serial.begin(9600);
}
 
void loop ()
{
  sensor = analogRead(analog);
  Serial.println(sensor);  // display temperature
  if (sensor > 400) {
    sound = 0;
  }
  if (sensor < 400 && sensor > 300) {
    sound = 250;
  }
  if (sensor < 300 && sensor > 200) {
    sound = 500;
  }
    if (sensor < 200 && sensor > 100) {
    sound = 750;
  }
    if (sensor < 100 && sensor > 0) {
    sound = 1000;
  }
    
  val = digitalRead (buttonpin) ;// de Val wilde ik nog even testen, dus het zou kunnen dat het niet werkt. Als het inderdaad niet werkt, verwijder de val dan uit de if statement.
  Serial.print(val);//
    if (sensor < 400 && val == LOW) // When the flame sensor detects a signal, LED flashes
  {
    tone(buzzer, sound, 200);
  }
  delay(1000);
}
