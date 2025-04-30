using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Program
{
    public class UserWithRole
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Role { get; set; }
    }

    static void Main(string[] args)
    {
        string json = File.ReadAllText("user_types.json");
        var users = JsonConvert.DeserializeObject<List<UserWithRole>>(json);

        Console.WriteLine("User Types:");
        foreach (var user in users)
        {
            Console.WriteLine($"Name: {user.Name}, Age: {user.Age}, City: {user.City}, Role: {user.Role}");
        }
    }
}


