const int ledPin = 10;
float temp;
const int lightPin=A1;
const int trig_pin=11;
const int echo_pin=12;
void setup() {
  Serial.begin(9600);
  pinMode(ledPin,OUTPUT);
}

void loop() {

  if(Serial.available()){
   	char inputVal = Serial.read();
    
    if(inputVal == '1'){
      digitalWrite(ledPin,HIGH);
      Serial.print("LED:ON");
      Serial.print("~");
    }
    else if(inputVal == '0'){
      digitalWrite(ledPin,LOW);
      Serial.print("LED:OFF");
      Serial.print("~");
    }

  }

  
    int val=analogRead(A0);

    temp=val*0.48828125;
    Serial.print("[TMP:");
    Serial.print(temp);
    Serial.print("]~");

    int lightValue=analogRead(lightPin);
    Serial.print("[LIGHT:");
    Serial.print(lightValue);
    Serial.print("]~");

    digitalWrite(trig_pin,LOW);
    delayMicroseconds(2);
    digitalWrite(trig_pin,HIGH);
    delayMicroseconds(10);
    digitalWrite(trig_pin,LOW);

    long duration=pulseIn(echo_pin,HIGH);
    long distance=(duration/2)/29.1;

    Serial.print("[DIS:");
    Serial.print(distance);
    Serial.println("]");
  delay(500);


}