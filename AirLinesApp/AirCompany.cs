using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLinesApp
{
    class AirCompany
    {
        string title;
        List<Plane> planesPark;
        int totalPassengers;
        int totalCargo;
        int cargoPlanesCount;
        int passengerPlanesCount;
        int totalPlanes;
        int totalCrewMembers;

        public string Title { get => title; set => title = value; }

        public AirCompany(List<Plane> planesPark, string title)
        {
            this.planesPark = planesPark;
            Title = title;
            Statistics();
        }

        private void Statistics()
        {            
            cargoPlanesCount = 0;
            passengerPlanesCount = 0;
            totalPlanes = 0;
            totalCrewMembers = 0;

            foreach (var item in planesPark)
            {
                if (item != null)
                {
                    if (typeof(CargoPlane) == item.GetType())
                    {
                        totalCargo += ((CargoPlane)item).Tonnage;
                        cargoPlanesCount++;
                    }

                    if (typeof(PassengerPlane) == item.GetType())
                    {
                        totalPassengers += ((PassengerPlane)item).MaxPassengerCount;
                        passengerPlanesCount++;
                    }
                    totalPlanes++;
                    totalCrewMembers += item.Crew.CrewMembers.Count;
                }
                
            }
        }

        public string GetPlanesInfo()
        {
            string result = "";
            foreach (var item in planesPark)
            {
                result += item.ToString();
            }
            return result;
        }

        public override string ToString()
        {
            return
                $"{title}\n\n" +
                $"Total planes: {totalPlanes}\n" +
                $"Total crew members: {totalCrewMembers}\n" +
                $"Cargo planes: {cargoPlanesCount}\n" +
                $"Passenger planes: {passengerPlanesCount}\n" +
                $"Total cargo capacity: {totalCargo} tonns\n" +
                $"Total passenger capacity: {totalPassengers} persons\n";
        }
    }
}
