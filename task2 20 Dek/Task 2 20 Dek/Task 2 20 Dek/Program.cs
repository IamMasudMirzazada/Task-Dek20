using System;

namespace Task_2_20_Dek
{
    class Program
    {
        static void Main(string[] args)
        {
            Car cr = new Car();
            cr.Drive();
        }
    }
    class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is Driving");
        }
    }
}
