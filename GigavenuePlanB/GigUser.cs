using System;
using System.ComponentModel.DataAnnotations;

namespace GigavenuePlanB
{
    public class GigUser
    {
        public GigUser(string email, string firstname, string lastname, int userId = 0)
        {
            UserID = userId;
            
            Email = email;
            Firstname = firstname;
            Lastname = lastname;
        }
        
        public GigUser(bool readConsole = false, int userId = 0)
        {
            if (readConsole)
            {
                UserID = userId;
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
                UserID = userId;
                Firstname = "Usfisrtname";
                Lastname = "Uslastname";
            }
        }
        public int UserId{ get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public int UserID { get; set; }
        public override string ToString()
        {
            return $"{UserID} {Email} {Firstname} {Lastname}";
        }
    }
}