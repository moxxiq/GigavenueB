using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace GigavenuePlanB
{
    public class Event
    {
        public Event(string name, string information = "None")
        {
            Name = name;
            Information = information;
        }
        
        public int EventId { get;set;}
        public string Name { get;set;}
        // List of pathes to images
        public string Image { get; set; }
        public string Information { get; set; }
        public DateTime EventDate { get; set; }

    }
}