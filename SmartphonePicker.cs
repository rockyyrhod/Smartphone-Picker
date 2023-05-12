using System;

class Smartphone
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string OS { get; set; }
    public int RAM { get; set; }
    public int Storage { get; set; }
    public double ScreenSize { get; set; }
    public double Price { get; set; }

    public Smartphone(string brand, string model, string os, int ram, int storage, double screenSize, double price)
    {
        Brand = brand;
        Model = model;
        OS = os;
        RAM = ram;
        Storage = storage;
        ScreenSize = screenSize;
        Price = price;
    }

    public override string ToString()
    {
        return $"Brand: {Brand}\nModel: {Model}\nOS: {OS}\nRAM: {RAM} GB\nStorage: {Storage} GB\nScreen Size: {ScreenSize} inches\nPrice: {Price} USD";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Smartphone[] smartphones = new Smartphone[]
        {
            new Smartphone("Apple", "iPhone 13 Pro Max", "iOS 15", 6, 128, 6.7, 1099),
            new Smartphone("Samsung", "Galaxy S21 Ultra", "Android 11", 12, 256, 6.8, 1199),
            new Smartphone("Xiaomi", "Mi 11 Ultra", "Android 11", 12, 256, 6.81, 1199),
            new Smartphone("Huawei", "Mate 40 Pro", "Android 11", 8, 256, 6.76, 1199)
        };

        bool exit = false;
        do
        {
            Console.WriteLine("Choose a smartphone brand:");
            Console.WriteLine("1. Apple");
            Console.WriteLine("2. Samsung");
            Console.WriteLine("3. Xiaomi");
            Console.WriteLine("4. Huawei");
            Console.WriteLine("0. Exit");

