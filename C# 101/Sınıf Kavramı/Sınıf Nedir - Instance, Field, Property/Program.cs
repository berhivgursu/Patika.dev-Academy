using System;

namespace Sinif_Nedir
{
    class Program
    {
        public static void Main(string[] args)
        {
           // Söz Dizimi
           // class SinifAdi
           // {
           //     [Erisim Belirleyici] [Veri Tipi] OzellikAdi;
           //     [Erisim Belirleyici] [Geri Dönüs Tipi] MetotAdi{ [Parametre Listesi] }
           //     {
           //           // Metot Komutları
           //     }
           // }

           // Erisim Belirleyiciler
           // * Public
           // * Private
           // * Internal
           // * Protected

           Calisan calisan1 = new Calisan();
           calisan1.Ad = "Ayşe";
           calisan1.Soyad = "Kara";
           calisan1.No = 23425634;
           calisan1.Departman = "İnsan Kaynakları";

           calisan1.CalisanBilgileri();

           Calisan calisan2 = new Calisan();
           calisan2.Ad = "Deniz";
           calisan2.Soyad = "Arda";
           calisan2.No = 25646789;
           calisan2.Departman = "Satın Alma";

           calisan2.CalisanBilgileri();
        }
    }
}

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;
    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışan Adı:{0}", Ad);
        Console.WriteLine("Çalışan Soyadı:{0}", Soyad);
        Console.WriteLine("Çalışan Numarası:{0}", No);
        Console.WriteLine("Çalışan Departmanı:{0}", Departman);
    }
}