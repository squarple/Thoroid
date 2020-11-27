using static System.Math;

namespace Thoroid
{
    public static class ExtensionMethods
    {
        private static double[,] rotateMatrix;
        private static double[,] moveMatrix;
        private static double[,] scaleMatrix;
        private static double[,] obliqueProjectionMatrix;
        private static double[,] axonometryProjectionMatrix;
        private static double[,] viewMatrix;

        public static void CreateMoveMatrix(double dx, double dy, double dz)
        {
            moveMatrix = new[,]
            {
                {1 , 0 , 0 , 0},
                {0 , 1 , 0 , 0},
                {0 , 0 , 1 , 0},
                {dx, dy, dz, 1}
            };
        }

        public static Points Move(this Points point)
        {
            return point.PointMatrix.MatrixMultiplication14X44(moveMatrix);
        }

        public static void CreateScaleMatrix(double sx, double sy, double sz)
        {
            scaleMatrix = new[,]
            {
                {sx, 0 , 0 , 0},
                {0 , sy, 0 , 0},
                {0 , 0 , sz, 0},
                {0 , 0 , 0 , 1}
            };
        }

        public static Points Scale(this Points point)
        {
            return point.PointMatrix.MatrixMultiplication14X44(scaleMatrix);
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

        public static Points Rotate(this Points point)
        {
            return point.PointMatrix.MatrixMultiplication14X44(rotateMatrix);
        }

        public static Points OrthogonalProjection(this Points point)
        {
            return new Points(point.X, point.Y, point.Z);
        }

        public static Points ProfileProjection(this Points point)
        {
            return new Points(point.Z, point.Y, point.X);
        }

        public static Points HorizontalProjection(this Points point)
        {
            return new Points(point.X, point.Z, 0);
        }

        public static void CreateObliqueProjectionMatrix(double l, double alpha)
        {
            obliqueProjectionMatrix = new[,]
            {
                {1                        , 0                        , 0, 0},
                {0                        , 1                        , 0, 0},
                {l * Cos(alpha.DegToRad()), l * Sin(alpha.DegToRad()), 0, 0},
                {0                        , 0                        , 0, 1}
            };
        }

        public static Points ObliqueProjection(this Points point)
        {
            return point.PointMatrix.MatrixMultiplication14X44(obliqueProjectionMatrix);
        }

        public static void CreateAxonometryProjectionMatrix(double phi, double theta)
        {
            axonometryProjectionMatrix = new [,]
            {
                { Cos(theta.DegToRad()),  Sin(phi.DegToRad()) * Sin(theta.DegToRad()), 0, 0 },
                { 0                    ,  Cos(phi.DegToRad())                        , 0, 0 },
                { Sin(theta.DegToRad()), -Sin(phi.DegToRad()) * Cos(theta.DegToRad()), 0, 0 },
                { 0                    ,  0                                          , 0, 0 }
            };
        }

        public static Points AxonometryProjection(this Points point)
        {
            return point.PointMatrix.MatrixMultiplication14X44(axonometryProjectionMatrix);
        }

        public static Points PerspectiveProjection(this Points point, double d)
        {
            if (point.Z >= 0 && point.Z < 0.1)
            {
                point.Z = 0.1;
            }
            else if (point.Z < 0 && point.Z > -0.1)
            {
                point.Z = -0.1;
            }

            return new Points(point.X / (point.PointMatrix[0, 2] / d), point.Y / (point.PointMatrix[0, 2] / d), d);
        }

        public static void CreateViewMatrix(double theta, double phi, double ro)
        {
            viewMatrix = new[,]
            {
                {-Sin(theta.DegToRad()), -Cos(phi.DegToRad()) * Cos(theta.DegToRad()), -Sin(phi.DegToRad()) * Cos(theta.DegToRad()), 0 },
                { Cos(theta.DegToRad()), -Cos(phi.DegToRad()) * Sin(theta.DegToRad()), -Sin(phi.DegToRad()) * Sin(theta.DegToRad()), 0 },
                { 0                    ,  Sin(phi.DegToRad())                        , -Cos(phi.DegToRad())                        , 0 },
                { 0                    ,  0                                          ,  ro                                         , 1 }
            };
        }

        public static Points ViewMatrix(this Points point)
        {
            return point.PointMatrix.MatrixMultiplication14X44(viewMatrix);
        }

        public static double DegToRad(this double angle)
        {
            return angle * PI / 180;
        }

        private static Points MatrixMultiplication14X44(this double[,] matrixA, double[,] matrixB)
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

        private static double[,] MatrixMultiplication44X44(double[,] matrixA, double[,] matrixB)
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
    }
}