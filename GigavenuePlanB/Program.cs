using System;
using System.Collections.Generic;
using System.IO;

namespace GigavenuePlanB
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<GigUser> users = new List<GigUser>();
            
            FileStream fileStream = new FileStream("users.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(fileStream))
            {
                string[] line = reader.ReadLine().Split(',');
                Console.WriteLine(line[0]);
                users.Add(new GigUser(line[0], int.Parse(line[1]),line[2],line[3]));
            }
            
            GigUser Me = new GigUser("me@me.com",1,"Dima","Bub");
            
            Console.WriteLine($"User {Me.Firstname} created");
        }
    }
}