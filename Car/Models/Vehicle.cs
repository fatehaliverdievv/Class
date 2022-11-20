using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars.Models
{
    internal class Vehicle
    {
        public string Color;
        public int Year;

        public Vehicle(int Year)
        {
            this.Year = Year;
        }
        public Vehicle(int Year, string Color) :this(Year)
        {
            this.Color = Color;
        }
    }
}
