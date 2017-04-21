using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] str = Console.ReadLine().Split();
            Point p1 = new Point(Convert.ToInt32(str[0]), Convert.ToInt32(str[1]));
            Point p2 = new Point(Convert.ToInt32(str[2]), Convert.ToInt32(str[3]));
            Point p3 = new Point(Convert.ToInt32(str[4]), Convert.ToInt32(str[5]));
            Triangle t = new Triangle(p1, p2, p3);
            Console.WriteLine(t.IsRightAngled() ? "RIGHT" : t.IsAlmostRightAngled() ? "ALMOST" : "NEITHER");

        }
    }


    public class Point
    {
        // Properties
        public int X { get; set; }
        public int Y { get; set; }

        // Constructors
        public Point(int x, int y)
        {
           this.X = x;
           this.Y = y;
        }
        public int Distance(Point p)
        {
            return (this.X - p.X) * (this.X - p.X) + (this.Y - p.Y) * (this.Y - p.Y);
        }
    }

    public class Triangle
    {
        // Properties
        public Point P1 { get; set; }
        public Point P2 { get; set; }
        public Point P3 { get; set; }

        // Consturctors
        
        public Triangle(Point p1, Point p2, Point p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }

        // Sides Squares
        public int Side1Squared   // P1P2
        {
            get
            {
                return P1.Distance(P2);
            }
        }
        public int Side2Squared   // P2P3
        {
            get
            {
                return P2.Distance(P3);
            }
        }
        public int Side3Squared   // P1P3
        {
            get
            {
                return P1.Distance(P3);
            }
        }

        // Other Methods
        public bool IsRightAngled()
        {
            if (IsTriangle())
                if ((Side1Squared + Side2Squared == Side3Squared) ||
                    (Side3Squared + Side2Squared == Side1Squared) ||
                    (Side1Squared + Side3Squared == Side2Squared))
                { return true; }
            return false;
        }
        public bool IsAlmostRightAngled()
        {
            int[] xMovement = { -1, 0, 1, 0 };
            int[] yMovement = { 0, -1, 0, 1 };
            Point a1, a2, a3;

            for (int i = 0; i < xMovement.Length; i++)
            {
                a1 = new Point(P1.X + xMovement[i], P1.Y + yMovement[i]);
                a2 = new Point(P2.X + xMovement[i], P2.Y + yMovement[i]);
                a3 = new Point(P3.X + xMovement[i], P3.Y + yMovement[i]);
                Triangle first = new Triangle(a1, P2, P3);
                Triangle second = new Triangle(P1, a2, P3);
                Triangle third = new Triangle(P1, P2, a3);
                if (first.IsRightAngled()) { return true; }
                if (second.IsRightAngled()) { return true; }
                if (third.IsRightAngled()) { return true; }
            }
            return false;
        }
        public bool IsTriangle()
        {
            double s1 = Math.Sqrt(Side1Squared);
            double s2 = Math.Sqrt(Side2Squared);
            double s3 = Math.Sqrt(Side3Squared);
            return s1 + s2 > s3 && s3 + s2 > s1 && s3 + s1 > s2;
        }
    }
}