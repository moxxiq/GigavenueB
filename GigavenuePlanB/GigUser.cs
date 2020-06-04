using System;
using System.ComponentModel.DataAnnotations;

namespace GigavenuePlanB
{
    public class GigUser : IStoragble
    {
        public GigUser(string email, string firstname, string lastname, int userId = 0)
        {
            Email = email;
            UserId = userId;
            Firstname = firstname;
            Lastname = lastname;
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
        public override string ToString()
        {
            return $"{UserId.ToString()} {Email} {Firstname} {Lastname}";
        }

        public string ConvertForStorage()
        {
            // TODO
            throw new NotImplementedException();
        }
    }
}