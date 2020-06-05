namespace GigavenuePlanB
{
    public class SolidZoneLeaf : ZoneComponent
    {
        public SolidZoneLeaf(int eventId, int number, int capacity, string zoneType)
        {
            EventId = eventId;
            Number = number;
            Capacity = capacity;
            ZoneType = zoneType;
        }
        public int Number { get;}
        public int Capacity{ get; }
        public string ZoneType { get; }
        public int EventId { get; }
        public override Invitation BookSeat(int userId)
        {
            return Invitation();
        }
        public override int FreeSitsCount ()
        {
            return 0;
        }
        public override bool IsComposite()
        {
            return false;
        }
    }
}