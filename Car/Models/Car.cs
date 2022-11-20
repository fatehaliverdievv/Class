using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars.Models
{
    internal class Car : Vehicle
    {
        string Brand;
        string Model;
        double FuelCapacity;
        byte CurrentFuel;
        double Fuelfor1km;

        public Car(string Brand, string Model, byte FuelCapacity, double Fuelfor1km,int Year) :base(Year)
        {
            this.Year = Year;
            this.Brand = Brand;
            this.Model = Model;
            this.FuelCapacity = FuelCapacity;
            this.Fuelfor1km = Fuelfor1km;
        }
        public Car(string Brand, string Model, byte FuelCapacity, double Fuelfor1km, byte CurrentFuel,int Year) :this(Brand, Model, FuelCapacity,Fuelfor1km,Year)
        {
            this.CurrentFuel = CurrentFuel;
        }
        public string ShowInfo()
        {
            return $"{Brand} {Model} {Year} {FuelCapacity} {Fuelfor1km} {CurrentFuel} ";
        }
        public void Drive(int lengthoftheroad)
        {
            double fuelcomsumptionoftheroad = lengthoftheroad * Fuelfor1km;
            if (CurrentFuel>=fuelcomsumptionoftheroad)
            {
                double remainingfuel = CurrentFuel - fuelcomsumptionoftheroad;
                Console.WriteLine("It is enough. Remaining fuel:" +remainingfuel);
            }
            else
            {
                Console.WriteLine("Not enough.");
            }

        }
    }
}
