using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1oop2
{
    public static class BookingHelper
    {
        private static int count = 0;

        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            double total = numberOfTickets * pricePerTicket;
            if (numberOfTickets >= 5)
                total *= 0.10;
            return total;
        }

        public static string GenerateBookingReference()
        {
            count++;
            return $"BK-{count}";
        }
    }
}
