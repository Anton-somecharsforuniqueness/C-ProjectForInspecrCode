using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticToolAnalysisTest
{
    public sealed class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }

    class Program
    {
        static void Main(string[] args)   
        {
            var unused = "unused";
            var p1 = new Point(){X = 1, Y = 3, Z = 3};
            var p2 = new Point(){X = 1, Y = 3, Z = 2};
            Console.WriteLine(comparrePoints(p1, p2));
            Console.ReadKey();
        }

        private static bool comparrePoints(Point A, Point B)
        {
            return A.X == B.X && A.Y == B.Y && A.Z == B.Y;
        }
    }
}
