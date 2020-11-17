namespace Thoroid
{
    public class Points
    {
        public double[,] p = new double[1, 4] { { 0, 0, 0, 1 } };

        public double X
        {
            get => p[0, 0];
            set => p[0, 0] = value;
        }
        public double Y
        {
            get => p[0, 1];
            set => p[0, 1] = value;
        }
        public double Z
        {
            get => p[0, 2];
            set => p[0, 2] = value;
        }

        public Points(double x, double y, double z)
        {
            p = new double[1, 4] { { x, y, z, 1 } };
        }

        public Points(int x, int y, int z)
        {
            p = new double[1, 4] { { x, y, z, 1 } };
        }

        public Points(float x, float y, float z)
        {
            p = new double[1, 4] { { x, y, z, 1 } };
        }

        public Points()
        {
            //p = new double[1, 4] { { X, Y, Z, 1 } };
        }
    }
}
