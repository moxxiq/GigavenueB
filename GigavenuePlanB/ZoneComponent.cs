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
        public int Number { get;}
        public int Capacity{ get; }
        public int EventId { get; }
        public virtual Invitation BookSeat(int userId)
        {
            throw new NotImplementedException();
        }
        public virtual int FreeSeatsCount ()
        {
            throw new NotImplementedException();
        }
        public virtual bool IsComposite()
        {
            return true;
        }

        public override string ToString()
        {
            return $"Nomer: {Number.ToString()},  EID:{EventId.ToString()},  Seats left: {FreeSeatsCount().ToString()}";
        }
    }
}