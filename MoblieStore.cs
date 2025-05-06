using System;
using System.Collections.Generic;

class Mobile
{
    public int ID { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public double Price { get; set; }
}

class MobileStore
{
    static List<Mobile> mobiles = new List<Mobile>();
    static int nextId = 1;

    static void Main()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\n--- Mobile Store Management ---");
            Console.WriteLine("1. View Mobiles");
            Console.WriteLine("2. Add Mobile");
            Console.WriteLine("3. Search Mobile");
            Console.WriteLine("4. Purchase Mobile");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": ViewMobiles(); break;
                case "2": AddMobile(); break;
                case "3": SearchMobile(); break;
                case "4": PurchaseMobile(); break;
                case "5": exit = true; break;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

    static void ViewMobiles()
    {
        Console.WriteLine("\nAvailable Mobiles:");
        if (mobiles.Count == 0)
        {
            Console.WriteLine("No mobiles found.");
            return;
        }
        foreach (var mobile in mobiles)
        {
            Console.WriteLine($"ID: {mobile.ID}, Brand: {mobile.Brand}, Model: {mobile.Model}, Price: ${mobile.Price}");
        }
    }

    static void AddMobile()
    {
        Console.Write("\nEnter Brand: ");
        string brand = Console.ReadLine();
        Console.Write("Enter Model: ");
        string model = Console.ReadLine();
        Console.Write("Enter Price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        mobiles.Add(new Mobile { ID = nextId++, Brand = brand, Model = model, Price = price });
        Console.WriteLine("Mobile added successfully.");
    }

    static void SearchMobile()
    {
        Console.Write("\nEnter model or brand to search: ");
        string keyword = Console.ReadLine().ToLower();
        var results = mobiles.FindAll(m => m.Brand.ToLower().Contains(keyword) || m.Model.ToLower().Contains(keyword));
        
        if (results.Count == 0)
        {
            Console.WriteLine("No matching mobiles found.");
            return;
        }

        Console.WriteLine("Search Results:");
        foreach (var mobile in results)
        {
            Console.WriteLine($"ID: {mobile.ID}, Brand: {mobile.Brand}, Model: {mobile.Model}, Price: ${mobile.Price}");
        }
    }

    static void PurchaseMobile()
    {
        Console.Write("\nEnter Mobile ID to purchase: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var mobile = mobiles.Find(m => m.ID == id);
        if (mobile != null)
        {
            Console.WriteLine($"Purchased {mobile.Brand} {mobile.Model} for ${mobile.Price}");
            mobiles.Remove(mobile);
        }
        else
        {
            Console.WriteLine("Mobile not found.");
        }
    }
}
