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

    static void Main(string[] args)
    {
        var users = new List<User>
        {
            new User { Name = "John Doe", Age = 30, City = "New York" },
            new User { Name = "Jane Smith", Age = 25, City = "Los Angeles" },
            new User { Name = "Mike Johnson", Age = 40, City = "Chicago" }
        };

        string json = JsonConvert.SerializeObject(users, Formatting.Indented);
        File.WriteAllText("users.json", json);

        Console.WriteLine("users.json file created with 3 users.");
    }
}
