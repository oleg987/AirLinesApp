using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLinesApp
{
    class Crew
    {
        List<CrewMember> crewMembers;

        internal List<CrewMember> CrewMembers { get => crewMembers; set => crewMembers = value; }

        public Crew(List<CrewMember> crewMembers)
        {
            CrewMembers = crewMembers;
        }

        public override string ToString()
        {
            string result = "";
            foreach (CrewMember item in crewMembers)
            {
                if (item != null)
                {
                    result += item.ToString() + "\n";
                }
            }
            return result;
        }
    }
}
