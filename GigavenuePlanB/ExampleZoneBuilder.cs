using System;
using System.Collections.Generic;

namespace GigavenuePlanB
{
    public class ExampleZoneBuilder:IZoneBuilder
    {


        public ExampleZoneBuilder(int eventId)
        {
            evId = eventId;
            zones = new List<ZoneComponent>();
            startBuilding();
        }
        
        public void startBuilding()
        {
            Console.WriteLine("Enter which u want to add for Event \n 1 - solid \n 2 - matrix \n 3 - finish");
            string result = Console.ReadLine();
            while (result != "3")
            {
                switch (result)
                {
                    case "1":
                        buildSolidZone();
                        break;
                    case "2":
                        buildMatrixZone();
                        break;
                    default:
                        Console.WriteLine("Wrong input: ");
                        break;
                }
                Console.WriteLine("Enter if u want to add more Zones \n 1 - solid \n 2 - matrix \n 3 - finish");
                result = Console.ReadLine();
            }


        }
        
        private List<ZoneComponent> zones;
        private int evId;

        public List<ZoneComponent> getZone()
        {
            return zones;
        }

        public void buildSolidZone()
        {
            Console.WriteLine("Enter zone number : ");
            int number = int.Parse(Console.ReadLine());;
            Console.WriteLine("Enter zone capacity : ");
            int capacity = int.Parse(Console.ReadLine());;
            zones.Add(new SolidZoneLeaf(evId,number,capacity));
        }

        public void buildMatrixZone()
        {
            Console.WriteLine("Enter zone number : ");
            int number = int.Parse(Console.ReadLine());;
            Console.WriteLine("Enter zone size : ");
            int capacity = int.Parse(Console.ReadLine());;
            zones.Add(new MatrixZoneLeaf(evId,number,capacity));
        }
    }
}