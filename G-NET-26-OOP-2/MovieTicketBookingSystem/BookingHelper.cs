using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_OOP_2.MovieTicketBookingSystem
{
    public static class BookingHelper
    {
        private static int bookCounter = 0;
        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            double subTotal = numberOfTickets * pricePerTicket;
            if (numberOfTickets >= 5) {
                return subTotal - (subTotal * (10 / 100.0));
            }
            return subTotal;
            
        }
        public static string GenerateBookingReference() 
        {
            bookCounter++;
            return $"BK-{bookCounter}";
        
        }
    }
}
