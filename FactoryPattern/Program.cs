namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of tires please!");
            if (int.TryParse(Console.ReadLine(), out int numTires))
            {
                try
                {
                    IVehicle vehicle = VehicleFactory.GetVehicle(numTires);
                    vehicle.Drive();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Unexpected input. Please enter an expected number of tires.");
            }
        }
    }
}
