using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_OOP_1_2_.Movie_Ticket_Booking_System
{
    public class Ticket
    {
        private static int ticketCounter = 0;
        public int TicketId { get; private set; }
        public TicketType Type { get; set; }
        private string movieName;
        public SeatLocation Seat { get; set; }
        private double price;
        public string MovieName
        {
            get { return movieName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    movieName = value;
                }
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value> 0) price = value;

            }
        }
        public double PriceAfterTax
        {
            get { return Price +(Price* 0.14); } 
        } 
        public Ticket(string moviename , TicketType type , SeatLocation seat , double price)
        {
            ticketCounter++;
            TicketId = ticketCounter;
            MovieName = moviename;
            Type = type;
            Seat = seat;
            Price = price;
        }
        public Ticket(string moviename)
        {
            ticketCounter++;
            TicketId = ticketCounter;
            MovieName = moviename;
            Type = TicketType.Standard;
            Seat = new SeatLocation('A', 1);
            Price = 50.0;
        }
        public static int GetTotalTicketsSold()
        {
            return ticketCounter;
        }
        public double CalcTotal(double taxPercent)
        {
            return Price + (Price * taxPercent) / 100;
        }
        public void ApplyDiscount(double discountAmount)
        {
            if(discountAmount >0 && discountAmount <= Price)
            {
                Price -= discountAmount;
                discountAmount = 0;
            }
        }
        public void PrintTicket()
        {
            Console.WriteLine($"Movie   : {MovieName}");
            Console.WriteLine($"Type    : {Type}");
            Console.WriteLine($"Seat    : {Seat.ToString()}");
            Console.WriteLine($"Price   : {Price:F2}");
        }
    }
}
