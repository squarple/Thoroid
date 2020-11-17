using static System.Math;

namespace Thoroid
{
    public static class Transformations
    {
        private static double[,] rotateMatrix;

        public static Points Move(Points point, double dx, double dy, double dz)
        {
            double[,] moveMatrix =
            {
                {1 , 0 , 0 , 0},
                {0 , 1 , 0 , 0},
                {0 , 0 , 1 , 0},
                {dx, dy, dz, 1}
            };

            return point.pointMatrix.MatrixMultiplication14X44(moveMatrix);
        }

        public static Points Scale(Points point, double sx, double sy, double sz)
        {
            double[,] scaleMatrix =
            {
                {sx, 0 , 0 , 0},
                {0 , sy, 0 , 0},
                {0 , 0 , sz, 0},
                {0 , 0 , 0 , 1}
            };

            return point.pointMatrix.MatrixMultiplication14X44(scaleMatrix);
        }

        public static void CreateRotateMatrix(double thetaX, double thetaY, double thetaZ)
        {
            double[,] rotateX =
            {
                {1,  0                     , 0                     , 0},
                {0,  Cos(thetaX.DegToRad()), Sin(thetaX.DegToRad()), 0},
                {0, -Sin(thetaX.DegToRad()), Cos(thetaX.DegToRad()), 0},
                {0,  0                     , 0                     , 1}
            };
            double[,] rotateY =
            {
                {Cos(thetaY.DegToRad()), 0, -Sin(thetaY.DegToRad()), 0},
                {0                     , 1,  0                     , 0},
                {Sin(thetaY.DegToRad()), 0,  Cos(thetaY.DegToRad()), 0},
                {0                     , 0,  0                     , 1}
            };
            double[,] rotateZ =
            {
                { Cos(thetaZ.DegToRad()), Sin(thetaZ.DegToRad()), 0, 0},
                {-Sin(thetaZ.DegToRad()), Cos(thetaZ.DegToRad()), 0, 0},
                {0                      , 0                     , 1, 0},
                {0                      , 0                     , 0, 1}
            };
            var matrix = ExtensionMethods.MatrixMultiplication44X44(rotateX, rotateY);
            matrix = ExtensionMethods.MatrixMultiplication44X44(matrix, rotateZ);
            rotateMatrix = matrix;
        }

        public static Points Rotate(Points p)
        {
            return p.pointMatrix.MatrixMultiplication14X44(rotateMatrix);
        }
    }
}