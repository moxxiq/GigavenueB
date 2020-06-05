using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace GigavenuePlanB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose functions: \n 1 - execprions \n 2 - event creation and ticket buying (Scenario) \n ");
            switch (Console.ReadLine())
            {
                case "1":
                    Exceptions();
                    break;
                case "2":
                    Scenario();
                    break;
            }


            void Scenario()
            {
                GigUser dima = new GigUser("dima@me.com","Dima","Bub");
                ExampleEventBuilder bldr = new ExampleEventBuilder();
                Event dimaEv = bldr.getEvent();
                dimaEv.printZones();
                dima.buyTicket(dimaEv);
            }
            
            
            
            void Exceptions()
            {
                Storage dataStorage = new Storage();

                GigUser me = dataStorage.AddUser("me@me.com","Dima","Bub");
                Console.WriteLine($"User {me} created\n");
                dataStorage.WriteToConsole();
                Console.WriteLine();
            
                Console.WriteLine("Please enter data for new user \n");
                // Valid File format email firstname lastname;
                try
                {
                    GigUser newUser = new GigUser(readConsole:true);
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
}