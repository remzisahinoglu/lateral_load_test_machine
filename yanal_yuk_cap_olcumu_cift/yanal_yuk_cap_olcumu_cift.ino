/*
yazan: Remzi ŞAHİNOĞLU
tarih: 07.09.2016
board: Arduino UNO

bu program digital 2.pine bağlı olan butona basıldığında 
analog pine bağlı loadcell değerlerini okuyup serialdan yazar

*/

#include <EEPROM.h>
#include "LedControl.h"
LedControl lc = LedControl(10,12,11,1);                                   // Arduino Pins: (DIN:10, CLK:12, LOAD/CS:11, no.of devices is 1)

char ekran[8] = {};                                                       // max7219 modulunde 8 adet dipslay olduğu için 
unsigned int index = 0;                                                   // max7219u ayarlamak için kullanıldı
unsigned long diameter = 0;                                               // diameter

long max_coz_sag = 0;                                                     // 2 byte olduğu için farklı bir komut kullanımlalı
long min_coz_sag = 0;                                                     // sağ lineer cetvel için

long max_coz_sol = 0;                                                     // 2 byte olduğu için farklı bir komut kullanımlalı
long min_coz_sol = 0;                                                     // sağ lineer cetvel için

unsigned long sol_deger = 0;
unsigned long sag_deger = 0;

float max_cap = 75000.0;                                                  // max tek taraf çap değeri 150/2
float min_cap = 30000.0;                                                  // main tek taraf çap değeri 60/2

//--------------------------- EEPROM WRİTE -------------------------------//
void ee_write_long(unsigned int addr , signed long *longptr)
{
unsigned char edata;
unsigned char I;
    for(I=0;I<4;I++){
      edata = *((unsigned char *)longptr+I);
      EEPROM.write(addr+I,edata);
   }
}

//---------------------------- EEPROM READ -------------------------------//
void ee_read_long(unsigned int addr , signed long *longptr)
{
unsigned char edata;
unsigned char I;
   for(I=0;I<4;I++){
      edata=EEPROM.read(I+addr);   
        *((unsigned char *)longptr+I) = edata;
   }
}

//--------------------------- EKRANDA GÖSTER -----------------------------//
void display_set()
{
  index = 0;
  for (int i = 0; i < String(diameter).length(); i++)
  {
    char inChar = (char)String(diameter)[i];                              // tek bir byte oku
    switch(index)
    {
      case 0:                 // 1.karakter okunduğunda
        ekran[7] = ' ';       // değer yoksa display boş gözüksün
        ekran[6] = ' ';       // değer yoksa display boş gözüksün
        ekran[5] = ' ';       // değer yoksa display boş gözüksün
        ekran[4] = ' ';       // değer yoksa display boş gözüksün
        ekran[3] = ' ';       // değer yoksa display boş gözüksün
        ekran[2] = ' ';       // değer yoksa display boş gözüksün
        ekran[1] = ' ';       // değer yoksa display boş gözüksün
        ekran[0] = inChar;
        break;
        
      case 1:                 // 2.karakter okunduğunda
        ekran[7] = ' ';       // değer yoksa display boş gözüksün
        ekran[6] = ' ';       // değer yoksa display boş gözüksün
        ekran[5] = ' ';       // değer yoksa display boş gözüksün
        ekran[4] = ' ';       // değer yoksa display boş gözüksün
        ekran[3] = ' ';       // değer yoksa display boş gözüksün
        ekran[2] = ' ';       // değer yoksa display boş gözüksün
        ekran[1] = ekran[0];  // 1.okunan katakteri 2.displaye kaydır
        ekran[0] = inChar;
        break;
        
      case 2:                 // 3.karakter okunduğunda
        ekran[7] = ' ';       // değer yoksa display boş gözüksün
        ekran[6] = ' ';       // değer yoksa display boş gözüksün
        ekran[5] = ' ';       // değer yoksa display boş gözüksün
        ekran[4] = ' ';       // değer yoksa display boş gözüksün
        ekran[3] = ' ';       // değer yoksa display boş gözüksün
        ekran[2] = ekran[1];  // 1.okunan katakteri 3.displaye kaydır
        ekran[1] = ekran[0];  // 2.okunan katakteri 2.displaye kaydır
        ekran[0] = inChar;
        break;
        
      case 3:                 // 4.karakter okunduğunda
        ekran[7] = ' ';       // değer yoksa display boş gözüksün
        ekran[6] = ' ';       // değer yoksa display boş gözüksün
        ekran[5] = ' ';       // değer yoksa display boş gözüksün
        ekran[4] = ' ';       // değer yoksa display boş gözüksün
        ekran[3] = ekran[2];  // 1.okunan katakteri 4.displaye kaydır
        ekran[2] = ekran[1];  // 2.okunan katakteri 3.displaye kaydır
        ekran[1] = ekran[0];  // 3.okunan katakteri 2.displaye kaydır
        ekran[0] = inChar;
        break;
        
      case 4:                 // 5.karakter okunduğunda
        ekran[7] = ' ';       // değer yoksa display boş gözüksün
        ekran[6] = ' ';       // değer yoksa display boş gözüksün
        ekran[5] = ' ';       // değer yoksa display boş gözüksün
        ekran[4] = ekran[3];  // 1.okunan katakteri 4.displaye kaydır
        ekran[3] = ekran[2];  // 2.okunan katakteri 3.displaye kaydır
        ekran[2] = ekran[1];  // 3.okunan katakteri 2.displaye kaydır
        ekran[1] = ekran[0];  // 4.okunan katakteri 1.displaye kaydır
        ekran[0] = inChar;
        break;
        
      case 5:                 // 6.karakter okunduğunda
        ekran[7] = ' ';       // değer yoksa display boş gözüksün
        ekran[6] = ' ';       // değer yoksa display boş gözüksün
        ekran[5] = ekran[4];  // 1.okunan katakteri 5.displaye kaydır
        ekran[4] = ekran[3];  // 2.okunan katakteri 4.displaye kaydır
        ekran[3] = ekran[2];  // 3.okunan katakteri 3.displaye kaydır
        ekran[2] = ekran[1];  // 4.okunan katakteri 2.displaye kaydır
        ekran[1] = ekran[0];  // 5.okunan katakteri 1.displaye kaydır
        ekran[0] = inChar;
        break;
        
      case 6:                 // 7.karakter okunduğunda
        ekran[7] = ' ';       // değer yoksa display boş gözüksün
        ekran[6] = ekran[5];  // 1.okunan katakteri 6.displaye kaydır
        ekran[5] = ekran[4];  // 2.okunan katakteri 5.displaye kaydır
        ekran[4] = ekran[3];  // 3.okunan katakteri 4.displaye kaydır
        ekran[3] = ekran[2];  // 4.okunan katakteri 3.displaye kaydır
        ekran[2] = ekran[1];  // 5.okunan katakteri 2.displaye kaydır
        ekran[1] = ekran[0];  // 6.okunan katakteri 1.displaye kaydır
        ekran[0] = inChar;
        break;
        
      case 7:                 // 8.karakter okunduğunda
        ekran[7] = ekran[6];  // 1.okunan katakteri 7.displaye kaydır
        ekran[6] = ekran[5];  // 2.okunan katakteri 6.displaye kaydır
        ekran[5] = ekran[4];  // 3.okunan katakteri 5.displaye kaydır
        ekran[4] = ekran[3];  // 4.okunan katakteri 4.displaye kaydır
        ekran[3] = ekran[2];  // 5.okunan katakteri 3.displaye kaydır
        ekran[2] = ekran[1];  // 6.okunan katakteri 2.displaye kaydır
        ekran[1] = ekran[0];  // 7.okunan katakteri 1.displaye kaydır
        ekran[0] = inChar;
        break;
    }
    index++;
  }

  for (int i = 0; i < String(diameter).length(); i++)                     // çevrim uzunluğu kadar döngü yap, çünkü o kadar display yansın
  {
    lc.setDigit(0,i,(String(ekran[i])).toInt(),false);                    // (grup no, digit no, data, point) eğer true ise point yanar
  }
}

