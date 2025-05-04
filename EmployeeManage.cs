using System;

class Employee
{
    public int id;
    public string name;
    public string department;

    public void Display()
    {
        Console.WriteLine($"ID: {id}, Name: {name}, Department: {department}");
    }
}

class Program
{
    static void Main()
    {
        Employee[] employees = new Employee[100];
        int count = 0;
        int choice;

        do
        {
            Console.WriteLine("\n--- Employee Management System ---");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. View All Employees");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (count < employees.Length)
                    {
                        Employee emp = new Employee();
                        Console.Write("Enter Employee ID: ");
                        emp.id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        emp.name = Console.ReadLine();
                        Console.Write("Enter Department: ");
                        emp.department = Console.ReadLine();

                        employees[count] = emp;
                        count++;

                        Console.WriteLine("Employee added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Maximum employee limit reached.");
                    }
                    break;

                case 2:
                    Console.WriteLine("\n--- Employee List ---");
                    if (count == 0)
                    {
                        Console.WriteLine("No employees found.");
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            employees[i].Display();
                        }
                    }
                    break;

                case 3:
                    Console.WriteLine("Closing the Employee Management System!!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

        } while (choice != 3);
    }
}
