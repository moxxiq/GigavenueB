using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GigavenuePlanB
{
    class Program
    {
        static void Main(string[] args)
        {
            //Storage dataStorage = new Storage();

            //GigUser me = dataStorage.AddUser("me@me.com","Dima","Bub");
            //Console.WriteLine($"User {me} created\n");
            //dataStorage.WriteToConsole();
            //Console.WriteLine();
            //Console.WriteLine(GigUser.returnFileStoragePath());
            //Console.WriteLine("Please enter data for new user \n");
            // Valid File format email firstname lastname;
            
            FileStorage fileStorage = new FileStorage();
            DbStorage dbStorage = new DbStorage();
            
            fileStorage.Add(new GigUser(readConsole:true));
            dbStorage.Add(new GigUser(readConsole:true));
            
            //try
            //{
            //    GigUser newUser = new GigUser(readConsole:true);
            //    try
            //    {
            //        dataStorage.AddUser(newUser);
            //    }
            //    catch (UserAlreadyExistsException exists)
            //    {
            //        Console.WriteLine(exists);
            //    }
            //}
            //catch (System.IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Less than 3 arguments entered");
            //}
            //
            //Console.WriteLine("\nAll users:");
            //dataStorage.WriteToConsole();
            
            
        }
    }
}