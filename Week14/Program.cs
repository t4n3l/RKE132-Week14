Console.WriteLine("Anna oma kutsule nimi:");
string kutsuNimi = Console.ReadLine();
Kutsu minuKutsu = new Kutsu(kutsuNimi);



Kutsu naabriteKoer = new Kutsu("Rose");

Console.WriteLine($"Minu kutsu nimi on {minuKutsu.Nimi}.");
Console.WriteLine($"Minu naabri kutsu nimi on {naabriteKoer.Nimi}.");

minuKutsu.Rename("paha poiss");

while (minuKutsu.Onnelikkus != 5)
{
    minuKutsu.Haugu();
}

minuKutsu.LehvitaSaba();

class Kutsu
{
    private string _nimi = "Kutsu";
    private int _onnelikkus = 0;

    public Kutsu(string nimi)
    {
        _nimi = nimi;
        _onnelikkus = 0;
    }

    public string Nimi
    {
        get { return _nimi; }
    }
    public int Onnelikkus
    {
        get { return _onnelikkus; }
    }

    public void Rename(string uusNimi)
    {
        _nimi = uusNimi;
        Console.WriteLine($"Sinu kutsu uus nimi on: {uusNimi}");
    }

    public void Haugu()
    {
        Console.WriteLine("Auh-Auh");
        _onnelikkus++;
    }

    public void LehvitaSaba()
    {
        Console.WriteLine("wiggle-wiggle!");
    }
}