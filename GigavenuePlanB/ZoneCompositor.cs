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
        public override int FreeSitsCount()
        {
            int result = 0;
            foreach (ZoneComponent component in this.childrenZones)
            {
                result += component.FreeSitsCount();
            }
            return result;
        }
    }
}