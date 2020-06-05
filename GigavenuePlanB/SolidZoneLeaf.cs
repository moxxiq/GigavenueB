namespace GigavenuePlanB
{
    public class SolidZoneLeaf : ZoneComponent
    {
        public SolidZoneLeaf(int eventId, int number, int capacity)
        {
            EventId = eventId;
            Number = number;
            Capacity = capacity;
            seatsBooked = 0;
        }
        public int Number { get;}
        public int Capacity{ get; }
        public string ZoneType { get; }
        public int EventId { get; }
        private int seatsBooked;
        public override Invitation BookSeat(int userId)
        {
            if (seatsBooked < Capacity)
            {
                seatsBooked++;
                return new Invitation(EventId, Number, userId);
            }

            return null;
        }
        public override int FreeSitsCount ()
        {
            return Capacity-seatsBooked;
        }
        public override bool IsComposite()
        {
            return false;
        }
    }
}