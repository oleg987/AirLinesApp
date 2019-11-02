using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLinesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AirCompany airCompany = new AirCompany(FakePlains.GetFakePlains(100), "PanAm");

            Console.WriteLine(airCompany);

            Console.WriteLine(airCompany.GetPlanesInfo());
        }
    }
}
