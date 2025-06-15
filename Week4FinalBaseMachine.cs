public abstract class BaseMachine
{
    public DateTime UretimTarihi { get; private set; }
    public string SeriNo { get; set; }
    public string Ad { get; set; }
    public string Aciklama { get; set; }
    public string IsletimSistemi { get; set; }

    public BaseMachine()
    {
        UretimTarihi = DateTime.Now;
    }

    public virtual void BilgileriYazdir()
    {
        Console.WriteLine("\n------------------------ Genel Ürün Bilgileri ------------------------");
        Console.WriteLine($"Ad: {Ad}");
        Console.WriteLine($"Seri No: {SeriNo}");
        Console.WriteLine($"Açıklama: {Aciklama}");
        Console.WriteLine($"İşletim Sistemi: {IsletimSistemi}");
        Console.WriteLine($"Üretim Tarihi: {UretimTarihi}");
    }

    public abstract void UrunAdiGetir();
}
public class Telefon : BaseMachine
{
    public bool TrLisansli { get; set; }

    public override void BilgileriYazdir()
    {
        base.BilgileriYazdir();
        Console.WriteLine($"TR Lisanslı mı: {(TrLisansli ? "Evet" : "Hayır")}");
    }

    public override void UrunAdiGetir()
    {
        Console.WriteLine($"Telefonunuzun adı ---> {Ad}");
    }
}

public class Bilgisayar : BaseMachine
{
    private int usbGirisSayisi;
    public int UsbGirisSayisi
    {
        get { return usbGirisSayisi; }
        set
        {
            if (value == 2 || value == 4)
                usbGirisSayisi = value;
            else
            {
                Console.WriteLine("Uyarı: USB girişi sayısı sadece 2 veya 4 olabilir. -1 olarak atanıyor.");
                usbGirisSayisi = -1;
            }
        }
    }
    public bool Bluetooth { get; set; }

    public override void BilgileriYazdir()
    {
        base.BilgileriYazdir();
        Console.WriteLine($"USB Giriş Sayısı: {UsbGirisSayisi}");
        Console.WriteLine($"Bluetooth Var mı: {(Bluetooth ? "Evet" : "Hayır")}");
    }

    public override void UrunAdiGetir()
    {
        Console.WriteLine($"Bilgisayarınızın adı ---> {Ad}");
    }
}