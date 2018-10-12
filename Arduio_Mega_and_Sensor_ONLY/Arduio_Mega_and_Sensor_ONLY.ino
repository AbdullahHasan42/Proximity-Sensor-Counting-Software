int counter = 0;
int val = 0;
int ir_pin = 25;
int firstvariable =0;

void setup() 
{
   pinMode(ir_pin,INPUT); 
   Serial.begin(9600);
  
    //      digitalWrite(led,HIGH);
}

void loop() 
{
 //firstvariable = Serial.read();
 //    Serial.println(firstvariable);
     val = digitalRead(ir_pin);

  if( val == 0 )
  {
        counter++;
        Serial.print("Counter = ");
        Serial.println( counter);

   }     
}
