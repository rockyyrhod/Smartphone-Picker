using System;

class SmartphonePicker
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string OS { get; set; }
    public string Color {get; set;}
    public int RAM { get; set; }
    public int Storage { get; set; }
    public double ScreenSize { get; set; }
    public double Price { get; set; }

    public SmartphonePicker(string brand, string model, string os, string color, int ram, int storage, double screenSize, double price)
    {
        Brand = brand;
        Model = model;
        OS = os;
        Color = color;
        RAM = ram;
        Storage = storage;
        ScreenSize = screenSize;
        Price = price;
    }

    public override string ToString()
    {
        return $"Brand: {Brand}\nModel: {Model}\nOS: {OS}\nColor: {Color}\nRAM: {RAM} GB\nStorage: {Storage} GB\nScreen Size: {ScreenSize} inches\nPrice: {Price} PHP";
    }
}

class Program
{
    static void Main(string[] args)
    {
        SmartphonePicker[] smartphones = new SmartphonePicker[]
        {
            new SmartphonePicker("Apple", "iPhone 13 Pro Max", "iOS 15", "Red", 6, 128, 6.7, 69990),
            new SmartphonePicker("Samsung", "Galaxy S21 Ultra", "Android 11", "Yellow", 12, 256, 6.8, 41973),
            new SmartphonePicker("Xiaomi", "Mi 11 Ultra", "Android 11", "Blue", 12, 256, 6.81, 36364 ),
            new SmartphonePicker("Huawei", "Mate 40 Pro", "Android 11", "Green", 8, 256, 6.76, 49350),
            new SmartphonePicker("LG", "LG model","Android 10","Black", 8, 256, 6.78, 15000 ),
        };

        bool exit = false;
        do
        {
            Console.WriteLine("Welcome to Smartphone Picker");
            Console.WriteLine("Please choose a smartphone brand:");
            Console.WriteLine("1. Apple");
            Console.WriteLine("2. Samsung");
            Console.WriteLine("3. Xiaomi");
            Console.WriteLine("4. Huawei");
            Console.WriteLine("5. LG");
            Console.WriteLine("6. Exit");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 6)
            {    exit = true;
            }
            else if (choice >= 1 && choice <= 5)
            {
                Console.WriteLine($"Here are the available {smartphones[choice - 1].Brand} smartphones:");

                for (int i = 0; i < smartphones.Length; i++)
                {
                    if (smartphones[i].Brand == smartphones[choice - 1].Brand)
                    {
                        Console.WriteLine($"{i + 1}. {smartphones[i].Model}");
                    }
                }

                int modelChoice = int.Parse(Console.ReadLine());

                Console.WriteLine ("Here are the specifications of your chosen phone: ");
                Console.WriteLine(smartphones[modelChoice - 1]);
            }
            else
            {
                Console.WriteLine("Wrong choice idol, sana ako nalang please.");
            }
        } while (!exit);
        Console.WriteLine("Thankyou for using this program, see you!");
    }
}

