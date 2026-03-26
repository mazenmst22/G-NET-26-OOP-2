using G_NET_26_OOP_1_2_.Movie_Ticket_Booking_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_OOP_2.MovieTicketBookingSystem
{
    public class Cinema
    {
        private Ticket[] ticket = new Ticket[20];
        
        public Ticket this[int index]
        {
            get
            {
                if (index < 0 || index >= ticket.Length) return null;
                return ticket[index];
            }
            set
            {
                if(index >=0 && index < ticket.Length) 
                ticket[index] = value;
            }
        }
        public Ticket this[string movieName]
        {
            get
            {
                for(int i=0; i < ticket.Length; i++)
                {
                    if (ticket[i]!=null && ticket[i].MovieName==movieName)
                    {
                        return ticket[i];
                    }
                }
                return null;
            }

        }
        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < ticket.Length; i++)
            {
                if (ticket[i] == null)
                {
                    ticket[i] = t;
                    return true;
                }
            }
            return false;
        }

    }
}
