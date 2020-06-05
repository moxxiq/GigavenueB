using System.Collections.Generic;
using System.ComponentModel;

namespace GigavenuePlanB
{
    public class ZoneCompositor : ZoneComponent
    {
        protected List<ZoneComponent> childrenZones = new List<ZoneComponent>();
        public void Add(ZoneComponent component)
        {
            this.childrenZones.Add(component);
        }
        public void Remove(ZoneComponent component)
        {
            this.childrenZones.Remove(component);
        }
        public override int FreeSeatsCount()
        {
            int result = 0;
            foreach (ZoneComponent component in this.childrenZones)
            {
                result += component.FreeSeatsCount();
            }
            return result;
        }

        public override Invitation BookSeat(int userId)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            string result = "";
            foreach (ZoneComponent component in this.childrenZones)
            {
                result += component.ToString()+'\n';
            }
            return result;
        }
    }
}