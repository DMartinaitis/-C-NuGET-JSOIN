using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
class Program
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
    public class Admin : User
    {
        public string Role => "Admin";
    }
    public class RegularUser : User
    {
        public string Role => "User";
    }
    static void Main(string[] args)
    {
        Admin admin = new Admin { Name = "Alice", Age = 40, City = "Chicago" };
        RegularUser user = new RegularUser { Name = "Bob", Age = 22, City = "Miami" };

        Console.WriteLine($"Admin: {admin.Name}, Age: {admin.Age}, City: {admin.City}, Role: {admin.Role}");
        Console.WriteLine($"User: {user.Name}, Age: {user.Age}, City: {user.City}, Role: {user.Role}");
    }
}


