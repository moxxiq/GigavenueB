using System.ComponentModel.DataAnnotations;

namespace GigavenuePlanB
{
    public class GigUser
    {
        public GigUser(string email, int userId, string firstname, string lastname)
        {
            Email = email;
            userId = userId;
            Firstname = firstname;
            Lastname = lastname;
        }

        private int userId;
        public int GetId()=>userId;
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
    }
}