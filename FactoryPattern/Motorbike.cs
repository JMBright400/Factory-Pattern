using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Motorbike : IVehicle
    {
        public void Drive ()
        {
            Console.WriteLine("Built a motorbike to ride!");
        }
    }
}
