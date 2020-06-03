using System;

namespace GigavenuePlanB
{
    class Program
    {
        static void Main(string[] args)
        {
            GigUser Me = new GigUser("me@me.com",1,"Dima","Bub");
            Console.WriteLine($"User {Me.Firstname} created");
        }
    }
}