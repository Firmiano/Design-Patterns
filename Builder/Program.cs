using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();

            VehicleBuilder builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            Console.ReadKey();
        }
    }
}
