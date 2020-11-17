namespace Thoroid
{
    public class _4Points
    {
        public System.Drawing.Point[] points;
        public int[] z_array;

        public _4Points(Points point1, Points point2, Points point3, Points point4)
        {
            points = new System.Drawing.Point[4];
            points[0] = new System.Drawing.Point((int)point1.X, (int)point1.Y);
            points[1] = new System.Drawing.Point((int)point2.X, (int)point2.Y);
            points[2] = new System.Drawing.Point((int)point3.X, (int)point3.Y);
            points[3] = new System.Drawing.Point((int)point4.X, (int)point4.Y);

            z_array = new int[4];
            z_array[0] = (int)point1.Z;
            z_array[1] = (int)point2.Z;
            z_array[2] = (int)point3.Z;
            z_array[3] = (int)point4.Z;
        }
    }
}