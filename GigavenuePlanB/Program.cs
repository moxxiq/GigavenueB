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

            GigUser Me = dataStorage.AddUser("me@me.com","Dima","Bub");
            Console.WriteLine($"User {Me.Firstname} created\n");
            dataStorage.WriteToConsole();
            
            Console.WriteLine("Зробимо деякі зміни");
            Me.Email = "another.me@me.com";
            dataStorage.WriteToConsole();
        }
    }
}