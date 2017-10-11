using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRefactor
{
    public class Mercedes : Car
    {
        public Mercedes(int yearBuilt, string vehicleMake)
        {
            YearBuilt = yearBuilt;
            VehicleMake = vehicleMake;
            Console.WriteLine(string.Format("===== Mercedes {0} - {1}", YearBuilt, VehicleMake));
        }
        public int GetYearBuilt()
        {
            Console.WriteLine(string.Format("Year built is {0}", YearBuilt));
            return YearBuilt;
        }

        public string GetVehicleMake()
        {
            Console.WriteLine(string.Format("Car make is {0}", VehicleMake));
            return VehicleMake;
        }

        public override void TurnOnHeatedChairMassage()
        {
            base.TurnOnHeatedChairMassage();
            Console.WriteLine("Massage Chair is warming up...");
            Console.WriteLine("Chair position checking ...");
            Console.WriteLine("Setting massage mode...");
            Console.WriteLine("Start massaging...");
        }

        public override void Accelerate()
        {
            base.Accelerate();
            Console.WriteLine("Check vehicle surround via 360 degree camera...");
            Console.WriteLine("Check speed zone");
            Console.WriteLine("Safe to accelerate");
            Console.WriteLine("Accelerating.....");
        }
    }
}
