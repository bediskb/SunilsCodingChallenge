using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRefactor
{
    public class Toyota : Car
    {
        public Toyota(int yearBuilt, string vehicleMake)
        {
            YearBuilt = yearBuilt;
            VehicleMake = vehicleMake;
            Console.WriteLine(string.Format("===== Toyota {0} - {1}", YearBuilt, VehicleMake));
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
            throw new Exception("This feature is not available");
        }
        public override void Accelerate()
        {
            base.Accelerate();
            Console.WriteLine("Accelerating.....");
        }
    }
}
