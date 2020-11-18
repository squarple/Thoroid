using static System.Math;

namespace Thoroid
{
    public static class ExtensionMethods
    {
        public static double DegToRad(this double angle)
        {
            return angle * PI / 180;
        }

        public static Points MatrixMultiplication14X44(this double[,] matrixA, double[,] matrixB)
        {
            var matrixC = new double[1, 4];

            for (var i = 0; i < 1; ++i)
            {
                for (var j = 0; j < 4; ++j)
                {
                    matrixC[i, j] = 0;

                    for (var k = 0; k < 4; ++k)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            return new Points(matrixC[0, 0], matrixC[0, 1], matrixC[0, 2]);
        }

        public static double[,] MatrixMultiplication44X44(double[,] matrixA, double[,] matrixB)
        {
            var matrixC = new double[4, 4];

            for (var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 4; j++)
                {
                    matrixC[i, j] = 0;

                    for (var k = 0; k < 4; k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            return matrixC;
        }

        public static Points OrthogonalProjection(this Points point)
        {
            return new Points(point.X, point.Y, 0);
        }

        public static Points ProfileProjection(this Points point)
        {
            return new Points(point.Z, point.Y, 0);
        }

        public static Points HorizontalProjection(this Points point)
        {
            return new Points(point.X, point.Z, 0);
        }

        public static Points ObliqueProjection(this Points point, double l, double alpha)
        {
            double[,] matrix =
            {
                {1                        , 0                        , 0, 0},
                {0                        , 1                        , 0, 0},
                {l * Cos(alpha.DegToRad()), l * Sin(alpha.DegToRad()), 0, 0},
                {0                        , 0                        , 0, 1}
            };
            return point.pointMatrix.MatrixMultiplication14X44(matrix);
        }

        public static Points AxonometryProjection(this Points point, double phi, double theta)
        {
            double[,] matrix =
            {
                { Cos(theta.DegToRad()),  Sin(phi.DegToRad()) * Sin(theta.DegToRad()), 0, 0 },
                { 0                    ,  Cos(phi.DegToRad())                        , 0, 0 },
                { Sin(theta.DegToRad()), -Sin(phi.DegToRad()) * Cos(theta.DegToRad()), 0, 0 },
                { 0                    ,  0                                          , 0, 0 }
            };
            return point.pointMatrix.MatrixMultiplication14X44(matrix);
        }

        public static Points PerspectiveProjection(this Points point, double d)
        {
            if (point.Z >= 0 && point.Z < 0.1)
                point.Z = 0.1;
            else if (point.Z < 0 && point.Z > -0.1)
                point.Z = -0.1;

            return new Points(point.X / (point.pointMatrix[0, 2] / d), point.Y / (point.pointMatrix[0, 2] / d), d);
        }

        public static Points ViewMatrix(this Points point, double theta, double phi, double ro)
        {
            double[,] viewMatrix =
            {
                {-Sin(theta.DegToRad()), -Cos(phi.DegToRad()) * Cos(theta.DegToRad()), -Sin(phi.DegToRad()) * Cos(theta.DegToRad()), 0 },
                { Cos(theta.DegToRad()), -Cos(phi.DegToRad()) * Sin(theta.DegToRad()), -Sin(phi.DegToRad()) * Sin(theta.DegToRad()), 0 },
                { 0                    ,  Sin(phi.DegToRad())                        , -Cos(phi.DegToRad())                        , 0 },
                { 0                    ,  0                                          ,  ro                                         , 1 }
            };
            return point.pointMatrix.MatrixMultiplication14X44(viewMatrix);
        }
    }
}