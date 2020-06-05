using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GigavenuePlanB
{
    public abstract class ZoneComponent
    {
        public ZoneComponent()
        {
        }
        public virtual int Number { get;}
        public virtual  int Capacity{ get; }
        public virtual  int EventId { get; }
        public abstract Invitation BookSeat(int userId);
        public abstract int FreeSeatsCount();
        public virtual bool IsComposite()
        {
            return true;
        }

        public override string ToString()
        {
            return $"Nomer: {Number.ToString()},  EID:{EventId.ToString()}, Seats left: {FreeSeatsCount().ToString()}";
        }
    }
}