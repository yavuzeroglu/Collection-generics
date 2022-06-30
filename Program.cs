using System;
using System.Collections.Generic;

namespace koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<T> class 
            //System.Collection.Generic
            //T-> object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("mor");
            renkListesi.Add("Mavi");
            renkListesi.Add("Yeşil");
            renkListesi.Add("Sarı");
            renkListesi.Add("Siyah");
            renkListesi.Add("Haki");

            //Count
            Console.WriteLine(renkListesi.Count());
            Console.WriteLine(sayiListesi.Count());
            //foreach ve List.Foreach ile elemanları listele
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk.ToUpper());
            }
            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //Listeden eleman çıkartma
            sayiListesi.Remove(5);
            renkListesi.Remove("Yeşil");

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);
            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));


            //**Liste içerisinde arama**

            if(sayiListesi.Contains(10))
                Console.WriteLine("10 liste içerisinde bulundu");


            //Eleman ve index'e erişme 
            Console.WriteLine(renkListesi.BinarySearch("Sarı")); 
            Console.WriteLine(renkListesi.BinarySearch("Siyah"));  
            Console.WriteLine(renkListesi.BinarySearch("Haki")); 

            //Diziye List'e Çevirme
            string[] hayvanlar = {"kedi","köpek","martı"};
            List<string> hayvanListesi = new List<string>(hayvanlar);
            
            //Listeyi nasıl temizlerim?
            hayvanListesi.Clear();

            //List içerisinde nesne tutmak 
            List<Kullanicilar> kullanicilars 
            = new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Ad = "Yavuz";
            kullanici1.Soyad ="Yılmaz";
            kullanici1.Yas = 26;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Ad = "Fatma";
            kullanici2.Soyad ="Kuş";
            kullanici2.Yas = 22;


            Kullanicilar kullanici3 = new Kullanicilar();
            kullanici3.Ad = "Yavuz";
            kullanici3.Soyad ="Yılmaz";
            kullanici3.Yas = 26;

            kullanicilars.Add(kullanici1);
            kullanicilars.Add(kullanici2);
            kullanicilars.Add(kullanici3);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar(){
                Ad = "Mustafa Kemal", Soyad="Ataturk",Yas=26
                
            });

            foreach (var item in kullanicilars)
            {
                Console.WriteLine("Kullanici Adi :"+item.Ad);
                Console.WriteLine("Kullanici Soyadi :"+item.Soyad);
                Console.WriteLine("Kullanici Yas :"+item.Yas);
            }





        }
    }

    public class Kullanicilar
    {
        string ad;
        string soyad;
        short yas;

        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public short Yas { get => yas; set => yas = value; }
    }
}