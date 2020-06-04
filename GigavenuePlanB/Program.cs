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

            FileStream fileStream = new FileStream("users.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(fileStream))
            {
                // Valid File format id,email,firstname,lastname;
                string[] line = reader.ReadLine().Split(',');
                dataStorage.AddUser(new GigUser(line[1], line[2],line[3], int.Parse(line[0])));
            }

            GigUser Me = dataStorage.AddUser("me@me.com","Dima","Bub");
            Console.WriteLine($"User {Me.Firstname} created\n");
            dataStorage.WriteToConsole();
        }
    }
}