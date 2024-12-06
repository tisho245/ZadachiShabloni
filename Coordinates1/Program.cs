namespace Coordinates1
{
    internal class Program
    {
        
        public static void DrawFigure(List<Point<int>> points, int width, int height)
        {
           
            char[,] daska = new char[height, width];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    daska[y, x] = '.';
                }
            }

            foreach (var point in points)
            {
                if (point.X >= 0 && point.X < width && point.Y >= 0 && point.Y < height)
                {
                    daska[point.Y, point.X] = 'X';
                }
            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(daska[y, x]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            Point<int> a = new Point<int>(x, y);
            a.Swap();
            Console.WriteLine(a.X + " " + a.Y);
            Point<double> b = new Point<double>(1.0, 2.0);
            Point<double> c = new Point<double>(4.0, 6.0);
            Console.WriteLine(b.DistanceTo(c));
            Point<double> d = new Point<double>(2.0, 4.0);
            Point<double> e = new Point<double>(6.0, 8.0);
            d.MidPoint(e);
            Console.WriteLine("Pear");
            List<Point<int>> pear = new List<Point<int>>()
            {
                new Point<int>(3, 1),
                new Point<int>(8, 1),
                new Point<int>(10, 3),
                new Point<int>(10, 7),
                new Point<int>(8, 9),
                new Point<int>(8, 12),
                new Point<int>(7, 13),
                new Point<int>(6, 13),
                new Point<int>(6, 14),
                new Point<int>(5, 14),
                new Point<int>(5, 13),
                new Point<int>(4, 13),
                new Point<int>(3, 12),
                new Point<int>(3, 9),
                new Point<int>(1, 7),
                new Point<int>(1, 3),
                new Point<int>(3, 1),
                new Point<int>(5, 13),
                new Point<int>(4, 14),
                new Point<int>(4, 15),
                new Point<int>(3, 16),
                new Point<int>(2, 16),
                new Point<int>(2, 15),
                new Point<int>(3, 14),
                new Point<int>(4, 14),
                new Point<int>(2, 16)
            };
            DrawFigure(pear, 20, 20);
            Console.WriteLine("Snail");
            List<Point<int>> snail = new List<Point<int>>()
            {
                new Point<int>(1, 8),
                new Point<int>(1, 10),
                new Point<int>(2, 10),
                new Point<int>(2, 12),
                new Point<int>(3, 12),
                new Point<int>(3, 11),
                new Point<int>(4, 11),
                new Point<int>(4, 12),
                new Point<int>(5, 12),
                new Point<int>(5, 10),
                new Point<int>(6, 7),
                new Point<int>(7, 7),
                new Point<int>(8, 9),
                new Point<int>(11,9),
                new Point<int>(12, 7),
                new Point<int>(13, 7),
                new Point<int>(13, 4),
                new Point<int>(12, 4),
                new Point<int>(12, 3),
                new Point<int>(13, 2),
                new Point<int>(4, 2),
                new Point<int>(3, 3),
                new Point<int>(3, 6),
                new Point<int>(2, 8),
                new Point<int>(1, 8)
            };
            DrawFigure(snail, 20, 20);
            Console.WriteLine("Whale");
            List<Point<int>> whale = new List<Point<int>>()
            {
                new Point<int>(9, 5),
                new Point<int>(11, 5),
                new Point<int>(11, 6),
                new Point<int>(7, 9),
                new Point<int>(9, 9),
                new Point<int>(11, 7),
                new Point<int>(12, 7),
                new Point<int>(13, 7),
                new Point<int>(13, 4),
                new Point<int>(12, 4),
                new Point<int>(9, 1),
                new Point<int>(4, 1),
                new Point<int>(2, 3),
                new Point<int>(2, 7),
                new Point<int>(3, 8),
                new Point<int>(4, 8),
                new Point<int>(4, 11),
                new Point<int>(2, 11),
                new Point<int>(1, 10),
                new Point<int>(1, 11),
                new Point<int>(2, 12),
                new Point<int>(7, 12),
                new Point<int>(8, 11),
                new Point<int>(8, 10),
                new Point<int>(7, 11),
                new Point<int>(5, 11),
                new Point<int>(5, 8),
                new Point<int>(7, 8),
                new Point<int>(9, 6),
                new Point<int>(9, 5),
                new Point<int>(4, 6)
            };
            DrawFigure(whale, 20, 20);
            Console.WriteLine("lebed");
            List<Point<int>> lebed = new List<Point<int>>()
            {
                 new Point<int>(6, 1),
                 new Point<int>(3, 4),
                 new Point<int>(3, 7),
                 new Point<int>(6, 9),
                 new Point<int>(6, 16),
                 new Point<int>(4, 17),
                 new Point<int>(1, 17),
                 new Point<int>(1, 18),
                 new Point<int>(3, 18),
                 new Point<int>(5, 20),
                 new Point<int>(7, 20),
                 new Point<int>(8, 19),
                 new Point<int>(8, 9),
                 new Point<int>(7, 8),
                 new Point<int>(9, 8),
                 new Point<int>(14, 11),
                 new Point<int>(18, 11),
                 new Point<int>(18, 12),
                 new Point<int>(22, 12),
                 new Point<int>(22, 10),
                 new Point<int>(20, 8),
                 new Point<int>(20, 6),
                 new Point<int>(21, 6),
                 new Point<int>(22, 8),
                 new Point<int>(24, 8),
                 new Point<int>(23, 7),
                 new Point<int>(23, 5),
                 new Point<int>(17, 1),
                 new Point<int>(6, 1),
                 new Point<int>(5, 19),
            };
            DrawFigure(lebed, 30, 30);
            Console.WriteLine("Rhomb: ");
            List<Point<int>> rhomb = new List<Point<int>>()
            {
                 new Point<int>(5, 3),
                 new Point<int>(6, 3),
                 new Point<int>(4, 4),
                 new Point<int>(7, 4),
                 new Point<int>(3, 5),
                 new Point<int>(8, 5),
                 new Point<int>(2, 6),
                 new Point<int>(9, 6),
                 new Point<int>(1, 7),
                 new Point<int>(10, 7),
                 new Point<int>(1, 8),
                 new Point<int>(10, 8),
                 new Point<int>(2, 9),
                 new Point<int>(9, 9),
                 new Point<int>(3, 10),
                 new Point<int>(8, 10),
                 new Point<int>(4, 11),
                 new Point<int>(7, 11),
                 new Point<int>(5, 12),
                 new Point<int>(6, 12)
            };
            DrawFigure(rhomb, 30, 30);
            Console.WriteLine("Snezhinka");
            List<Point<int>> snezhinka = new List<Point<int>>()
            {
           
              new Point<int>(5, 5),

           
              new Point<int>(5, 2),
              new Point<int>(5, 8),
              new Point<int>(2, 5),
              new Point<int>(8, 5),
              new Point<int>(3, 3),
              new Point<int>(7, 3),
              new Point<int>(3, 7),
              new Point<int>(7, 7),
              new Point<int>(4, 4),
              new Point<int>(6, 4),
              new Point<int>(4, 6),
              new Point<int>(6, 6)
            };
            DrawFigure(snezhinka, 11, 11);
        }
    }
}
