using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GigavenuePlanB
{
    public class Invitation
    {
        public Invitation()
        {
        }
        public int InvitationId { get; set; }
        public int EventId { get; set; }
        public int ZoneId { get; set; }
        public int UserId { get; set; }
        public DateTime PurchaseDateTime{ get; set; }
        public string Sha512key{ get; set; }
    }
}