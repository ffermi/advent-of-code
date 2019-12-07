using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic.Year2019
{
    public class Day06 : ISolvePuzzles
    {
        public string GetSolution1(string input)
        {
            var orbits = input.Split(Environment.NewLine).Select(x => x.Split(')'));

            IDictionary<string, string> inverseOrbits = orbits.ToDictionary(x => x[1], x => x[0]);

            IDictionary<string, int> inverseOrbitCosts = OrbitCostCalculator(inverseOrbits);

            return inverseOrbitCosts.Sum(x => x.Value).ToString();
        }

        public string GetSolution2(string input)
        {
            var orbits = input.Split(Environment.NewLine).Select(x => x.Split(')'));

            IDictionary<string, string> inverseOrbits = orbits.ToDictionary(x => x[1], x => x[0]);
            IDictionary<string, int> inverseOrbitCosts = OrbitCostCalculator(inverseOrbits);

            var youPath = GetObjPath("YOU");
            var santaPath = GetObjPath("SAN");

            int i = 0;
            while (!youPath.Contains(santaPath[i])) i++;

            var commonObj = santaPath[i];
            var commonCost = inverseOrbitCosts[commonObj];

            var youCost = inverseOrbitCosts["YOU"] - commonCost - 1;
            var santaCost = inverseOrbitCosts["SAN"] - commonCost - 1;

            return (youCost + santaCost).ToString();

            string[] GetObjPath(string obj)
            {
                var objPath = new List<string>();
                var current = obj;
                while (inverseOrbits[current] != "COM")
                {
                    objPath.Add(inverseOrbits[current]);
                    current = inverseOrbits[current];
                }

                return objPath.ToArray();
            }
        }

        private static IDictionary<string, int> OrbitCostCalculator(IDictionary<string, string> orbits)
        {

            IDictionary<string, int> orbitCosts = orbits.ToDictionary(x => x.Key, _ => -1);

            foreach (var obj in orbits.Keys)
            {
                var currentObj = obj;
                var cost = 0;

                while (currentObj != "COM")
                {
                    if (orbitCosts[currentObj] > 0)
                    {
                        cost += orbitCosts[currentObj];
                        break;
                    }
                    else
                    {
                        cost++;
                        currentObj = orbits[currentObj];
                    }
                }

                orbitCosts[obj] = cost;
            }

            return orbitCosts;
        }
    }
}
