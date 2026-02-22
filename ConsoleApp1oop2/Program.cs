using ConsoleApp1oop2.Enums;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1oop2
{
    internal class Program
    {
        #region Q5
        static void Main()
        {
            cinema cinema = new cinema();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter data for Ticket {i + 1}");
                Console.Write("Movie Name: ");
                string name = Console.ReadLine();
                Console.Write("Ticket Type (0=Standard,1=VIP,2=IMAX): ");
                TicketType type = (TicketType)int.Parse(Console.ReadLine());
                Console.Write("Seat Row: ");
                char row = char.Parse(Console.ReadLine());
                Console.Write("Seat Number: ");
                int num = int.Parse(Console.ReadLine());
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                Ticket t = new Ticket(name, new Seat(1, 'a'), type, price);
                cinema.AddTicket(t);
            }

            Console.WriteLine("\n=== All Tickets ===");
            for (int i = 0; i < 3; i++)
            {
                var t = cinema[i];
                if (t != null)
                {
                    Console.WriteLine($"#{t.TicketId} | {t.MovieName} | {t.Type} | Seat {t.Seat} | Price {t.Price} | After Tax {t.PriceAfterTax}");
                }
            }
            Console.Write("\nEnter movie name to search: ");
            string search = Console.ReadLine();
            var found = cinema[search];
            Console.WriteLine(found != null? $"Found: #{found.TicketId} | {found.MovieName} | Seat {found.Seat}": "Not found");

            Console.WriteLine($"\nTotal tickets sold: {Ticket.GetTotalTicketsSold()}");

            Console.WriteLine(BookingHelper.GenerateBookingReference());
            Console.WriteLine(BookingHelper.GenerateBookingReference());

            Console.WriteLine($"Group discount: {BookingHelper.CalcGroupDiscount(5, 80)}");
            {
            
        }
    }
        #endregion
    }
}
