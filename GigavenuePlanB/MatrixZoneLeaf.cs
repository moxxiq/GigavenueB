using System;

namespace GigavenuePlanB
{
    public class MatrixZoneLeaf : ZoneComponent
    {
        public MatrixZoneLeaf(int eventId, int number, int size)
        {
            EventId = eventId;
            Number = number;
            Size = size;
            bookedSeats = new bool[size,size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    bookedSeats[i,j] = true;
                }
            }
        }
        public override int Number { get;}
        public int Size{ get; }
        public override int EventId { get; }
        public override int Capacity
        {
            get { return Size * Size; }
        }
        private bool[,] bookedSeats;
        public override Invitation BookSeat(int userId)
        {
            for (int i = 0; i < this.Size; i++)
            {
                for (int j = 0; j < this.Size; j++)
                {
                    if (bookedSeats[i, j])
                    {
                        bookedSeats[i, j] = false;
                        return new Invitation(EventId, Number, userId);
                    }
                }
            }
            return null;
        }
        public override int FreeSeatsCount ()
        {
            int f = 0;
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (bookedSeats[i, j])
                    {
                        f++;
                    }
                }
            }
            return f;
        }
        public override bool IsComposite()
        {
            return false;
        }
    }
}