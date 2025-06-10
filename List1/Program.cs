using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        List<string> davetliler = new List<string>()
        {
            "Bülent Ersoy",
            "Ajda Pekkan",
            "Ebru Gündeş",
            "Hadise",
            "Hande Yener",
            "Tarkan",
            "Funda Arar",
            "Demet Akalın"


        };
        Console.WriteLine("** Davetliler **\n");

        int sıra = 1;
        foreach (string isim in davetliler)
        {
            Console.WriteLine($"{sıra}-{isim}");
            sıra++;
        }
    }

}
