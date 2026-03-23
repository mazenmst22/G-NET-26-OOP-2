using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_OOP_1_2_.Movie_Ticket_Booking_System
{
    public class Ticket
    {
        public string MovieName { get; set; }
        public TicketType Type { get; set; }
        public SeatLocation Seat { get; set; }
        private double Price { get; set; }
        public Ticket(string moviename , TicketType type , SeatLocation seat , double price)
        {
            MovieName = moviename;
            Type = type;
            Seat = seat;
            Price = price;
        }
        public Ticket(string moviename)
        {
            MovieName = moviename;
            Type = TicketType.Standard;
            Seat = new SeatLocation('A', 1);
            Price = 50.0;
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
