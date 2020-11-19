namespace Thoroid
{
    public class Points
    {
        public double[,] PointMatrix { get; set; }  = new double[1, 4] {{0, 0, 0, 1}};

        public double X
        {
            get => PointMatrix[0, 0];
            set => PointMatrix[0, 0] = value;
        }
        public double Y
        {
            get => PointMatrix[0, 1];
            set => PointMatrix[0, 1] = value;
        }
        public double Z
        {
            get => PointMatrix[0, 2];
            set => PointMatrix[0, 2] = value;
        }

        public Points(double x, double y, double z)
        {
            PointMatrix = new double[1, 4] { { x, y, z, 1 } };
        }

        public Points(int x, int y, int z)
        {
            PointMatrix = new double[1, 4] { { x, y, z, 1 } };
        }

        public Points(float x, float y, float z)
        {
            PointMatrix = new double[1, 4] { { x, y, z, 1 } };
        }

        public Points()
        {
            //p = new double[1, 4] { { X, Y, Z, 1 } };
        }
    }
}
