using System;
using System.ComponentModel.DataAnnotations;

namespace GigavenuePlanB
{
    public class GigUser : IStoragble<int>
    {
        
        
        public GigUser(string email, string firstname, string lastname, int userId = 0)
        {
            Email = email;
            this.userId = userId;
            Firstname = firstname;
            Lastname = lastname;
        }
        
        public GigUser(bool readConsole = false, int userId = 0)
        {
            if (readConsole)
            {
                userId = userId;
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
                userId = userId;
                Firstname = "Usfisrtname";
                Lastname = "Uslastname";
            }
        }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        private int userId;
        public override string ToString()
        {
            return $"{userId.ToString()},{Email},{Firstname},{Lastname}";
        }
        
        public static string returnFileStoragePath()
        {
            return "users.txt";
        }

        public string ConvertForStorage()
        {
            // TODO
            throw new NotImplementedException();
        }

        public string ConvertForFileStorage()
        {
            return this.ToString();
        }

        public int getIdentifier()
        {
            return this.userId;
        }
        
        public void setIdentifier(int identifier)
        {
            this.userId = identifier;
        }
    }
}