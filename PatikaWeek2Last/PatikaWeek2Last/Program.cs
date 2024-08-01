//1.Soru
Console.WriteLine("Merhaba\nNasılsın ?\nİyiyim\nSen nasılsın ?");
Console.WriteLine();


//2.Soru
string metinsel;
int tamsayi;

metinsel = "Metin örneği";
tamsayi = 10;

Console.WriteLine(metinsel);
Console.WriteLine(tamsayi);
Console.WriteLine();

//3.soru
Random rastgele = new Random();
int rastgelesayi = rastgele.Next();
Console.WriteLine(rastgelesayi);
Console.WriteLine();

//4.soru
Random rnd = new Random();
int sayi = rnd.Next();
int kalan = sayi % 3;

Console.WriteLine($"Rastgele üretilen sayı: {sayi} ve 3'e bölümünden kalan: {kalan}");
Console.WriteLine();

//5.soru
Console.Write("Lütfen yaşınızı giriniz: ");
bool dogruVeri = int.TryParse(Console.ReadLine(), out int yas);

if( dogruVeri)
{
    if (yas >= 18)
    {
        Console.WriteLine("+");
    }
    else if (yas < 18)
        Console.WriteLine("-");
}
else
{
    Console.WriteLine("Doğru veri girilmedi");
}

//6.soru

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}

//7.soru

Console.Write("İlk ismi giriniz: ");
string valueName1 = Console.ReadLine();
Console.Write("İkinci ismi giriniz: ");
string valueName2 = Console.ReadLine();


string newName= valueName1; // Geçici bir string değişkene ilk isim atandı.
valueName1= valueName2;
valueName2= newName;

Console.WriteLine($"Name1: {valueName1}\nName2: {valueName2} ");

//8.soru
void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma.");
}

BenDegerDondurmem();

//9.soru
double SayilarToplami(double s1, double s2) //soruda tam sayı belirtilmediği için double alındı
{
    double toplam =s1+s2;
    Console.WriteLine(toplam);
    return toplam;
}

SayilarToplami(3,5); */

//10.soru

Console.WriteLine("Lütfen 'true' veya 'false' girin:"); // Kullanıcıdan giriş al
string userInput = Console.ReadLine();


bool boolValue; // Kullanıcı girişini bool türüne dönüştür
bool isValid = bool.TryParse(userInput, out boolValue);

if (isValid)
{
string stringValue = StringValue(boolValue);
Console.WriteLine(stringValue);
}
else
{
string stringValue = StringValue(boolValue);
Console.WriteLine(stringValue);
}


// Bool değerini string'e dönüştüren metod
string StringValue(bool input)
{
    return input ? "Doğru" : "Yanlış";
}

//11.soru

int EnYasli(int y1, int y2, int y3)
{
    int max= Math.Max(y1, Math.Max(y2, y3));
    return max;
}
Console.WriteLine("Birinci yaşı giriniz: ");
int y1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İkinci yaşı giriniz: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Üçüncü yaşı giriniz: ");
int y3 = Convert.ToInt32(Console.ReadLine());

int enYasli = EnYasli(y1,y2, y3);
Console.WriteLine($"En büyük yaş: {enYasli}");



//12.soru

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Metodu çağır ve sonucu al.
        int maxNumber = FindMaxNumber();

        // En büyük sayıyı ekrana yazdır.
        Console.WriteLine("En büyük sayı: " + maxNumber);
    }

    static int FindMaxNumber()
    {
        List<int> numbers = new List<int>();  // Kullanıcıdan sınırsız sayıda sayı istendiği için Array değl, List kullanıldı. <int> ile value type belirlendi.
        string input;  // Kullanıcı programdan çıkmak için "bitir" yazarsa kullanılacak.
        int number; // Kullanıcı ekrana sayı girdiğinde en büyük değer bulmak için kullanılacak.

        
        while (true)  // Kullanıcıdan sonsuz sayı istendiği için while(true) döngüsü kullanıldı.
        {
            Console.Write("Ekrana bir sayı giriniz ya da işlemi sonlandırmak için 'bitir' yazınız. ");
            input = Console.ReadLine();

            
            if (input.ToLower() == "bitir")  // Kullanıcı "bitir" yazdığında döngü sonlacak. Büyük harf kullanma durumuna karşılık ToLower da kullanıldı.
            {
                break;
            }

            
            if (int.TryParse(input, out number))  // Girilen değeri sayıya dönüştürecek.
            {
                numbers.Add(number);  //Add yöntemi ile numbers adlı listeye yeni öğeler ekleyecek.
            }
            else
            {
                Console.WriteLine("Geçersiz bir sayı girdiniz, lütfen tekrar deneyin.");
            }
        }

       

        // En büyük sayıyı bul.
        int maxNumber = numbers[0];
        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }
        }

        return maxNumber;
    }
}

//13.soru

void NameChange(ref string name1, ref string name2)
{
    string temp = name1;
    name1 = name2;
    name2 = temp;
}
Console.WriteLine("Birinci ismi giriniz: ");
string name1 = Console.ReadLine();

Console.WriteLine("İkinci ismi giriniz: ");
string name2 = Console.ReadLine();

NameChange(ref name1, ref name2);
Console.WriteLine(name1 + name2);


//14.soru
int number = Convert.ToInt32(Console.ReadLine());

bool EvenorOdd(int number)
{
    if (number %2 == 0)
    {
        return true;    
    }
    return false;

}

if (EvenorOdd(number))
    Console.WriteLine("Girdiğiniz sayı çifttir.");
else
    Console.WriteLine("Girdiğiniz sayı tektir.");

EvenorOdd(number);  

//15.Soru
int Distance(int speed, int time)
{
    int distance = speed * time;
    return distance;
}


Console.WriteLine("Hız kaçtır?");
int userSpeed = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Yol boyunca alınan zaman ne kadardır?");
int userTime= Convert.ToInt32(Console.ReadLine());



int distance = Distance(userSpeed, userTime);
Console.WriteLine("Alınan yol: "+distance);



//16.soru

double FindCircleArea (double radius)
{
    int number = 2;
    double powerofradius = Math.Pow (radius, 2);
    double area;
       area = powerofradius * 3.14;
    Console.WriteLine(area);

    return area;
}

Console.WriteLine("Dairenin yarıçapını giriniz:");
double userRadius = Convert.ToDouble(Console.ReadLine());

FindCircleArea (userRadius);


// 17.soru

string sentence = "Zaman bir GeRi SayIm";
string lowerCaseSentence = sentence.ToLower();
string upperCaseSentence= sentence.ToUpper();

Console.WriteLine(lowerCaseSentence);
Console.WriteLine(upperCaseSentence); 

//18.soru

void Text()  // Boşluk karakterilerine sahip Selamlar yazısı ilk olarak string türünde tanımlandı. Boşlukları kaldırmak içim Trim kullanıldı ve ekrana yazdırma komutu içine eklendi.
{
    string text = " Selamlar ";

    text= text.Trim();

    Console.WriteLine(text);
}

Text(); // Text methodu her çağrıldığında Selamlar yazısı boşluk olmadan gelecek. */