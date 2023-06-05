using System;

class SmartphonePicker
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string OS { get; set; }
    public string Color { get; set; }
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
            new SmartphonePicker("Apple", "iPhone 14 Pro Max", "iOS 15", "Red", 8, 256, 6.7, 69990),
            new SmartphonePicker("Apple", "iPhone 13 Pro", "iOS 14", "Blue", 6, 256, 6.1, 59990),
            new SmartphonePicker("Apple", "iPhone 12 Pro", "iOS 14", "Yellow", 6, 128, 6.1, 39990),
            new SmartphonePicker("Samsung", "Galaxy S21 Ultra", "Android 11", "Red", 12, 256, 6.8, 41973),
            new SmartphonePicker("Samsung", "Galaxy Note 20", "Android 10", "Blue", 8, 256, 6.7, 49999),
            new SmartphonePicker("Samsung", "Galaxy A22 5G", "Android 10", "Yellow", 8, 128, 6.8, 25999),
            new SmartphonePicker("Xiaomi", "Mi 11 Ultra", "Android 11", "Red", 12, 256, 6.81, 36364),
            new SmartphonePicker("Xiaomi", "Redmi Note 10 Pro", "Android 11", "Blue", 6, 128, 6.67, 15999),
            new SmartphonePicker("Xiaomi", "Redmi Note 9", "Android 10", "Yellow", 6, 128, 6.56, 11999),
            new SmartphonePicker("Huawei", "Mate 40 Pro", "Android 11", "Red", 8, 256, 6.76, 49350),
            new SmartphonePicker("Huawei", "P30 Pro", "Android 10", "Blue", 8, 256, 6.58, 59999),
            new SmartphonePicker("Huawei", "P60 Pro", "Android 13", "Yellow", 8, 256, 6.58, 69999),
            new SmartphonePicker("LG", "LG model", "Android 10", "Red", 8, 256, 6.78, 15000),
            new SmartphonePicker("LG", "LG V30+", "Android 7", "Blue", 4, 128, 6.0, 28990),
            new SmartphonePicker("LG", "LG G7 ThinQ", "Android 10", "Yellow", 4, 64, 6.1, 15990),
        };

        bool exit = false;
        do
        {
            Console.WriteLine("Welcome to Smartphone Picker");
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Exit");
            Console.WriteLine("2. Continue");

            int exitChoice = int.Parse(Console.ReadLine());

            if (exitChoice == 1)
            {
                exit = true;
                break;
            }

            Console.WriteLine("Please enter your preferred color:");
            string preferredColor = Console.ReadLine();

            Console.WriteLine("Please choose a smartphone brand:");
            Console.WriteLine("1. Apple");
            Console.WriteLine("2. Samsung");
            Console.WriteLine("3. Xiaomi");
            Console.WriteLine("4. Huawei");
            Console.WriteLine("5. LG");
            Console.WriteLine("6. Exit");

            int brandChoice = int.Parse(Console.ReadLine());

            if (brandChoice >= 1 && brandChoice <= 5)
            {
                string selectedBrand = "";
                switch (brandChoice)
                {
                    case 1:
                        selectedBrand = "Apple";
                        break;
                    case 2:
                        selectedBrand = "Samsung";
                        break;
                    case 3:
                        selectedBrand = "Xiaomi";
                        break;
                    case 4:
                        selectedBrand = "Huawei";
                        break;
                    case 5:
                        selectedBrand = "LG";
                        break;
                }

                Console.WriteLine($"Here are the available {selectedBrand} smartphones with the preferred color '{preferredColor}':");

                int i = 1;
                bool foundPreferredColor = false;

                foreach (var smartphone in smartphones)
                {
                    if (smartphone.Brand == selectedBrand && smartphone.Color.Equals(preferredColor, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"{i}. {smartphone.Model}");
                        i++;
                        foundPreferredColor = true;
                    }
                }

                if (!foundPreferredColor)
                {
                    Console.WriteLine("No smartphones found with the preferred color.");
                }
                else
                {
                    Console.WriteLine("Please choose which smartphone you like:");
                    int modelChoice = int.Parse(Console.ReadLine());

                    Console.WriteLine("Here are the specifications of your chosen phone:");
                    Console.WriteLine(smartphones[modelChoice - 1]);
                }
            }
            else if (brandChoice == 6)
            {
                exit = true;
            }
            else
            {
                Console.WriteLine("Invalid brand choice.");
            }
        } while (!exit);

        Console.WriteLine("GE GANYAN KA NAMAN E, NANGIIWAN NALANG!");
    }
}
