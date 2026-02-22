using ConsoleApp1oop2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1oop2
{
    public class Ticket
    {
        private static int counter = 0; // Static counter to keep track of the number of tickets created
        private string moveName;
        private double price;
        public Seat Seat;
        public TicketType Type;

        public int TicketId { get; }
        public TicketType type { get; set; }
        public Seat seat { get; set; }

        public string MovieName
        {
            get { return moveName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    moveName = value;
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
            }
        }
        public double PriceAfterTax => Price * 1.14;
        public Ticket(string movieName, Seat seat, TicketType type, double price)
        {
            counter++;
            TicketId = counter;
            MovieName = movieName;
            Seat = seat;
            Type = type;
            Price = price;
        }
        public static int GetTotalTicketsSold()
        {
            return counter;
        }
    }
}
