using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRefactor
{
    public class Car
    {
        public int YearBuilt { get; set; }
        public string VehicleMake { get; set; }
        public int Odometer { get; set; }
        public virtual void TurnOnHeatedChairMassage(){}
        public virtual void Accelerate(){}
    }
}
