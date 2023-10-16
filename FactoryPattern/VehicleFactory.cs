using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numTires)
        {
            switch (numTires) 
            {
                case 2:
                    return new Motorbike();
                case 4:
                    return new Car();
                default:
                    throw new Exception("Unexpected number of tires. Sorry!");
            }
        }
    }
}
