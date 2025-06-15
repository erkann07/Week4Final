using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n------------------------ Ürün Üretim Sistemi ------------------------");
            Console.Write("Telefon üretmek için 1, Bilgisayar üretmek için 2'ye basınız: ");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Telefon tel = new Telefon();

                Console.Write("Ad: "); tel.Ad = Console.ReadLine();
                Console.Write("Seri No: "); tel.SeriNo = Console.ReadLine();
                Console.Write("Açıklama: "); tel.Aciklama = Console.ReadLine();
                Console.Write("İşletim Sistemi: "); tel.IsletimSistemi = Console.ReadLine();
                Console.Write("TR Lisanslı mı? (evet/hayır): ");
                string tr = Console.ReadLine().ToLower();
                tel.TrLisansli = (tr == "evet");

                Console.WriteLine("\nTelefon başarıyla üretildi!");
                tel.UrunAdiGetir();
                tel.BilgileriYazdir();
            }
            else if (secim == "2")
            {
                Bilgisayar pc = new Bilgisayar();

                Console.Write("Ad: "); pc.Ad = Console.ReadLine();
                Console.Write("Seri No: "); pc.SeriNo = Console.ReadLine();
                Console.Write("Açıklama: "); pc.Aciklama = Console.ReadLine();
                Console.Write("İşletim Sistemi: "); pc.IsletimSistemi = Console.ReadLine();
                Console.Write("USB Giriş Sayısı (2 veya 4): ");
                int usb;
                int.TryParse(Console.ReadLine(), out usb);
                pc.UsbGirisSayisi = usb;
                Console.Write("Bluetooth var mı? (evet/hayır): ");
                string bt = Console.ReadLine().ToLower();
                pc.Bluetooth = (bt == "evet");

                Console.WriteLine("\nBilgisayar başarıyla üretildi!");
                pc.UrunAdiGetir();
                pc.BilgileriYazdir();
            }
            else
            {
                Console.WriteLine("Geçersiz seçim. Lütfen 1 veya 2 giriniz.");
                continue;
            }

            Console.Write("\nBaşka bir ürün üretmek istiyor musunuz? (evet/hayır): ");
            string secim1 = Console.ReadLine().ToLower();
            if (secim1 == "hayır")
            {
                Console.WriteLine("İyi günler!");
                break;
            }
        }
    }
}

