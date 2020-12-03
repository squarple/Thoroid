using System.Drawing;

namespace Thoroid
{
    public class Polygon
    {
        private Points[] points;
        public Points[] Points
        {
            get => points;
            set => points = value;
        }
        public Point[] ScreenPoints
        {
            get
            {
                return new[]
                {
                    new Point((int)points[0].X, (int)points[0].Y), 
                    new Point((int)points[1].X, (int)points[1].Y), 
                    new Point((int)points[2].X, (int)points[2].Y), 
                    new Point((int)points[3].X, (int)points[3].Y), 
                };
            }
        }

        public int[] ZArray { get; set; }
        public Points midpoint { get; }

        public Polygon(Points point1, Points point2, Points point3, Points point4)
        {
            points = new Points[4];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
            points[3] = point4;

            ZArray = new int[4];
            ZArray[0] = (int)point1.Z;
            ZArray[1] = (int)point2.Z;
            ZArray[2] = (int)point3.Z;
            ZArray[3] = (int)point4.Z;

            midpoint = new Points
            {
                X = (point1.X +point2.X + point3.X + point4.X) / 4, 
                Y = (point1.Y +point2.Y + point3.Y + point4.Y) / 4, 
                Z = (point1.Z +point2.Z + point3.Z + point4.Z) / 4, 
            };
        }
    }
}