/*
yazan: Remzi ŞAHİNOĞLU
tarih: 07.09.2016
board: Arduino UNO

bu program pc den gelen komut ile 3 yanal loadcell, baskı loadcell ve 
lineer cetvel datalarını alıp bilgisayara gönderir. bilgisayardan stop
komutu gelen kadar bu işlemi kısır döngü olarak yapar.

bilgisayar programında hidrolik silindirleri hareket ettirebiliriz.

*/

boolean startCommand = false;                                             // dataların okuyup pc ye gönder
const int hidrolik_yukari = 12;                                           // hidrolik silindir yukarı rölesi
const int hidrolik_asagi = 13;                                            // hidrolik silindir aşağı rölesi

boolean hidrolik_yukari_active = false;
boolean hidrolik_asagi_active = false;

String data_paket = "";                                                   // analog datalarının tutulduğu yer

String yanal_loadcell_1 = "";
String yanal_loadcell_2 = "";
String yanal_loadcell_3 = "";
String baski_loadcell = "";
String lineer_cetvel = "";

//********************* SERİAL KESME OLUŞTUĞUNDA *************************//
void serialEvent()
{
  while (Serial.available())
  {
    char inChar = (char)Serial.read();
    
    if (inChar == 's')                                                    // başlama komutu pc den geldiğinde
    {
      startCommand = true;
    }
    
    if (inChar == 'r')                                                    // durdurma komutu pc den geldiğinde
    {
      startCommand = false;
    }

    if (inChar == 'u')                                                    // hidrolik yukarı komutu geldiğinde
    {
      hidrolik_yukari_active = true;
    }

    if (inChar == 'b')                                                    // hidrolik aşağı komutu geldiğinde
    {
      hidrolik_asagi_active = true;
    }

    if (inChar == 'x')                                                    // hidrolik aşağı komutu geldiğinde
    {
      hidrolik_yukari_active = false;
      hidrolik_asagi_active = false;
    }
    
  }
}

//********************** BAŞLANGIÇ AYARLARI ******************************//
void setup()
{
  Serial.begin(19200);
  delay(1000);
  
  pinMode(hidrolik_yukari, OUTPUT);
  pinMode(hidrolik_asagi, OUTPUT);
  
  digitalWrite(hidrolik_yukari, LOW);
  digitalWrite(hidrolik_asagi, LOW);

}

//************************** ANA PROGRAM *********************************//
void loop()
{  
  if (startCommand == true)
  {
    yanal_loadcell_1 = analogRead(0);
    yanal_loadcell_2 = analogRead(1);
    yanal_loadcell_3 = analogRead(2);
    baski_loadcell = analogRead(3);
    lineer_cetvel = analogRead(4);
    
    data_paket = yanal_loadcell_1 + ";" + yanal_loadcell_2 + ";" + yanal_loadcell_3 + ";" + baski_loadcell + ";" + lineer_cetvel + ";";
    
    Serial.println(data_paket);
    delay(100);
  }
  
  if (hidrolik_yukari_active == true){digitalWrite(hidrolik_yukari, HIGH);}else{digitalWrite(hidrolik_yukari, LOW);} // hidrolik yukarı                                   
  if (hidrolik_asagi_active == true){digitalWrite(hidrolik_asagi, HIGH);}else{digitalWrite(hidrolik_asagi, LOW);} // hidrolik aşağı
  
}







