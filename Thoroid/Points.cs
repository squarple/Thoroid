namespace Thoroid
{
    public class Points
    {
        public double[,] pointMatrix = new double[1, 4] { { 0, 0, 0, 1 } };

        public double X
        {
            get => pointMatrix[0, 0];
            set => pointMatrix[0, 0] = value;
        }
        public double Y
        {
            get => pointMatrix[0, 1];
            set => pointMatrix[0, 1] = value;
        }
        public double Z
        {
            get => pointMatrix[0, 2];
            set => pointMatrix[0, 2] = value;
        }

        public Points(double x, double y, double z)
        {
            pointMatrix = new double[1, 4] { { x, y, z, 1 } };
        }

        public Points(int x, int y, int z)
        {
            pointMatrix = new double[1, 4] { { x, y, z, 1 } };
        }

        public Points(float x, float y, float z)
        {
            pointMatrix = new double[1, 4] { { x, y, z, 1 } };
        }

        public Points()
        {
            //p = new double[1, 4] { { X, Y, Z, 1 } };
        }
    }
}
