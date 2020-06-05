using System;
using System.Collections.Generic;

namespace GigavenuePlanB
{
    public class ExampleEventBuilder: IEventBuilder
    {
        public ExampleEventBuilder(){
            Console.WriteLine("Print id :");
            evId = Int32.Parse(Console.ReadLine());
            ev = new Event("none",new List<ZoneComponent>());
            startBuilding();
        }

        public void startBuilding()
        {
            Console.WriteLine("Enter what u want to edit for Event \n 1 - name \n 2 - Information \n 3 - zone \n 4 - finish");
            string result = Console.ReadLine();
            while (result != "4")
            {
                switch (result)
                {
                    case "1":
                        Console.WriteLine("Enter name: ");
                        name= Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Enter Information: ");
                        information = Console.ReadLine();
                        break;
                    case "3":
                        ExampleZoneBuilder bld = new ExampleZoneBuilder(evId);
                        zones = bld.getZone();
                        break;
                    default:
                        Console.WriteLine("Wrong input: ");
                        break;
                }
                Console.WriteLine("Enter what u want to edit for Event \n 1 - name \n 2 - Information \n 3 - zone \n 4 - finish");
                result = Console.ReadLine();
            }
            ev = new Event(name, zones, information);
            
        }

        private int evId; 
        private Event ev; 
        private string name;
        private string information;
        private List<ZoneComponent> zones;

        public Event getEvent()
        {
            return  ev;
        }
    }
}