/*Bok / Film - info
Lag en applikasjon der man kan skrive inn forskjellige detaljer, og etter man har skrevet inn alt få printet tilbake det som ble skrevet inn som et “produkt”, enten en film eller en bok, dere velger.
    Man skal bli spurt av konsollen om Tittel, så år det kom ut, litt beskrivelse av hva filmen eller boken handler om, forfatter/regissør, hvilke skuespillere som var med.
    Når alle spørsmål er besvart skal man kunne få se boken eller filmen man skrev inn som et produkt, med alle egenskaper listet opp.
    BONUS:
Legg til mulighet for å skrive inn flere bøker eller filmer, her trenger man å ta i bruk lister, neste ukes pensum*/

using System.Security.Cryptography.X509Certificates;
using PP_UKE_2;

class Program
{
static void Main(string[] args)
{
    List<Bok> Books = new List<Bok>();
    
    bool start = true;

    while (start)
    {
        Console.WriteLine("Velg sjanger å legge inn (1) for bok, (2) for film :). Skriv (3) for å avslutte");
        string valg = Console.ReadLine();

        if (valg == "1")
        {
            Books.Add(LeggtilBok());
        }
        else if (valg == "2")
        {
            Movies.printMovie();
        }
        else if (valg == "3")
        {
            start = false;
            Console.WriteLine("Ha det bra :)");
            System.Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Ugyldig valg, vennligst skriv (1) eller (2) ");
            continue;
        }
    }
    
    static Bok LeggtilBok()
    {
        Console.WriteLine("Skriv inn Tittel");
        string tittel = Console.ReadLine();

        Console.WriteLine("Skriv inn Utgivelsesår");
        string utgivelsesår = Console.ReadLine();

        Console.WriteLine("Skriv inn Forfatter");
        string forfatter = Console.ReadLine();

        Console.WriteLine("Skriv inn Beskrivelse");
        string beskrivelse = Console.ReadLine();

        // return new Bok(tittel, utgivelsesår, forfatter, beskrivelse);
        Console.WriteLine($"Tittelen på boka er: {tittel}");
        Console.WriteLine($"Utgivelsesåret på boka er: {utgivelsesår}");
        Console.WriteLine($"Forfatteren på boka er: {forfatter}");
        Console.WriteLine($"En liten beskrivelse av boka: {beskrivelse}");

        return null;
    }

    // static void Showbooks(List<Bok> Books) 
    // { 
    //     Console.WriteLine("\nBokoversikt"); 
    //     foreach (var Bok in Books) 
    //     { 
    //         Console.WriteLine(Bok);
    //     }
    // } 
} 
}


