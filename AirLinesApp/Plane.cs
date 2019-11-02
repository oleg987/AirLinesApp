using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLinesApp
{
    abstract class Plane
    {
        private static int currentPlaneId = 100;

        int planeId;
        string model;
        Crew crew;        

        public int PlaneId { get => planeId; }
        public string Model { get => model; set => model = value; }
        internal Crew Crew { get => crew; set => crew = value; }

        public Plane(string model, Crew crew)
        {
            planeId = currentPlaneId++;
            Model = model;
            Crew = crew;
        }

        protected abstract void Fly();

        public override string ToString()
        {
            return $"Bort №: {planeId}\nModel: {model}\n\nCrew:\n{crew}";
        }
    }
}
