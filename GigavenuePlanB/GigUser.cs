﻿using System.ComponentModel.DataAnnotations;

namespace GigavenuePlanB
{
    public class GigUser
    {
        public GigUser(string email, int userId, string firstname, string lastname)
        {
            Email = email;
            UserID = userId;
            Firstname = firstname;
            Lastname = lastname;
        }
        public int UserId{ get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public int UserID { get; set; }
    }
}