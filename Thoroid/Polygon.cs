﻿namespace Thoroid
{
    public class Polygon
    {
        public System.Drawing.Point[] Points { get; }
        public int[] ZArray { get; }
        public Points midpoint { get; }

        public Polygon(Points point1, Points point2, Points point3, Points point4)
        {
            Points = new System.Drawing.Point[4];
            Points[0] = new System.Drawing.Point((int)point1.X, (int)point1.Y);
            Points[1] = new System.Drawing.Point((int)point2.X, (int)point2.Y);
            Points[2] = new System.Drawing.Point((int)point3.X, (int)point3.Y);
            Points[3] = new System.Drawing.Point((int)point4.X, (int)point4.Y);

            ZArray = new int[4];
            ZArray[0] = (int)point1.Z;
            ZArray[1] = (int)point2.Z;
            ZArray[2] = (int)point3.Z;
            ZArray[3] = (int)point4.Z;

            midpoint = new Points()
            {
                X = (point1.X +point2.X + point3.X + point4.X) / 4, 
                Y = (point1.Y +point2.Y + point3.Y + point4.Y) / 4, 
                Z = (point1.Z +point2.Z + point3.Z + point4.Z) / 4, 
            };
        }
    }
}