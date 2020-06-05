using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GigavenuePlanB
{
    public class Invitation
    {
        public Invitation(int eventId, int zoneId, int userId)
        {
            var rand = new Random();

            EventId = eventId;
            ZoneId = zoneId;
            UserId = userId;
            Sha512key = $"|={rand.Next(10000,99999).ToString()}={EventId.ToString()}={ZoneId.ToString()}={UserId.ToString()}=|";
        }
        public int InvitationId { get; set; }
        public int EventId { get; set; }
        public int ZoneId { get; set; }
        public int UserId { get; set; }
        public DateTime PurchaseDateTime{ get; set; }
        public string Sha512key{ get; set; }
        
        public override string ToString()
        {
            return Sha512key;
        }
    }
}