using System.Collections.Generic;

namespace GigavenuePlanB
{
    public interface IZoneBuilder
    {
        public void startBuilding();
        public List<ZoneComponent> getZone();
        public void buildSolidZone();
        public void buildMatrixZone();
    }
}