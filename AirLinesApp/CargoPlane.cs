using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLinesApp
{
    class CargoPlane : Plane
    {
        int tonnage;

        public int Tonnage { get => tonnage; set => tonnage = value; }

        public CargoPlane(string model, Crew crew, int tonnage) : base(model, crew)
        {
            Tonnage = tonnage;
        }
        public override string ToString()
        {
            string result = base.ToString();
            result += $"\nCargo capacity: {tonnage}\n";
            return result;
        }

        public override void Fly()
        {
            
        }
    }
}
