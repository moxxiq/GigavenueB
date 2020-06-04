using System;
using System.Collections.Generic;
using System.Linq;

namespace GigavenuePlanB
{
    public class Storage
    // make it singleton
    {
        public Storage()
        {
            // import old data then calc max ID
            nextID = 0;
            this.usersStorage = new List<GigUser>();

        }

        private static int nextID;
        private List<GigUser> usersStorage;

        public GigUser AddUser(string email, string firstname, string lastname)
        {
            if (usersStorage.Any() && usersStorage.Any(storedUser => storedUser.Email == email))
            {
                throw new UserAlreadyExistsException("User with this email already exists"); 
            }
            GigUser newUser = new GigUser(email, firstname, lastname, ++nextID);
            usersStorage.Add(newUser);
            return newUser;
        }

        public void AddUser(GigUser newUser)
        {
            if (usersStorage.Any() && usersStorage.Any(storedUser => storedUser.Email == newUser.Email))
            {
                throw new UserAlreadyExistsException("User with this email already exists"); 
            }
            if (usersStorage.Any() && usersStorage.Any(storedUser => storedUser.UserId == newUser.UserId))
            {
                throw new UserAlreadyExistsException("User with this id already exists");
            }
            usersStorage.Add(newUser);
        }

        public void WriteToConsole()
        {
            this.usersStorage.ForEach(Console.WriteLine);
        }
    }

    [Serializable]
    public class UserAlreadyExistsException : Exception
    {
        public UserAlreadyExistsException()
        {
        }
    
        public UserAlreadyExistsException(string message)
            : base(message)
        {
            
        }
    
        public UserAlreadyExistsException(string message, Exception innerException)
            : base(message, innerException)
        {
            
        }   
    }
}