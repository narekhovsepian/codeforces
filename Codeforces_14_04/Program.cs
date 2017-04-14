using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_14_04
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    class Rectangle
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }

        public Rectangle(Point p1, Point p2)
        {
            this.P1 = p1;
            this.P2 = p2;
        }

        public int NumberOfIntegerPoints()
        {
            return ((Math.Abs(P1.X - P2.X) + 1) * (Math.Abs(P1.Y - P2.Y) + 1));


        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                String[] str = Console.ReadLine().Split();
                Point a = new Point(int.Parse(str[0]), int.Parse(str[1]));
                Point b = new Point(int.Parse(str[2]), int.Parse(str[3]));
                Rectangle rec = new Rectangle(a, b);
                result += rec.NumberOfIntegerPoints();
            }
            Console.WriteLine(result);
        }
    }


}
