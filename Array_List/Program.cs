using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = new int[10];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Lütfen {i+1}. sayıyı giriniz: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("\nGirdiğiniz sayılar: " + string.Join(", ", numbers));

        Console.WriteLine("Yeni bir sayı giriniz.");
        int newNumber = Convert.ToInt32(Console.ReadLine());

        List<int> numberList = new List<int>(numbers);
        numberList.Add(newNumber);
        
        numberList.Sort();
        numberList.Reverse();

        
        Console.WriteLine("\nBüyükten küçüğe sıralı sayılar: " + string.Join(", ", numberList));

    }




}