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
        public override int Number { get;}
        public override int Capacity{ get; }
        public override int EventId { get; }
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
        public override int FreeSeatsCount ()
        {
            return Capacity-seatsBooked;
        }
        public override bool IsComposite()
        {
            return false;
        }
    }
}