using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GigavenuePlanB
{
    public abstract class Zone
    {
        public Zone(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }
        public int ZoneId { get; set; }
        public int ZoneEventId { get; set; }
        public int Color { get; set; }
        public string Name{ get; set; }
        public int Capacity{ get; set; }
        
    }
}