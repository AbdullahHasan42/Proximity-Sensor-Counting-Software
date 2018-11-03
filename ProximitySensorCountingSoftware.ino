#include <LiquidCrystal.h>
#include <ctype.h>
const int rs = A15, en = A14, d4 = A7, d5 = A6, d6 = A5, d7 = A4;
LiquidCrystal lcd(rs, en, d4, d5, d6, d7);

String inputString = "";
boolean stringComplete = false;
unsigned long End = -1;
unsigned long hitObject = true;
unsigned long ir_pin = 25;
unsigned long counter = 0;

unsigned long state;
unsigned long stop_flag=0;
unsigned long t_delay = 60000;
unsigned long timer;
unsigned long last_change;

unsigned long led=23;
unsigned long sensor_input;

void setup()
{
  Serial.begin(9600);
  pinMode(ir_pin,INPUT); 
  pinMode(led,OUTPUT);

  /*
  Serial.println("Welcome to ProximitySensorCountingSoftware");
  lcd.begin(16,2);
  lcd.print("Counter = ");
  lcd.setCursor(0,2);
  lcd.print("  ");
  lcd.setCursor(0,2);
  lcd.print(counter);
  digitalWrite(led,HIGH);
  */
}

void loop()
{
    if (inputString == "RESTART")
    {
        counter = 0;
        hitObject = true;
        state = 0;
        t_delay = 80000;
        stop_flag = 0;
        End = -1;
        //Serial.println(inputString);
        // clear the string:
        Serial.println("Restarting...");
        inputString = "";
        //stringComplete = false;
        delay(1500);
        //Serial.println("");
        //lcd.clear();
    }
    else
    { 

      End = inputString.toInt(); // Transform the Input string to Integer for comaprison to counter
      inputString = "";
      sensor_input = digitalRead(ir_pin); //Read from Sensor Pin

      if( sensor_input ==1 && hitObject == true && stop_flag==0)
      {
              hitObject = false;
      
              last_change=millis();  
      }
      
      else if( sensor_input == 0 && hitObject == false && stop_flag == 0)
      {
              counter++;
              hitObject = true;
              
              Serial.print("Counter = ");
              Serial.println(counter);
              
              last_change=millis();
              /*
              lcd.setCursor(0,1);
              lcd.print("             ");
              lcd.setCursor(0,1);
              lcd.print(counter);
              */
      }
      
      timer=millis();
      state=timer-last_change;
            //vipE=state+vipC;
            //Serial.print("state = ");
            //Serial.println(state);
        
      //////////////////////////////////////////////////////////////////////////////////////////////////////////////
      // Counter Stop Check
      if (End > 1)
      {
          if(state>t_delay || counter >= End)
          {
            stop_flag = 1; 
                Serial.print("STOP COUNTER last counter = ");
                Serial.println(counter);
                /*
                lcd.setCursor(12,1);
                lcd.print("STOP");
                Serial.print ("     ");
                Serial.print (End );
                lcd.setCursor(0,2);
                lcd.print(counter);
                Serial.println(counter);
                start=0;
                */
                //digitalWrite(led,LOW);
               inputString = Serial.readString(); //Read for restart Input

            }
            else
            {
                //digitalWrite(led,HIGH);
              
            }
      }

  }
  //state = millis();
  }

void serialEvent()
{
    while (Serial.available()) 
  {
    // get the new byte:
    char inChar = (char)Serial.read();
    // add it to the inputString:
    inputString += inChar;
    // if the incoming character is a newline, set a flag
    // so the main loop can do something about it:
    //if (inChar == '\n') 
    //{
    //  stringComplete = true;
    //}
}
}
//////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*
//#include <SoftReset.h>
//#include <Keypad.h>
//#include <avr/wdt.h>
//int start;

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
        sensor_input =1;
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
