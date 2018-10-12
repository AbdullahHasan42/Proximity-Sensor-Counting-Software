//#include <SoftReset.h>
//#include <Keypad.h>
//#include <avr/wdt.h>
#include <LiquidCrystal.h>
 const int rs = A15, en = A14, d4 = A7, d5 = A6, d6 = A5, d7 = A4;
 LiquidCrystal lcd(rs, en, d4, d5, d6, d7);
unsigned long counter = 0;

String inputString = "";
boolean stringComplete = false;
unsigned long End = -1;
unsigned long hitObject = true;
unsigned long ir_pin = 25;

unsigned long state;
unsigned long stop_flage=0;
unsigned long t_delay = 80000;
unsigned long timer;
unsigned long last_change;

unsigned long start;
unsigned long led=23;
unsigned long val;

unsigned long vipE;
unsigned long vipC=200;
/*
const byte ROWS = 4; //four rows
const byte COLS = 4; //four columns
//define the cymbols on the buttons of the keypads
char hexaKeys[ROWS][COLS] = {
  {'1','2','3','A'},
  {'4','5','6','B'},
  {'7','8','9','C'},
  {'*','0','#','D'}
};
byte rowPins[ROWS] = {53, 51, 49, 47 } ; //connect to the row pinouts of the keypad
byte colPins[COLS] = {45 , 43 , 41, 39 }; //connect to the column pinouts of the keypad

//initialize an instance of class NewKeypad
Keypad customKeypad = Keypad( makeKeymap(hexaKeys), rowPins, colPins, ROWS, COLS); 
*/
void setup()
{
 lcd.begin(16,2);
 lcd.print("Counter = ");
 pinMode(ir_pin,INPUT); 
 Serial.begin(9600);
        Serial.print("Counter = ");
        Serial.println( counter);
        lcd.setCursor(0,2);
        lcd.print("  ");

        lcd.setCursor(0,2);
        lcd.print(counter);


pinMode(led,OUTPUT);

  //      digitalWrite(led,HIGH);

}

void serialEvent() {
  while (Serial.available()) 
  {
    // get the new byte:
    char inChar = (char)Serial.read();
    // add it to the inputString:
    inputString += inChar;
    // if the incoming character is a newline, set a flag
    // so the main loop can do something about it:
    if (inChar == '\n') 
    {
      stringComplete = true;
    }
  }
}

void loop(){
/*
  while(start==0){
   char key1 = customKeypad.getKey();
   switch (key1) {
     case NO_KEY:
     break;
  
     case '0': case '1': case '2': case '3': case '4': 
     case '5': case '6': case '7': case '8': case '9': 
     Serial.print(key1);
         firstvariable = firstvariable* 10 + key1 - '0'; 
        lcd.setCursor(0,1);
        lcd.print(firstvariable);
     break;
  
     case '#': 
         Serial.println ();
     Serial.print ("Value is: ");
     Serial.print (firstvariable );
     start=1;
     last_change=0;
         break;
  
     case '*': 
         firstvariable = 0;
  //       Serial.clear();
         Serial.println ();
     Serial.print ("Reset value:");
     Serial.print (firstvariable );

     case 'A':
        firstvariable = 0;
        start=0;
        stop_flage==0;
        timer=0;
        last_change=0;
        counter=0;
        val =1;
        hitObject=true;
        state=0;
        lcd.clear();
        lcd.print("Counter = ");
        lcd.setCursor(0,2);
        lcd.print("  ");

        lcd.setCursor(0,2);
        lcd.print(counter);

             Serial.println ("Reset system");

        soft_restart();
   }
  }
  */

  
//////////////////////////////////////////////////////////////////////////////////////////////////////////////


if (stringComplete)
{
    Serial.println(inputString);
    // clear the string:
    inputString = "";
    stringComplete = false;
}
  
End = inputString.toInt(); // Transform the Input string to Integer for comaprison to counter
  
val = digitalRead(ir_pin);  //Read from Sensor Pin

if( val == 0 && hitObject == false && stop_flage==0&& state>vipC )
{
        counter++;
        hitObject = true;
        
        Serial.print("Counter = ");
        Serial.println( counter);
        
        lcd.setCursor(0,1);
        lcd.print("             ");
        lcd.setCursor(0,1);
        lcd.print(counter);

        last_change=millis();

}
else if( val ==1 && hitObject == true && stop_flage==0 && state>vipC )
{
        hitObject = false;

        last_change=millis();  
}
        
timer=millis;
state=timer-last_change;
      //vipE=state+vipC;
      //Serial.print("state = ");
      //Serial.println(state);
  
//////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Counter Stop Check
  
  if (End >= 1) // To prevent early stop due to unavaliable End value (Somehow counter variable always starts at 1)
  {
    if(state>t_delay || counter >= End )
    {
      stop_flage=1; 
          Serial.print("STOP COUNTER last counter = ");
          Serial.print( counter);
          lcd.setCursor(12,1);
          lcd.print("STOP");
  
          Serial.print ("     ");
          Serial.print (End );
          lcd.setCursor(0,2);
          lcd.print(counter);
          digitalWrite(led,LOW);
        // Serial.println(counter);
          start=0;
      }
      else
      {
          digitalWrite(led,HIGH);
        
      }
  } 
}


