int ledSound = 10;
int i = 0; 
int count = 0;
int tot = 0;
int avg;
 
void setup () 
{
  pinMode (ledSound, OUTPUT);
  Serial.begin (9600);
}
 
void loop () 
{
  while(i < 2){
    tot += analogRead(A0);
    count++;
    i++;
    delay(1000);  
  }

  avg = tot / count;
  avg2 = tot2 / count2;
  
  if(analogRead(A0) > avg + 20 && digitalRead(ledSound) == HIGH){
    digitalWrite(ledSound, LOW);
  }
  if(analogRead(A0) > avg + 20 && digitalRead(ledSound) == LOW){
    digitalWrite(ledSound, HIGH);
  }
}
