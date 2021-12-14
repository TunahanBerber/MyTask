using System;
using System.Collections.Generic;
using Business.Concrete;
using Entities.Concrete;


namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            SelamVer(isim:"Engin");
            SelamVer(isim:"Tunahan");
            SelamVer(isim:"Büşra");
            SelamVer();

            int sounuc = Topla(6,58);

            //Diziler / Arrays
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Tunahan";
            ogrenciler[2] = "Büşra";

            for (int i = 0; i <ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            Person person1 = new Person();
            person1.FirstName = "Tunahan";
            person1.LastName = "Berber";
            person1.DateOfBirthYear = 1999;
            person1.NationalIdentity =12345678910;

            Person person2 = new Person();
            person2.FirstName = "Büşra";

            List<string> yeniSehirler1 = new List<string>{"Ankara", "İstanbul", "İzmir"};  //Generic Collection
            yeniSehirler1.Add("Hatay");

            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            Console.ReadLine();
        }

        //resharper
        static void SelamVer(string  isim="noname")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5 , int sayi2 = 10)  //default parametreler en sona yazılır
        {
            int sonuc =sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc.ToString() );
            return sonuc;
        }

    }
}