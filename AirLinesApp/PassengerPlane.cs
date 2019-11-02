using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLinesApp
{
    class PassengerPlane : Plane
    {
        int maxPassengerCount;        

        public int MaxPassengerCount { get => maxPassengerCount; set => maxPassengerCount = value; }

        public PassengerPlane(string model, Crew crew, int maxPassengerCount) : base(model, crew)
        {
            MaxPassengerCount = maxPassengerCount;
        }

        public override string ToString()
        {
            string result = base.ToString();
            result += $"\nPassenger capacity: {maxPassengerCount}\n";
            return result;
        }

        public override void Fly()
        {
            
        }
    }
}
