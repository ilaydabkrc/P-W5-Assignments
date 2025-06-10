using System;
using System.Collections.Generic;
using System.Linq;

// Film sınıfı: film adı ve IMDB puanı bilgisini tutar
class Movie
{
    public string Name { get; set; }
    public double ImdbScore { get; set; }

    public Movie(string name, double score)
    {
        Name = name;
        ImdbScore = score;
    }
}

class Program
{
    static void Main()
    {
        // Film listesi oluşturuluyor
        List<Movie> movieList = new List<Movie>();
        string answer;

        // Kullanıcıdan film bilgisi alındığı döngü
        do
        {
            Console.Write("Film ismini girin: ");
            string name = Console.ReadLine();

            double score;
            // Geçerli IMDb puanı alınıncaya kadar kullanıcıdan giriş istenir
            while (true)
            {
                Console.Write("Imdb puanını girin (0-10 arası): ");
                if (double.TryParse(Console.ReadLine(), out score) && score >= 0 && score <= 10)
                    break;
                Console.WriteLine("Geçerli bir puan giriniz!");
            }

            // Yeni film nesnesi oluşturulup listeye eklenir
            movieList.Add(new Movie(name, score));

            // Kullanıcıya tekrar film eklemek isteyip istemediği sorulur
            Console.Write("Yeni bir film eklemek istiyor musunuz? (evet/hayır): ");
            answer = Console.ReadLine().ToLower();

        } while (answer == "evet");

        // Tüm filmler listelenir
        Console.WriteLine("\n--- Tüm Filmler ---");
        foreach (var movie in movieList)
        {
            Console.WriteLine($"Film: {movie.Name}, IMDB: {movie.ImdbScore}");
        }

        // IMDb puanı 4 ile 9 arasında olan filmler listelenir
        Console.WriteLine("\n--- IMDB Puanı 4 ile 9 Arasında Olan Filmler ---");
        var mediumRatedMovies = movieList.Where(m => m.ImdbScore >= 4 && m.ImdbScore <= 9);
        foreach (var movie in mediumRatedMovies)
        {
            Console.WriteLine($"Film: {movie.Name}, IMDB: {movie.ImdbScore}");
        }

        // İsmi 'A' harfi ile başlayan filmler ve puanları listelenir
        Console.WriteLine("\n--- İsmi 'A' ile Başlayan Filmler ---");
        var moviesStartingWithA = movieList.Where(m => m.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase));
        foreach (var movie in moviesStartingWithA)
        {
            Console.WriteLine($"Film: {movie.Name}, IMDB: {movie.ImdbScore}");
        }

        Console.WriteLine("\nProgram sonlandı.");
    }
}
