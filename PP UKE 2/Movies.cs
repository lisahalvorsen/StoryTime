using System.Net.Cache;

namespace PP_UKE_2;

public class Movies
{
    public string Title { get; set; }
    public int ReleaseYear { get; set; }
    public string Director { get; set; }
    public string Genre { get; set; }
    public string Actors { get; set; }

    public Movies(string title, int releaseYear, string director, string genre, string actors)
    {
        Title = title;
        ReleaseYear = releaseYear;
        Director = director;
        Genre = genre;
        Actors = actors;
    }

    public static void printMovie()
    {
        Console.WriteLine("Skriv inn tittel på filmen");
        string title = Console.ReadLine();

        Console.WriteLine("Skriv inn utgivelsesåret");
        int releaseYear = int.Parse(Console.ReadLine());

        Console.WriteLine("Skriv inn regissøren");
        string director = Console.ReadLine();

        Console.WriteLine("Skriv inn sjangeren");
        string genre = Console.ReadLine();
        
        Console.WriteLine("Skriv inn hvilke skuespillere som var med");
        string actors = Console.ReadLine();

        Console.WriteLine($"Tittelen på filmen er: {title}");
        Console.WriteLine($"Utgivelsesåret til filmen er: {releaseYear}");
        Console.WriteLine($"Regissøren av filmen er: {director}");
        Console.WriteLine($"Filmens sjanger er: {genre}");       
        Console.WriteLine($"Skuespillerne som var med i filmen: {actors}");
    }
}