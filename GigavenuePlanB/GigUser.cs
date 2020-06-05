using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GigavenuePlanB
{
    public class GigUser
    {
        public GigUser(string email, string firstname, string lastname, int userId = 0)
        {
            Email = email;
            UserId = userId;
            Firstname = firstname;
            Lastname = lastname;
            _invitations = new List<Invitation>(); 
        }
        
        public GigUser(bool readConsole = false, int userId = 0)
        {
            if (readConsole)
            {
                UserId = userId;
                Console.WriteLine("Enter new user email: ");
                Email = Console.ReadLine();
                Console.WriteLine("Enter new user name: ");
                Firstname = Console.ReadLine();
                Console.WriteLine("Enter new user lastname: ");
                Lastname = Console.ReadLine();
            }
            else
            {
                Email = "name@mail.com";
                UserId = userId;
                Firstname = "Usfisrtname";
                Lastname = "Uslastname";
            }
        }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public int UserId { get; set; }
        
        public void buyTicket(Event ev)
        {    
            Console.WriteLine($"Hey, {Firstname}, for {ev.Name}, there are these zones:");
            ev.printZones();
            Console.WriteLine($"Which one you want to buy? ");
            ev.bookTicket(int.Parse(Console.ReadLine()),this);
        }
        
        public override string ToString()
        {
            return $"{UserId.ToString()} {Email} {Firstname} {Lastname}";
        }
        
        

        private List<Invitation> _invitations;
    }
}