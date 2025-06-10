using System;
using System.Collections.Generic;

class program
{
    static void Main()
    {
        List<string> kahveListesi = new List<string>();

        for(int i = 1; i <= 5; i++)
        {

            Console.WriteLine($"Kahve {i} adını girin: ");
            string kahve = Console.ReadLine();

            kahveListesi.Add(kahve);
        }
        Console.WriteLine("Girilen kahve isimleri: ");

        int sıra = 1;
        foreach(string kahve in kahveListesi)
        {
            Console.WriteLine(kahve);
            
            sıra++;
        }

    }



}