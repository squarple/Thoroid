using System;
using Thoroid.Enums;
using System.Windows.Forms;
using static System.Math;

namespace Thoroid
{
    class Toroid
    {
        private readonly Rendering.Rendering render;

        private readonly int approximationBig;
        private readonly int approximationSmall;
        private readonly int radiusBig;
        private readonly int radiusSmall;

        private Points[,] realPoints;
        private Points[,] transformPoints;

        public Toroid(int approximationBig, int approximationSmall, int radiusBig, int radiusSmall, ref PictureBox picture)
        {
            this.approximationBig = approximationBig;
            this.approximationSmall = approximationSmall;
            this.radiusBig = radiusBig;
            this.radiusSmall = radiusSmall;

            realPoints = new Points[approximationBig, approximationSmall];
            transformPoints = new Points[approximationBig, approximationSmall];
            CreateCoordinates();

            render = new Rendering.Rendering(ref picture);
        }

        public void Update()
        {
            DrawFigure();
        }

        public void Move(double dX, double dY, double dZ)
        {
            ExtensionMethods.CreateMoveMatrix(dX, dY, dZ);
            for (var i = 0; i < realPoints.GetLength(0); i++)
            {
                for (var j = 0; j < realPoints.GetLength(1); j++)
                {
                    realPoints[i, j] = realPoints[i, j].Move();
                }
            }
            DrawFigure();
        }

        public void Scale(double sX, double sY, double sZ)
        {
            ExtensionMethods.CreateScaleMatrix(sX, sY, sZ);
            for (var i = 0; i < realPoints.GetLength(0); i++)
            {
                for (var j = 0; j < realPoints.GetLength(1); j++)
                {
                    realPoints[i, j] = realPoints[i, j].Scale();
                }
            }

            DrawFigure();
        }

        public void Rotate(double thetaX, double thetaY, double thetaZ)
        {
            ExtensionMethods.CreateRotateMatrix(thetaX, thetaY, thetaZ);
            for (var i = 0; i < realPoints.GetLength(0); i++)
            {
                for (var j = 0; j < realPoints.GetLength(1); j++)
                {
                    realPoints[i, j] = realPoints[i, j].Rotate();
                }
            }

            DrawFigure();
        }

        private void DrawFigure()
        {
            switch (Data.ViewType)
            {
                case ViewType.None:
                    UsualRendering();
                    break;
                case ViewType.Oblique:
                    ObliqueRendering();
                    break;
                case ViewType.Axonometric:
                    AxonometricRendering();
                    break;
                case ViewType.Perspective:
                    PerspectiveRendering();
                    break;
                case ViewType.Orthogonal:
                    OrthogonalRendering();
                    break;
                case ViewType.Profile:
                    ProfileRendering();
                    break;
                case ViewType.Horizontal:
                    HorizontalRendering();
                    break;
            }
        }

        private void UsualRendering()
        {
            DrawType(ref realPoints, new Points(0,0,1000), false);
        }

        private void OrthogonalRendering()
        {
            DrawType(ref realPoints, new Points(0,0,1000), false);
        }

        private void ProfileRendering()
        {
            Array.Copy(realPoints, transformPoints, realPoints.Length);
            for (var i = 0; i < transformPoints.GetLength(0); i++)
            {
                for (var j = 0; j < transformPoints.GetLength(1); j++)
                {
                    transformPoints[i, j] = transformPoints[i, j].ProfileProjection();
                }
            }
            DrawType(ref transformPoints, new Points(0,0,1000), false);
        }

        private void HorizontalRendering()
        {
            Array.Copy(realPoints, transformPoints, realPoints.Length);
            for (var i = 0; i < transformPoints.GetLength(0); i++)
            {
                for (var j = 0; j < transformPoints.GetLength(1); j++)
                {
                    transformPoints[i, j] = transformPoints[i, j].HorizontalProjection();
                }
            }
            DrawType(ref transformPoints, new Points(0,0,1000), false);
        }

        private void ObliqueRendering()
        {
            ExtensionMethods.CreateObliqueProjectionMatrix(Data.ObliqueL, Data.ObliqueAlpha);
            Array.Copy(realPoints, transformPoints, realPoints.Length);

            for (var i = 0; i < transformPoints.GetLength(0); i++)
            {
                for (var j = 0; j < transformPoints.GetLength(1); j++)
                {
                    transformPoints[i, j] = transformPoints[i, j].ObliqueProjection();
                }
            }
            DrawType(ref transformPoints, new Points(0,0,1000), false);
        }

        private void AxonometricRendering()
        {
            ExtensionMethods.CreateAxonometryProjectionMatrix(Data.AxonometryPhi, Data.AxonometryTheta);
            Array.Copy(realPoints, transformPoints, realPoints.Length);

            for (var i = 0; i < transformPoints.GetLength(0); i++)
            {
                for (var j = 0; j < transformPoints.GetLength(1); j++)
                {
                    transformPoints[i, j] = transformPoints[i, j].AxonometryProjection();
                }
            }
            DrawType(ref transformPoints, new Points(0,0,1000), false);
        }

        private void PerspectiveRendering()
        {
            ExtensionMethods.CreateViewMatrix(Data.PerspectiveTheta, Data.PerspectivePhi, Data.PerspectiveRo);
            Array.Copy(realPoints, transformPoints, realPoints.Length);

            for (var i = 0; i < transformPoints.GetLength(0); i++)
            {
                for (var j = 0; j < transformPoints.GetLength(1); j++)
                {
                    transformPoints[i, j] = transformPoints[i, j].ViewMatrix();
                    //transformPoints[i, j] = transformPoints[i, j].PerspectiveProjection(Data.PerspectiveD);
                }
            }

            Points lp = new Points()
            {
                X = Data.PerspectiveRo * Sin(Data.PerspectivePhi.DegToRad()) * Cos(Data.PerspectiveTheta.DegToRad()),
                Y = Data.PerspectiveRo * Sin(Data.PerspectivePhi.DegToRad()) * Sin(Data.PerspectiveTheta.DegToRad()),
                Z = Data.PerspectiveRo * Cos(Data.PerspectivePhi.DegToRad()),
            };
            DrawType(ref transformPoints, lp, true);
        }

        private void DrawType(ref Points[,] points, Points viewPoint, bool isPerspective)
        {
            switch (Data.DrawType)
            {
                case Enums.DrawType.None:
                    render.PointsRendering(ref points);
                    break;
                case Enums.DrawType.Lines:
                    render.LinesRendering(ref points);
                    break;
                case Enums.DrawType.Polygons:
                    //render.PolygonsRendering(ref points);
                    render.PPolygonsRendering(ref points, viewPoint, isPerspective);
                    break;
            }
        }

        private void CreateCoordinates()
        {
            for (var i = 0; i < approximationBig; i++)
            {
                for (var j = 0; j < approximationSmall; j++)
                {
                    var psi = (double) i * 360 / (approximationBig - 1) - 90;
                    var phi = (double) j * 360 / (approximationSmall - 1) - 90;
                    realPoints[i, j] = new Points
                    {
                        X = (radiusBig + radiusSmall * Cos(psi.DegToRad())) * Cos(phi.DegToRad()),
                        Y = (radiusBig + radiusSmall * Cos(psi.DegToRad())) * Sin(phi.DegToRad()),
                        Z = radiusSmall * Sin(psi.DegToRad())
                    };
                }
            }
        }
    }
}
