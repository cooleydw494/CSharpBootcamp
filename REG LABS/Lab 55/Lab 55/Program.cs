using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_55
{
    class Program
    {
        static void Main(string[] args)
        {
            var companyTeams = new HashSet<string>() { "Ferrari", "McLaren", "Toyota", "BMW", "Renault" };
            var traditionalTeams = new HashSet<string>() { "Ferrari", "McLaren" };
            var privateTeams = new HashSet<string>() { "Red Bull", "Toro Rosso", "Force India", "Brawn GP" };

            if (privateTeams.Add("Williams"))
            {
                Console.WriteLine("Williams was added to privateTeams");
            }
            else
            {
                Console.WriteLine("Williams was already in privateTeams");
            }

            if (companyTeams.Add("McLaren"))
            {
                Console.WriteLine("McLaren was added");
            }
            else
            {
                Console.WriteLine("McLaren was already in companyTeams");
            }

            if (traditionalTeams.IsSubsetOf(companyTeams))
            {
                Console.WriteLine("traditionalTeams is a subset of companyTeams");
            }

            if (companyTeams.IsSupersetOf(traditionalTeams))
            {
                Console.WriteLine("companyTeams is a superset of traditionalTeams");
            }

            traditionalTeams.Add("Williams");

            if (traditionalTeams.Overlaps(privateTeams))
            {
                Console.WriteLine("At least one team is the same with the privateTeams and traditionalTeams");
            }

            var allTeams = new SortedSet<string>(companyTeams);

            allTeams.UnionWith(privateTeams);
            allTeams.UnionWith(traditionalTeams);

            Console.WriteLine("\nall teams");
            foreach(string team in allTeams)
            {
                Console.WriteLine(team);
            }

            allTeams.ExceptWith(privateTeams);
            Console.WriteLine("\nno private team left");
            foreach(string team in allTeams)
            {
                Console.WriteLine(team);
            }

        }
    }
}
