void setup() {
  Serial.begin(9600);
  Serial.println("Connection established");
  pinMode(13, OUTPUT);
}
String input = "";
void loop() {
  input = Serial.readString();
  //input = "OFF";
  if (input == "ON"){
    digitalWrite(13, HIGH);
    Serial.print("0101\n");
    delay(500);
    }
    
  if (input == "OFF"){
    digitalWrite(13, LOW);
    Serial.print("1010\n");
    delay(500);
}

}
