using System.Drawing;

namespace Thoroid
{
    public class Polygon
    {
        public Points[] Points { get; set; }
        public Point[] ScreenPoints
        {
            get
            {
                return new[]
                {
                    new Point((int)Points[0].X, (int)Points[0].Y), 
                    new Point((int)Points[1].X, (int)Points[1].Y), 
                    new Point((int)Points[2].X, (int)Points[2].Y), 
                    new Point((int)Points[3].X, (int)Points[3].Y), 
                };
            }
        }

        public int[] ZArray { get; set; }
        public Points midpoint { get; }

        public Polygon(Points point1, Points point2, Points point3, Points point4)
        {
            Points = new Points[4];
            Points[0] = point1;
            Points[1] = point2;
            Points[2] = point3;
            Points[3] = point4;

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