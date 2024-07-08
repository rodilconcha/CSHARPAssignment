
using System;

class Employee : IQuittable
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Other properties and methods specific to Employee

    public void Quit()
    {
        Console.WriteLine($"{FirstName} {LastName} has Quit their job.");
        // Implement any other logic related to quitting here.
    }
}

class Program
{
    static void Main()
    {
        // Create an Employee object
        Employee emp = new Employee
        {
            Id = 123,
            FirstName = "Robert",
            LastName = "Williams"
        };

        // Polymorphism: Create an IQuittable reference pointing to the Employee object
        IQuittable quittableEmp = emp;

        // Call the Quit() method
        quittableEmp.Quit();
    }
}