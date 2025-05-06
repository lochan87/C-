using System;
using System.Collections.Generic;

class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public string Email { get; set; }
}

class MailAssigner
{
    static List<Employee> employees = new List<Employee>();
    static string companyDomain = "logo87.com";

    static void Main()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\n--- Organization Mail Assigner ---");
            Console.WriteLine("1. Add New Employee");
            Console.WriteLine("2. View All Emails");
            Console.WriteLine("3. Search by Email");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": AddEmployee(); break;
                case "2": ViewAllEmails(); break;
                case "3": SearchByEmail(); break;
                case "4": exit = true; break;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

    static void AddEmployee()
    {
        Console.Write("\nEnter Employee Full Name: ");
        string name = Console.ReadLine().Trim();
        Console.Write("Enter Department (e.g. HR, IT, Sales): ");
        string dept = Console.ReadLine().Trim().ToLower();

        string username = name.ToLower().Replace(" ", ".") + "@" + dept + "." + companyDomain;
        Employee emp = new Employee { Name = name, Department = dept, Email = username };
        employees.Add(emp);

        Console.WriteLine("Email Assigned: " + username);
    }

    static void ViewAllEmails()
    {
        Console.WriteLine("\n--- All Employee Emails ---");
        if (employees.Count == 0)
        {
            Console.WriteLine("No employees found.");
            return;
        }

        foreach (var emp in employees)
        {
            Console.WriteLine($"Name: {emp.Name}, Department: {emp.Department}, Email: {emp.Email}");
        }
    }

    static void SearchByEmail()
    {
        Console.Write("\nEnter email to search: ");
        string inputEmail = Console.ReadLine().ToLower();
        var emp = employees.Find(e => e.Email.ToLower() == inputEmail);

        if (emp != null)
        {
            Console.WriteLine($"Name: {emp.Name}, Department: {emp.Department}, Email: {emp.Email}");
        }
        else
        {
            Console.WriteLine("Email not found.");
        }
    }
}
