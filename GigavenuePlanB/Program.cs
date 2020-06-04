using System;
using System.Collections.Generic;
using System.IO;

namespace GigavenuePlanB
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage dataStorage = new Storage();
            GigUser Me = new GigUser("me@me.com",1,"Dima","Bub");
            Console.WriteLine($"User {Me.Firstname} created");
            
            FileStream fileStream = new FileStream("users.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(fileStream))
            {
                Console.WriteLine("Enter: email,firstname,lastname");
                string[] line = reader.ReadLine().Split(',');
                Console.WriteLine(line[0]+" added");
                dataStorage.Add(new GigUser(line[0], line[2],line[3]));
            }
            dataStorage.WriteToConsole();
        }
    }
}