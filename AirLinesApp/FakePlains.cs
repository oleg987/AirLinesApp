using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLinesApp
{
    class FakePlains
    {
        public static List<Plane> GetFakePlains(int planesCount)
        {
            List<Plane> planes = new List<Plane>();

            Random r = new Random();

            int cargoPlanesCount = r.Next(planesCount);
            int passengerPlanesCount = planesCount - cargoPlanesCount;

            string[] planeModels = { "Boeing 737", "Boeing 747", "Boeing 767", "Boeing 777", "Airbus A320", "Airbus A330", "Airbus A380", "Airbus A321" };

            for (int i = 0; i < cargoPlanesCount; i++)
            {
                Plane plane = new CargoPlane(planeModels[r.Next(planeModels.Length)], GetFakeCrew("cargo", r), r.Next(5, 41));
                planes.Add(plane);
            }

            for (int i = 0; i < passengerPlanesCount; i++)
            {
                Plane plane = new PassengerPlane(planeModels[r.Next(planeModels.Length)], GetFakeCrew("passenger", r), r.Next(5, 41));
                planes.Add(plane);
            }            

            return planes;
        }

        private static Crew GetFakeCrew(string type, Random r)
        {
            List<CrewMember> crewMembers = new List<CrewMember>();            

            string[] firstNames = { "John", "Mike", "Peter", "Bob", "Frank", "Alice", "Ann", "Jane", "Lilly", "Katrin" };
            string[] lastNames = { "Brown", "Cooper", "Merkury", "Adams", "Fox", "Williams", "Doe", "Douglas" };            

            crewMembers.Add(new CrewMember(firstNames[r.Next(firstNames.Length)] + " " + lastNames[r.Next(lastNames.Length)], r.Next(25, 50), Dictionary.CrewRole.Master));
            crewMembers.Add(new CrewMember(firstNames[r.Next(firstNames.Length)] + " " + lastNames[r.Next(lastNames.Length)], r.Next(25, 50), Dictionary.CrewRole.Second_Officer));
            crewMembers.Add(new CrewMember(firstNames[r.Next(firstNames.Length)] + " " + lastNames[r.Next(lastNames.Length)], r.Next(25, 50), Dictionary.CrewRole.Navigator));

            switch (type)
            {
                case "cargo":
                    {
                        for (int i = 0; i < r.Next(1, 6); i++)
                        {
                            crewMembers.Add(new CrewMember(firstNames[r.Next(firstNames.Length)] + " " + lastNames[r.Next(lastNames.Length)], r.Next(25, 50), Dictionary.CrewRole.Mechanic));
                        }
                        break;
                    }
                case "passenger":
                    {
                        for (int i = 0; i < r.Next(1, 6); i++)
                        {
                            crewMembers.Add(new CrewMember(firstNames[r.Next(firstNames.Length)] + " " + lastNames[r.Next(lastNames.Length)], r.Next(18, 25), Dictionary.CrewRole.Stewardess));
                        }
                        break;
                    }
            }

            Crew crew = new Crew(crewMembers);

            return crew;
        }
    }
}