//********************** BAŞLANGIÇ AYARLARI ******************************//
void setup()
{
  Serial.begin(19200);
  delay(1000);

  lc.shutdown(0,false);                                                   // Enable display
  lc.setIntensity(0,3);                                                   // Set brightness level (0 is min, 15 is max)
  lc.clearDisplay(0);                                                     // Clear display register

  pinMode(2, INPUT_PULLUP);                                               // min_coz değerini ayarla, yukardaki buton
  pinMode(3, INPUT_PULLUP);                                               // max_coz değerini ayarla, aşağıdaki buton
  pinMode(4, INPUT_PULLUP);                                               // data gönder butonu
  
  ee_read_long(0x00, &min_coz_sol);                                       // sağ lineer cetveli oku
  ee_read_long(0x04, &max_coz_sol);

  ee_read_long(0x10, &min_coz_sag);                                       // sağ lineer cetveli oku
  ee_read_long(0x14, &max_coz_sag);
}

//************************** ANA PROGRAM *********************************//
void loop()
{
  delay(250);
  lc.clearDisplay(0);
  
  sol_deger = max_cap - ((max_cap - min_cap) * (max_coz_sol - analogRead(0)) / (max_coz_sol - min_coz_sol));
  sag_deger = max_cap - ((max_cap - min_cap) * (max_coz_sag - analogRead(1)) / (max_coz_sag - min_coz_sag));
    
  diameter = sol_deger + sag_deger;
    
  display_set();                                                          // max7219 modulunu ayarla

  if(digitalRead(4) == 0)                                                 // min değer kalibrasyon butonu
  {
    Serial.print(sol_deger);                                              // PCye sol lineer cetvelin datasını gönder
    Serial.write(9);                                                      // TAB karakterini gönder, excele kopyalanınca kolaylık olsun diye
    Serial.println(sag_deger);                                            // PCye sag lineer cetvelin datasını gönder
  }
  else
  {
    delay(250);
    display_set();                                                        // max7219 modulunu ayarla
  }
  
  if(digitalRead(2) == 0)                                                 // min değer kalibrasyon butonu
  {
    delay(500);
    min_coz_sol = analogRead(0);
    min_coz_sag = analogRead(1);
    ee_write_long(0x00, &min_coz_sol);                                    // değeri eproma yaz
    ee_write_long(0x10, &min_coz_sag);
  }
  
  if(digitalRead(3) == 0)                                                 // max değer kalibrasyon butonu
  {
    delay(500);
    max_coz_sol = analogRead(0);
    max_coz_sag = analogRead(1);
    ee_write_long(0x04, &max_coz_sol);                                    // değeri eproma yaz
    ee_write_long(0x14, &max_coz_sag);                                    // değeri eproma yaz
  }
  
  
}

// max kalibrasyon olayını tekrardan bi incele test et kumpas ile







