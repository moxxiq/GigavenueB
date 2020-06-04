using System;
using System.Collections.Generic;

namespace GigavenuePlanB
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Storage dataStorage = new Storage();
            GigUser me = dataStorage.AddUser("me@org.com", "Dmytro", "Bub");
            Console.WriteLine($"User {me.Firstname} created");
            dataStorage.WriteToConsole();
            Console.WriteLine("Enter new user email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter new user name: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter new user lastname: ");
            string lname = Console.ReadLine();
            dataStorage.AddUser(email, fname, lname);
            dataStorage.WriteToConsole();
        }
    }
}