using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic.Year2019
{
    public class Day03 : ISolvePuzzles
    {
        public string GetSolution1(string input)
        {
            string[] wireInput = input.Split('\n');

            IDictionary<Point, int> wirePath1 = GetWirePath(wireInput[0].Split(','));
            IDictionary<Point, int> wirePath2 = GetWirePath(wireInput[1].Split(','));

            var intersections = wirePath1.Keys.Intersect(wirePath2.Keys);
            var nearestDistance = intersections.Select(ManhattanDistance).Min();

            return nearestDistance.ToString();
        }

        IDictionary<Point, int> GetWirePath(string[] wirePathDescription)
        {
            IDictionary<Point, int> distanceDictionary = new Dictionary<Point, int>();
            
			int distance = 0;
            var previousPoint = new Point(0, 0);

            foreach (string pathDescription in wirePathDescription)
            {
                (int dx, int dy) = GetDirection(pathDescription[0]);
                int steps = int.Parse(pathDescription.Substring(1));

                for (int i = 1; i <= steps; i++)
                {
                    var currentPoint = new Point(dx + previousPoint.X, dy + previousPoint.Y);
                    previousPoint = currentPoint;

                    distanceDictionary.TryAdd(currentPoint, ++distance);
                }
            }

            return distanceDictionary;
        }

        int ManhattanDistance(Point point) => point.X + point.Y;

        private (int dx, int dy) GetDirection(char direction)
        {
            switch (direction)
            {
                case 'R':
                    return (1, 0);
                case 'U':
                    return (0, 1);
                case 'L':
                    return (-1, 0);
                case 'D':
                    return (0, -1);
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction));
            }
        }

        public string GetSolution2(string input)
        {
            string[] wireInput = input.Split('\n');

            IDictionary<Point, int> wirePath1 = GetWirePath(wireInput[0].Split(','));
            IDictionary<Point, int> wirePath2 = GetWirePath(wireInput[1].Split(','));

            var intersections = wirePath1.Keys.Intersect(wirePath2.Keys);

            var minTimeDistance = int.MaxValue;
            foreach (var point in intersections)
            {
                var currentMin = wirePath1[point] + wirePath2[point];
                if (currentMin < minTimeDistance) minTimeDistance = currentMin;
            }

            return minTimeDistance.ToString();
        }
    }

    internal struct Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
