using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C Sharp Practise");
            Console.ReadLine();


            // --------------       VARİABLES       -----------------------

            int number1 = 10;
            int number2 = 20;
            int number3 = 30;

            string stringNumber1 = "40";
            string stringNumber2 = "50";
            string word1 = "Hello";
            string word2 = "World";

            float floatNumber1 = 1.1f;
            double doubleNumber1 = 2.2;
            decimal decimalNumber1 = 3.3m;

            bool bool1 = true;
            bool bool2 = false;

            object null1 = null;

            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);

            Console.WriteLine(stringNumber1);
            Console.WriteLine(stringNumber2);
            Console.WriteLine(word1);
            Console.WriteLine(word2);

            Console.WriteLine(floatNumber1);
            Console.WriteLine(doubleNumber1);
            Console.WriteLine(decimalNumber1);

            Console.WriteLine(bool1);
            Console.WriteLine(bool2);

            Console.WriteLine(null1);


            // --------------       BYTE EXERCISES       -----------------------

            byte firstByte = 5;
            byte secondByte = 15;
            //byte thirdByte = 260;
            byte maxByte = byte.MaxValue; // .Maxvalue ile alabilecek max değer verilir.
            byte minByte = byte.MinValue; // .MinValue ile alabilecek min değer verilir.

            Console.WriteLine(firstByte);
            Console.WriteLine(secondByte);
            //  Console.WriteLine(thirdByte); bunu yazdıramadı çünkü byte 0-255 arası değer tutabilir.
            Console.WriteLine(maxByte);
            Console.WriteLine(minByte);



            // --------------       SHORT EXERCISES       -----------------------

            short firstVariable = 1;
            short secondVariable = 25500;
            short thirdVariable = short.MaxValue;
            short fourthVariable = short.MinValue;

            Console.WriteLine(firstVariable);
            Console.WriteLine(secondVariable);
            Console.WriteLine(thirdVariable);
            Console.WriteLine(fourthVariable);



            // --------------       INT EXERCISES       -----------------------

            int firstInt = 123123;
            int secondInt = int.MaxValue;
            int thirdInt = int.MinValue;

            Console.WriteLine(firstInt);
            Console.WriteLine(secondInt);
            Console.WriteLine(thirdInt);


            // --------------       LONG EXERCISES       -----------------------

            // 10 karakterden fazla sayıları tutabilir. Örneğin tc kimlik numaraları 11 haneli olduğu için long ile yazılır.

            long firstLong = 123123123123;
            long secondLong = long.MaxValue;
            long thirdLong = long.MinValue;

            Console.WriteLine(firstLong);
            Console.WriteLine(secondLong);
            Console.WriteLine(thirdLong);


            // --------------       FLOAT EXERCISES       -----------------------

            // float değer belirlerken value kısmının sonuna f konulur. Eğer f konulmazsa sistem bunu otomatik olarak double olarak kabul eder.

            float firstFloat = 0.1f;
            float secondFloat = 1.1f;
            float thirdFlooat = float.MaxValue;
            float fourthFloat = float.MinValue;

            Console.WriteLine(firstFloat);
            Console.WriteLine(secondFloat);
            Console.WriteLine(thirdFlooat);
            Console.WriteLine(fourthFloat);


            // --------------       DOUBLE EXERCISES       -----------------------

            // Double, flota göre virgülden sonra daha fazla sayı tutabilir. Bu nedenle daha ince hesaplamalar double ile yapılır.

            double firstDouble = 0.1;
            double secondDouble = double.MaxValue;
            double thirdDouble = double.MinValue;

            Console.WriteLine(firstDouble);
            Console.WriteLine(secondDouble);
            Console.WriteLine(thirdDouble);


            // --------------       BYTE EXERCISES       -----------------------

            // Decimal, double göre virgülden sonra daha fazla sayı tutabilir. Bu nedenle çok daha ince hesaplamalar decimal ile yapılır.
            // Decimal tanımlarken value'nin sonuna m eklenir. Aksi halde sistem otomatik olarak double olarak kabul eder.

            decimal firstDecimal = 0.1m;
            decimal secondDecimal = decimal.MaxValue;
            decimal thirdDecimal = decimal.MinValue;

            Console.WriteLine(firstDecimal);
            Console.WriteLine(secondDecimal);
            Console.WriteLine(thirdDecimal);


            // --------------       CHAR EXERCISES       -----------------------

            // Sadece tek bir karakteri tutmak için yapılan tanımlamalarda kullanılır. Char tanımlarken sadece tek tırnak kullanılır

            char firtChar = 'A';
            char secondChar = '3';

            Console.WriteLine(firtChar);
            Console.WriteLine(secondChar);


            // --------------       STRING EXERCISES       -----------------------

            // Char değişkeninden farklı olarak sadece bir karakteri değil metni tutar.

            string firstString = "Apple";
            string secondString = "Orange";

            Console.WriteLine(firstString);
            Console.WriteLine(secondString);


            // --------------       BOOLEAN EXERCISES       -----------------------

            //Boolean, sadece true veya false olarak sonuç doğurur.

            bool firstBoolean = true;
            bool secondBoolean = false;
            bool thirdBoolean = 4 > 8; // eğer 4, 8 den büyük ise yani sonuç doğru ise true sonuç gelir, aksi halde false sonuç gelir.

            Console.WriteLine(firstBoolean);
            Console.WriteLine(secondBoolean);
            Console.WriteLine(thirdBoolean);


            //--------------OBJECT EXERCISES-----------------------

            //Tüm variable'ları içerisinde barındırabilir. Type ayrımı yapmaz.

            object firstObject = null;
            object secondObject = 123;
            object thirdObject = "name";

            Console.WriteLine(firstObject);
            Console.WriteLine(secondObject);
            Console.WriteLine(thirdObject);


            //--------------OPERATORS EXERCISES-----------------------


            //             ARİTMETİK OPERATÖRLER


            // Toplama Operatörü : +

            int total = number1 + number2;
            // int a = int a + 5; ifadesi ile int a +=5; aynı anlama gelmektedir. Daha kolay yazım şeklidir.

            Console.WriteLine(total);


            // Çıkarma Operatörü : -

            int dif = number2 - number1;
            // int a = int a - 5; ifadesi ile int a -=5; aynı anlama gelmektedir. Daha kolay yazım şeklidir.

            Console.WriteLine(dif);


            // Çarpma Operatörü : *

            int multi = number1 * number2;
            // int a = int a * 5; ifadesi ile int a *=5; aynı anlama gelmektedir. Daha kolay yazım şeklidir.

            Console.WriteLine(multi);


            // Bölme Operatörü : /

            int div = number2 / number1;
            // int a = int a / 5; ifadesi ile int a /=5; aynı anlama gelmektedir. Daha kolay yazım şeklidir.

            Console.WriteLine(div);


            // Mod Alma Operatörü : %   -- Bölme işlemindeki kalanı gösterir.

            int mod = number2 % number1;

            Console.WriteLine(mod);


            // Artırma Operatörü : +

            number1 = number1 + 1;      // Sayımızı bir artırır.
            number1++;                  // Sayımızı bir artırır. Daha kolay yazım şeklidir.


            // Azaltma Operatörü : -

            number1 = number1 - 1;      // Sayımızı bir azaltır.
            number1--;                  // Sayımızı bir azaltır. Daha kolay yazım şeklidir.



            //             KARŞILAŞTIRMA OPERATÖRLERİ


            // Eşittir Operatörü : ==

            // Eşittir operatörü olarak "==" kullanılır. "=" ile karıştırılmaması gerekir. "=" eşittir operatörü değil atama operatörüdür.

            bool equal = number1 == number2; // Eğer number1 ve number2 birbirine eşit ise true değeri döndür. Eğer number1 ve number2 birbirine eşit değil ise false değer döndürür.

            Console.WriteLine(equal);


            // Eşit Değildir Operatörü : !=

            bool notEqual = number1 != number2; // Number1, number2'ye eşit değil mi anlamına değildir. Eğer eşit değilse true, eşit ise false değerini döndürür.

            Console.WriteLine(notEqual);


            // Büyüktür Operatörü : >

            bool bigger = number1 > number2; // number1 büyüktür number2'den anlamına gelmektedir. Eğer büyük ise true, değil ise false değer döndürür.

            Console.WriteLine(bigger);


            // Büyük Eşittir Operatörü : >=

            bool biggerOrEqual = number1 >= number2; // number1 büyüktür veya eşittir number2'den anlamına gelmektedir. Eğer büyük veya eşit ise true, değil ise false değer döndürür.

            Console.WriteLine(biggerOrEqual);


            // Küçüktür Operatörü : <

            bool lower = number1 > number2; // number1 küçüktür number2'den anlamına gelmektedir. Eğer küçük ise true, değil ise false değer döndürür.

            Console.WriteLine(lower);


            // Küçük Eşittir Operatörü : <=


            bool lowerOrEqual = number1 >= number2; // number1 küçüktür veya eşittir number2'den anlamına gelmektedir. Eğer küçük veya eşit ise true, değil ise false değer döndürür.

            Console.WriteLine(lowerOrEqual);



            //             MANTIKSAL OPERATÖRLER

            // Ve Operatörü : &&

            bool and = number1 == number2 && number1 == 4; // number1, eşit ise number2'ye ve number1 eşit ise 4'e true sonuç döndürür. Aksi halde falde değerini döndürür. Eğer tüm koşullar true ise sonuncu değişkeni döndürür, tüm koşullar true değilse bulduğu (solda sağa doğru) ilk false değerini döndürür.

            Console.WriteLine(and);


            // Veya Operatörü : ||

            bool or = number1 == number2 && number1 == 4; // number1, eşit ise number2'ye veya number1 eşit ise 4'e true sonuç döndürür.&& operatöründen farklı olarak tüm koşulların true dönmesi gerekmiyor.Soldan sağa doğru ilk true değerini döndürür. Tüm koşullar false ise son false değerini döndürür.

            Console.WriteLine(or);


            // Değil Opeatörü : !

            // Değil anlamına gelmektedir. Mevcut değerinin aksini döndürür. True olan false olur, false olan true olur.

            bool not = number1 == number2;

            Console.WriteLine(!not);   // number1 ve number2 birbirine eşit olmadığı için false değeri dönmesi gerekirken "!not" yazıldığı için false'in değili olan true sonucunu döndüür.



            // --------------       GET VALUE EXERCISES (DEĞER ALMA)      ----------------------- 

            Console.WriteLine("Please Enter Your Name");
            // string name = Console.ReadLine();
            // Console.WriteLine("Your name is"+ " "  + name);      

            Console.WriteLine("Please Enter Your Surname");
            // string surname = Console.ReadLine();
            // Console.WriteLine("Your surname is"+ " " + surname);

            //Console.WriteLine($"Your are {name} {surname}");




            // --------------       TÜR DÖNÜŞÜMÜ      ----------------------- 

            // Console.Readline() ile alınan verilerin tamamı string türündedir. Diğer tiplerde kullanacak isek tür dönüşümü yapmamız gerekir.


            //             INT.PARSE

            // Sadece "String" tipindeki değişkeni "Int" tipine dönüştürür.

            int intParseExample1 = int.Parse(stringNumber1);

            Console.WriteLine(intParseExample1.GetType());   // value.GetType() methodu veri tipini döndürür. 
            Console.WriteLine(intParseExample1);


            Console.WriteLine("Please Enter Your Money");

            //int haveBread = int.Parse(Console.ReadLine())/5; // 1 adet ekmeğin 5 TL olduğu kabul edilerek kaç ekmek alabileceğini hesaplıyoruz.
            //Console.WriteLine($"You can buy {haveBread} bread"); 



            //             CONVERT.TOINT32

            // "Int" tipine dönüştürülebilecek tüm veri tiplerini "Int" veri tipine dönüştürür. Ondalıklı sayıların sadece tam sayı kısmını alır, Ondalık kısmı dışlar.

            int toInt32Example1 = Convert.ToInt32(stringNumber1);

            Console.WriteLine(toInt32Example1.GetType());
            Console.WriteLine(toInt32Example1);


            int toInt32Example2 = Convert.ToInt32(floatNumber1);
            Console.WriteLine(toInt32Example2.GetType());
            Console.WriteLine(toInt32Example2);



            //             TO.STRING

            // Herhangi bir veri tipinden string veri tipine dönüştürme yapar.

            string toStringExamples1 = number1.ToString();

            Console.WriteLine(toStringExamples1.GetType());
            Console.WriteLine(toStringExamples1);

            string toStringExamples2 = bool1.ToString();

            Console.WriteLine(toStringExamples2.GetType());
            Console.WriteLine(toStringExamples2);


            string toStringExamples3 = floatNumber1.ToString();

            Console.WriteLine(toStringExamples3.GetType());
            Console.WriteLine(toStringExamples3);



            // --------------      IF ELSE      ----------------------- 

            // if ile bir koşul yazılır. Koşul boolean bir sonuç doğurur. Eğer true döndürürse if'in içerisindeki kod çalışır ve if'in içerisinden çıkar, eğer false döndürürse varsa else if'e, else if yok ise doğrudan else'teki kodu çalıştırır.


            //Aşağıda bir if yapısıne örnek verilmiştir. 

            if (number1 == 1)
            {

            }
            else if (number2 == 2)
            {

            }
            else
            {

            }

            //Console.WriteLine("Please Enter Student's note");
            //int studentsNote1 = int.Parse(Console.ReadLine());
            //if (studentsNote1 >= 80)
            //{
            //    Console.WriteLine("Your note is A");
            //}
            //else if (studentsNote1 >= 60 && studentsNote1 < 80)
            //{
            //    Console.WriteLine("Your note is B");
            //}
            //else if (studentsNote1 >= 40 && studentsNote1 < 60)
            //{
            //    Console.WriteLine("Your note is C");
            //}
            //else
            //{
            //    Console.WriteLine("You are unsuccesfull");
            //}


            // --------------       SWICH CASE      ----------------------- 


            //Aşağıda bir if yapısıne örnek verilmiştir. 

            switch (word1)
            {
                case "A":
                    Console.WriteLine();
                    break;

                case "B":
                    Console.WriteLine();
                    break;

                case "C":
                    Console.WriteLine();
                    break;

                case "D":
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine();
                    break;

            }


            //Console.WriteLine("Please Enter Your Phone Brand?");
            //string phoneBrand = Console.ReadLine().ToLower(); // ToLower methodu ile tüm string küçük harfe çevrilir. Bu sayede kullanıcının büyük harfle yazması durumunda kodun doğru çalışmasını sağlıyoruz. Çünkü C# case sensetive bir yazılım dilir.


            //switch (phoneBrand)
            //{
            //    case "apple":
            //        Console.WriteLine("You are using IOS system");
            //        break;

            //    case "samsung":
            //        Console.WriteLine("You are using Android system");
            //        break;

            //    case "huawei":
            //        Console.WriteLine("You are using Android system");
            //        break;

            //    case "xiaomi":
            //        Console.WriteLine("You are using Android system");
            //        break;

            //    default:
            //        Console.WriteLine("You did not enter your phone brand correctly");
            //        break;

            //}



            // --------------       LOOPS (DÖNGÜLER)     ----------------------- 

            // Koşul sağlanana kadar döngü dönmeye devam eder. Koşul sağlandığında döngüden çıkar.
            // 4 tane döngü vardır. 1- For, 2- While, 3- Do While, 4- Foreach


            //             FOR DÖNGÜSÜ

            // For döngüsünde koşul 3 aşamada yazılır. 1. aşamada değişkenimize bir değer ataması yaparız. 2. aşamada koşulumuzu yazarız. 3. aşamada ise döngünün 1 kez dönmesi halinde ne yapılması gerektiğini yazarız. Çalışma sırası 1- 1. aşama, 2- 2. aşama (koşul sağlıyorsa alt satıra geçer, koşul sağlamıyorsa for döngüsünden çıkar), 3- altta yazılan kod çalışır 4- 3. aşama. 

            // 1. aşamada yazılan değer 2. aşamadaki koşulu sağlıyorsa altta yazan kodu çalıştırır ve 3. aşamaya geçer. 3. aşamada değişken yeni bir değer alır ve 1. aşamaya döner.

            // Döngü döndüğü sürece yap manasında bir döngüdür.



            //Aşağıda for döngüsüme örnek verilmiştir.

            for (int forExample1 = 1; forExample1 <= 10; forExample1++)  // 1'den 10'a kadar olan sayıları yazdırır.
                Console.WriteLine(forExample1);


            // Aşağıda iç içe döngülere örnek verilmiştir. 

            for (int forExample2 = 1; forExample2 <= 10; forExample2++)
            {
                for (int forExample3 = 1; forExample3 <= forExample2; forExample3++)
                {
                    Console.Write(forExample3);

                }
                Console.WriteLine("");
            }


            //             WHILE DÖNGÜSÜ

            // İçerideki döngü çalıştığı süre boyunca while döngüsü sonuç döndürmeye devam eder. İlk koşulu kontrol eder, koşul sağlanıyorsa döndürür. Koşul sağlamazsa while döngüsüne hiç girmeden devam eder.For ile benzerdir. 

            // Döngü döndüğü sürece yap manasında bir döngüdür.

            // Aşağıda while döngüsüme örnek verilmiştir.


            int whileExample1 = 1;
            while (whileExample1 <= 10)
            {
                Console.WriteLine(whileExample1);
                whileExample1++;
            }



            //             DO WHILE DÖNGÜSÜ

            // While döngüsüyle aynıdır. Sadece bir fark vardır. Do while döngüsünde while döngüsüne girmeden önce bir sefer "DO" yu çalıştırır sonra devam eder. Eğer koşul sağlanmıyorsa while döngüsünde hiç sonuç döndürülmez iken do while döngüsünde koşul sağlanmasa dahi bir kez sonuç döndürür.

            // Önce yap, döngü döndüğü sürece yapmaya devam et manasında bir döngüdür.


            // Aşağıda Do While döngüsüme örnek verilmiştir.

            int doWhileExample1 = 1;
            do
            {
                Console.WriteLine(doWhileExample1);
                doWhileExample1++;
            } while (doWhileExample1 <= 10);


            // Aşağıda 1'den 100'e kadar sayıların toplamını bulan bir do while döngüsü örneği yazılmıştır.

            int doWhileNumber1 = 1;
            int doWhileTotal = 0;

            do
            {
                doWhileTotal += doWhileNumber1;
                doWhileNumber1++;
            } while (doWhileNumber1 <= 100);


            //             BREAK

            // Döngü içerisinde koşulun sağlanması durumunda döngüyü kırıp döngüden çıkmasını istediğimiz durumlarda break kullanırız.

            // Aşağıda Break'e örnek verilmiştir. 

            for (int breakExample1 = 1; breakExample1 <= 10; breakExample1++)
            {
                if (breakExample1 == 5)
                {
                    break;
                }
                Console.WriteLine(breakExample1);
            }


            //             CONTINUE

            // Döngü içerisinde koşulun sağlanması durumunda 1 defaya mahsus döngüyü kırar, o döngüyü çalıştırmış kabul ederek döngünün içerisinden çıkmadan bir sonraki aşamaya geçer.

            // Aşağıda Break'e örnek verilmiştir.

            for (int continueExample1 = 1; continueExample1 <= 10; continueExample1++)
            {
                if (continueExample1 == 5)
                {
                    continue;
                }
            }





            // --------------       ARRAY (DİZİLER)    ----------------------- 


            // Variable'a tek bir dizi ile birden fazla değer verilebilir. [] ile gösterilir. Diziler 0 dan başlar. x.lenght ile dizinin uzunluğu yani içerisinde kaç tane değer olduğunu bulabiliriz. (x yerine array'in adı yazılacak.)

            // Aşağıda Array'e örnek verilmiştir. 


            int[] arrayNumbers1 = new int[4]; // Burada bir array tanımlıyoruz ama içerisine değer ataması yapmıyoruz. [] içerisine yazdığımız sayı kadar değer yeri açıyoruz. Bu yerleri daha sonra doldurabiliyoruz.

            arrayNumbers1[0] = 10;
            arrayNumbers1[1] = 20;
            arrayNumbers1[2] = 30;
            arrayNumbers1[3] = 40;

            Console.WriteLine(arrayNumbers1[1]); //Dizinin 1. değerini yazdır demek. 20 yazdırır.

            for (int i = 0; i < arrayNumbers1.Length; i++)
            {
                Console.WriteLine(arrayNumbers1[i]);
            }

            // İstersen array'i tanımladıktan sonra değerleri de aynı satırda atayabiliriz. Bunun için {} kullanırız ve her değerin arasına virgül koyarız.

            string[] arrayString1 = { "Car", "Phone", "Book", "Computer" };

            Console.WriteLine(arrayString1[2]);

            for (int i = 0; i < arrayString1.Length; i++)
            {
                Console.WriteLine(arrayString1[i]);
            }


            double[] arrayDouble1 = { 1.1, 2.2, 3.3, 4.4 };
            {
                for (int i = 0; i < arrayDouble1.Length; i++)
                {
                    Console.WriteLine(arrayDouble1[i]);
                }
            }

            char[] arrayChar1 = { 'a', 'b', 'c', };
            for (int i = 0; i < arrayChar1.Length; i++)
            {
                Console.WriteLine(arrayChar1[i]);
            }


            // Aşağıda verilen örnekte kullanıcıdan alınan değerleri dizilerin içerisine atanmaktadır.

            //int[] arrayNumber2 = new int[4];

            //for (int i = 0; i < arrayNumber2.Length; i++)
            //{
            //    Console.WriteLine("Please enter your " + (i+1)+ ". index value");
            //    arrayNumber2[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < arrayNumber2.Length; i++)
            //{
            //    Console.WriteLine("Your" + (i+1) +". index is " + arrayNumber2[i]);
            //}



            //             FOREACH DÖNGÜSÜ

            // For döngüsüyle çok benzerdir. Yazımı daha kolaydır. Her bir değer için ayrı bir ayrı kod yazılmasına gerek kalmaksızın tek seferde her değeri tek tek çalıştırır.

            string[] foreachExample1 = { "Car", "Phone", "Book", "Computer" };

            foreach (string item in foreachExample1)
            {
                Console.WriteLine(item);
            }


            // --------------       METHODLAR    ----------------------- 

            //MethodExample1(); // Bu method konsola "Hello World!" yazdırır

            //MethodExample2(); // Bu method parantez içerisine yazılan iki değeri toplar. Değer döndürmeyen methodla toplar

            //MethodExample3(1, 2); // Bu method parantez içerisine yazılan iki değeri toplar. Değer döndüren methodla toplar

            //Console.WriteLine(MethodExample3(3, 4)); // Methodun doğrudan kullanımı

            //int MethodExample3Value = MethodExample3(1, 2); //Methodun atama yapılarak kullanımı

            //Console.WriteLine(MethodExample3Value);


            //MethodExample4(); //  Bu method double türünde hipotenüsü hesaplar. Değer döndürür.
            //double MethodExample4Value = MethodExample4(3.3, 4.4); // Methodun doğrudan kullanımı


            //Console.WriteLine("enter"); // Methodun kullanıcının girdi alınarak kullanımı
            //double MethodExample4Number3 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("enter");
            //double MethodExample4Number4 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(MethodExample4(MethodExample4Number3, MethodExample4Number4));


            //             CONSTRUCTOR METHOD (YAPICI METHOD)

            // Contructor methodlar, bir class'ın içerisinde tanımlanan o class'a özgü olan, geriye dönüşü olmayan, o class ile aynı ismi taşımak zorunda olan methodtur. "ClassCars classCars1 = new ClassCars();" ifadesindeki "new classCars1"in henüz "classCars1"e araması yapılmadan önce çalıştırdığı kodtur. Atamalar sağdan sola doğru yapıldığı için atama işleminin hemen öncesinde "new classCars1" çalışır sonra atama işlemi yapılır.

            //int carDoor2 = 4;
            //string carModel2 = "Renault";
            //string carColur2 = "Red";

            //ClassCars cars2 = new ClassCars(4, "Renault", "Red"); // Yukarıda ayrı ayrı değer verilmeksizin bu şekilde de değer verilebilir.
            //ClassCars cars2 = new ClassCars(carDoor2, carModel2, carColur2);


            //Console.WriteLine("Car's colour is " + cars2.carColour);
            //Console.WriteLine("Car's model is " + cars2.carColour);
            //Console.WriteLine("There are " + cars2.carDoor + "doors");





            // --------------       CLASS    ----------------------- 

            // Solution Explorer kısmında "classCars1" ismiyle tanımladığımız class'ı buraya çağırıyoruz.

            //ClassCars classCars1 = new ClassCars(0, "", "");  // ClassCars()'de parantez içerisine değer yazılması gerekiyor. İster default değer atarız, 

            //classCars1.carDoor = 4;
            //classCars1.carColour = "Red";
            //classCars1.carModel = "Renault";

            //classCars1.carStart();
            //classCars1.carDoorClose();

            //Console.WriteLine($"There are {classCars1.carDoor} doors");
            //Console.WriteLine($"Car's colour is {classCars1.carDoor}");
            //Console.WriteLine($"Car's model is {classCars1.carModel}");


            //             PUBLİC AND PRIVATE 

            // Aşağıda public ve private örnekleri verilmiştir. Customer isimli class oluşturuldu. O class ile bağlantılı olarak çalışıldı.

            //Customer customer1 = new Customer();

            //customer1.Name = "Sebastian";
            //customer1.Surname = "Vettel";
            //customer1.Salary = 1000;
            //customer1.Gender = "Male";

            //  customer1.age = 20; // Age bilgisi private olduğu için buradan erişemeyiz. Hata verir. Private bilgiler sadece tanımlandığı class'ın içerisinden erişilebilir.



            // --------------       ENCAPSULATİON    ----------------------- 

            //Private classlara dışarıdan erişim sağlayamıyoruz. Ancak bu private'ları kullanmamız gerektiğinde encapsulation ile erişim sağlayabiliyoruz.

            // Aşağıda Encapsulation örneği verilmiştir.

            //Encapsulation student1 = new Encapsulation();

            //student1.setName("Sebastian");  // Normalde private olanlara erişemiyoruz ancak setName ile değer ataması yapıp private bilgiyi kullanabiliyoruz.
            //student1.getName(); //setName ile private'ın içerisine ataması yapılan değere getName ile erişebiliriz.

            //string getName1 = student1.getName();  // Kapsullemenin neden ve nasıl kullanıldığına dair bir örnek.
            //if (getName1 == "Sebastian")
            //{
            //    Console.WriteLine("Succesfull");
            //}
            //else
            //{
            //    Console.WriteLine("Unsuccesfull");
            //}


            // --------------       PROPERTY    ----------------------- 


            Console.ReadLine();
        }
        //static void MethodExample1()
        //{

        //    // --------------       METHOD    ----------------------- 

        //    // Yukarıda Parametresiz - Geriye Değer Döndürmeyen Method örnek verilmiştir. Kodumuzumu yazdığımız static'ten dışarı çıkarak yeni bir statik açarak method tanımlaması yapıyoruz. 

        //    // methodExamples1 ismiyle kaydettiğimiz method aşağıda yazılan "Hello World" yazısını konsola yazdırıyor. Bu methodu yazdıktan sonra kodumuzun istediğimiz yerine MethodExample1 yazdığımızda doğrudan konsola "Hello World!" yazdırılacak

        //    // methodu çalıştırmak için methodismi(); yazmamız lazım. Örnek: methodExample(); yazdığımızda konsola "Hello World!" yazdırır.

        //    Console.WriteLine("Hello World!");



        //}

        //static void MethodExample2()
        //{

        //    // Yukarıda Parametreli - Geriye Değer Döndürmeyen Method örnek verilmiştir. Kodumuzumu yazdığımız static'ten dışarı çıkarak yeni bir statik açarak method tanımlaması yapıyoruz.

        //    Console.WriteLine("Please Enter Your First Number");
        //    int methodNumber1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Please Enter Your Second Number");
        //    int methodNumber2 = Convert.ToInt32(Console.ReadLine());
        //    int MethodExample2Total = methodNumber1 + methodNumber2;
        //    Console.WriteLine(MethodExample2Total);

        //}

        //static int MethodExample3(int methodNumber3, int methodNumber4)
        //{
        //    int MethodExample3Total = methodNumber3 + methodNumber4;
        //    return MethodExample3Total;
        //}

        ///// <summary> // Methodun içerisine "///" yazarsak methodla ilgili bilgiler vereceğimiz satırlar  
        ///// Bu fonksiyon girilen kenar uzunluklarının hipotenüsünü hesaplar
        ///// </summary>
        ///// <param name="MethodExample4Number1">Uzunluk metre cinsinden</param>
        ///// <param name="MethodExample4Number2">Uzunluk metre cinsinden</param>
        ///// <returns>Hipotenüsü return eder</returns>
        //static double MethodExample4(double MethodExample4Number1, double MethodExample4Number2)
        //{
        //    double MethodExample4Hipotenus = (MethodExample4Number1 * MethodExample4Number1) + (MethodExample4Number2 * MethodExample4Number2);
        //    return Math.Sqrt(MethodExample4Hipotenus);

        //}
    }
}
