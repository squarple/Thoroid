namespace Thoroid
{
    public static class ExtensionMethods
    {
        public static double DegToRad(this double angle)
        {
            return angle * System.Math.PI / 180;
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
    }
}