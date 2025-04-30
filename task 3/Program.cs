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
        string json = File.ReadAllText("users.json");
        List<User> users = JsonConvert.DeserializeObject<List<User>>(json);

        Console.WriteLine("Deserialized Users:");
        foreach (var user in users)
        {
            Console.WriteLine($"Name: {user.Name}, Age: {user.Age}, City: {user.City}");
        }
    }
}

