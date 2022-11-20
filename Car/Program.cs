using System.Security.Cryptography.X509Certificates;
using cars.Models;

namespace cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Mercedeces = new Car("Mercedeces", "CLS63AMG", 66 , 1.4d ,40 ,2014);
            Car Bmw = new Car("Bmw", "M5cs", 68, 1.5d , 30 ,2022 );
            Car Audi = new Car("Audi", "RS6WAGON", 82, 1.16d, 30, 2022);
            Console.WriteLine(Mercedeces.ShowInfo());
            Console.WriteLine(Bmw.ShowInfo());
            Console.WriteLine(Audi.ShowInfo());
            Mercedeces.Drive(26);
            Bmw.Drive(60);
            Audi.Drive(20);
        }
    }
}