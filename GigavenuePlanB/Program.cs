using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GigavenuePlanB
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage dataStorage = new Storage();

            GigUser Me = dataStorage.AddUser("me@me.com","Dima","Bub");
            Console.WriteLine($"User {Me.Firstname} created\n");
            dataStorage.WriteToConsole();
            Console.WriteLine();
            
            Console.WriteLine("Будь ласка введіть дані для нового користувача в одному рядку");
            Console.WriteLine("email firstname lastname");
            // Valid File format email firstname lastname;
            string[] line = Console.ReadLine().Split(' ');
            try
            {
                GigUser newUser = new GigUser(line[0], line[1],line[2], 12);
                try
                {
                    dataStorage.AddUser(newUser);
                }
                catch (UserAlreadyExistsException exists)
                {
                    Console.WriteLine(exists);
                }
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("Less than 3 arguments entered");
            }
            
            Console.WriteLine("\nAll users:");
            dataStorage.WriteToConsole();
        }
    }
}