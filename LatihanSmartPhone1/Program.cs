ISmartphone hpBudi = new IPhone();

Fotografer fotografer = new Fotografer();
fotografer.Kerja(hpBudi);

hpBudi = new Samsung();
fotografer.Kerja(hpBudi);

interface ISmartphone
{
    public void Ambilfoto();
}

class IPhone : ISmartphone
{
    public void Ambilfoto()
    {
        Console.WriteLine("Mengaktifkan sensor kamera...Cekrek");
    }
}

class Samsung : ISmartphone
{
    public void Ambilfoto()
    {
        Console.WriteLine("Mengaktifkan fitur beauty");
    }
}

class Fotografer
{
    public void Kerja(ISmartphone hp)
    {
        hp.Ambilfoto();
    }
}