using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen bir sayı giriniz: ");
        try
        {
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            int square = number * number;
            Console.WriteLine($"Girdiğiniz sayının karesi: {square}");



        }
        catch
        {
            Console.WriteLine("Geçersiz giriş yaptınız");
        }



    }


}