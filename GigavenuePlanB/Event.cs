using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace GigavenuePlanB
{
    public class Event
    {
        public Event(string name, List<ZoneComponent> zones, string information = "None")
        {
            Name = name;
            Information = information;
            Zones = zones;
            events = new List<Event>();
        }
        
        public int EventId { get;set;}
        public string Name { get;set;}
        // List of pathes to images
        public string Image { get; set; }
        public string Information { get; set; }
        public DateTime EventDate { get; set; }

        public List<Event> events { get;  }
        
        public List<ZoneComponent> Zones { get; set; }

        public void printZones()
        {
            int i = 1;
            foreach (ZoneComponent zone in Zones)
            {
                Console.WriteLine($"{i} - {zone.ToString()}");
                i++;
            }
        }
        
        public Invitation bookTicket(int zone, GigUser user)
        {
            return Zones[zone-1].BookSeat(user.UserId);
        }
        
        

    }
}