using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLinesApp
{
    class CrewMember
    {
        string name;
        int age;
        Dictionary.CrewRole role;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        internal Dictionary.CrewRole Role { get => role; set => role = value; }

        public CrewMember(string name, int age, Dictionary.CrewRole role)
        {
            Name = name;
            Age = age;
            Role = role;
        }

        public override string ToString()
        {
            return $"Name: {name}\tAge: {age}\tRole: {role.ToString().Replace("_", " ")}";
        }
    }
}
