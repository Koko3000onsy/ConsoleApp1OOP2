using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1oop2
{
    public struct Seat
    {
        public int Number;
        public char Row;

        public Seat(int number, char row)
        {
            Number = number;
            Row = row;

        }
        public string ToString()
        {
            return $"Seat: {Row}{Number}";
        }
    }
}
