using System;

class Program
{
    static void Main(string[] args)
    {
        OrderedBrand[] smartphones = new OrderedBrand[]
        {
            new OrderedBrand("Apple", "iPhone 14 Pro Max", "iOS 15", "Red", 8, 256, 6.7, 69990),
            new OrderedBrand("Apple", "iPhone 13 Pro", "iOS 14", "Blue", 6, 256, 6.1, 59990),
            new OrderedBrand("Apple", "iPhone 12 Pro", "iOS 14", "Yellow", 6, 128, 6.1, 39990),
            new OrderedBrand("Samsung", "Galaxy S21 Ultra", "Android 11", "Red", 12, 256, 6.8, 41973),
            new OrderedBrand("Samsung", "Galaxy Note 20", "Android 10", "Blue", 8, 256, 6.7, 49999),
            new OrderedBrand("Samsung", "Galaxy A22 5G", "Android 10", "Yellow", 8, 128, 6.8, 25999),
            new OrderedBrand("Xiaomi", "Mi 11 Ultra", "Android 11", "Red", 12, 256, 6.81, 36364),
            new OrderedBrand("Xiaomi", "Redmi Note 10 Pro", "Android 11", "Blue", 6, 128, 6.67, 15999),
            new OrderedBrand("Xiaomi", "Redmi Note 9", "Android 10", "Yellow", 6, 128, 6.56, 11999),
            new OrderedBrand("Huawei", "Mate 40 Pro", "Android 11", "Red", 8, 256, 6.76, 49350),
            new OrderedBrand("Huawei", "P30 Pro", "Android 10", "Blue", 8, 256, 6.58, 59999),
            new OrderedBrand("Huawei", "P60 Pro", "Android 13", "Yellow", 8, 256, 6.58, 69999),
            new OrderedBrand("LG", "LG model", "Android 10", "Red", 8, 256, 6.78, 15000),
            new OrderedBrand("LG", "LG V30+", "Android 7", "Blue", 4, 128, 6.0, 28990),
            new OrderedBrand("LG", "LG G7 ThinQ", "Android 10", "Yellow", 4, 64, 6.1, 15990),
        };

        Console.WriteLine("Good Day User! Welcome to Rhy`s Smartphone Store");
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Please enter your preferred color:");
            string color = Console.ReadLine();

            Console.WriteLine("Based on your preferred color, Here`s the smartphone brands that you would like:");
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

                Console.WriteLine($"Here are the available {selectedBrand} smartphones with your preferred color '{color}':");

                int i = 1;
                bool foundPreferredColor = false;

                foreach (var smartphone in smartphones)
                {
                    if (smartphone.Brand == selectedBrand && smartphone.Color.Equals(color, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"{i}. {smartphone.Model}");
                        i++;
                        foundPreferredColor = true;
                    }
                }

                if (!foundPreferredColor)
                {
                    Console.WriteLine($"Sorry buddy, There's no available {selectedBrand} smartphone with your preferred color '{color}'.");
                }
                else
                {
                    Console.WriteLine("Please choose which smartphone that would satisfy your needs:");
                    int modelChoice = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the quantity:");
                    int quantity = int.Parse(Console.ReadLine());

                    Console.WriteLine("Here are the specifications of your chosen phone:");
                    var chosenSmartphone = smartphones[modelChoice - 1];
                    Console.WriteLine(chosenSmartphone);
                    Console.WriteLine($"Total Price for {quantity} unit(s): P{chosenSmartphone.GetTotalPrice(quantity)}");
                }
            }
            else if (brandChoice == 6)
            {
                Console.WriteLine("Thank you user, see us again!");
                exit = true;
            }
            else
            {
                Console.WriteLine("Invalid brand choice.");
            }
        }
    }
}
