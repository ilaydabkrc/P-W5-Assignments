using System;
using System.Collections.Generic;

class Car
{
    public DateTime ProductionDate { get; set; }
    public string SerialNumber { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int DoorCount { get; set; }

    public Car()
    {
        ProductionDate = DateTime.Now;

    }
}
class Program
{
    static void Main()
    {
        List<Car> carList = new List<Car>();
        string answer = "";
       
    Start:

        Console.WriteLine("Araba üretmek istiyor musunuz? (e/h): ");
        answer = Console.ReadLine().ToLower();

        if (answer != "e" && answer != "h")
        {
            Console.WriteLine("Geçersiz giriş yaptınız.");
            goto Start;
        }
        if(answer == "h")
        {

            Console.WriteLine("Program sonlandırıldı.");
            return;
        }

        Car car = new Car();
        Console.WriteLine("Seri numarası: ");
        car.SerialNumber = Console.ReadLine();

        Console.WriteLine("Marka: ");
        car.Brand = Console.ReadLine();

        Console.WriteLine("Model: ");
        car.Brand = Console.ReadLine();

        Console.WriteLine("Renk: ");
        car.Color = Console.ReadLine(); 

    DoorInput:

        Console.WriteLine("Kapı sayısı: ");
        string doorInput = Console.ReadLine();
        int doorCount;
    if (!int.TryParse(doorInput, out doorCount))
        {
            Console.WriteLine("Geçersiz giriş yaptınız.");
            goto DoorInput;
        }
        car.DoorCount = doorCount;

        carList.Add(car);

        Console.WriteLine("Başka bir araba üretmek istiyor musunuz? (e/h):");
        string another = Console.ReadLine().ToLower();

        if (another == "e")
        {
            goto Start;

        }
        else if(another == "h")
         {
            Console.WriteLine("\n------Üretilen Arabalar------");
            
            foreach(var item in carList)
            {
                Console.WriteLine($"Seri no: {item.SerialNumber}, Marka: {item.Brand}");
            }
            Console.WriteLine("\nProgram sonlandırıldı.");
        }
        else
        {
            Console.WriteLine("Geçersiz giriş yaptınız");
        }
    }
   



}