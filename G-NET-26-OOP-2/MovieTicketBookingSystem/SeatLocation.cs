using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_OOP_1_2_.Movie_Ticket_Booking_System
{
    public struct SeatLocation
    {
        public char Row; public int Number;
        public SeatLocation(char row, int number)
        {
            Row = row;
            Number = number;
        }
        public string SetToString()
        {

            return $"{Row}{Number}";
        }
            public override string ToString()
            {
                return SetToString();
        }
    }
}
