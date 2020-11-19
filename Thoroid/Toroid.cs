using System;
using System.Windows.Forms;
using Thoroid.Enums;
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

        private static DrawTypeEnum _drawType = DrawTypeEnum.Lines;
        private static ViewTypeEnum _viewType = ViewTypeEnum.Usual;

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

        private void OrthogonalRendering()
        {
            Array.Copy(realPoints, transformPoints, realPoints.Length);
            for (var i = 0; i < transformPoints.GetLength(0); i++)
            {
                for (var j = 0; j < transformPoints.GetLength(1); j++)
                {
                    transformPoints[i, j] = transformPoints[i, j].OrthogonalProjection();
                }
            }
            DrawType(ref transformPoints);
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
            DrawType(ref transformPoints);
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
            DrawType(ref transformPoints);
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
            DrawType(ref transformPoints);
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
            DrawType(ref transformPoints);
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
                    transformPoints[i, j] = transformPoints[i, j].PerspectiveProjection(Data.PerspectiveD);
                }
            }
            DrawType(ref transformPoints);
        }

        private void DrawFigure()
        {
            switch (_viewType)
            {
                case ViewTypeEnum.Usual:
                    UsualRendering();
                    break;
                case ViewTypeEnum.Oblique:
                    ObliqueRendering();
                    break;
                case ViewTypeEnum.Axonometric:
                    AxonometricRendering();
                    break;
                case ViewTypeEnum.Perspective:
                    PerspectiveRendering();
                    break;
                case ViewTypeEnum.Orthogonal:
                    OrthogonalRendering();
                    break;
                case ViewTypeEnum.Profile:
                    ProfileRendering();
                    break;
                case ViewTypeEnum.Horizontal:
                    HorizontalRendering();
                    break;
            }
        }

        private void UsualRendering()
        {
            DrawType(ref realPoints);
        }

        private void DrawType(ref Points[,] points)
        {
            switch (_drawType)
            {
                case DrawTypeEnum.Points:
                    render.PointsRendering(ref points);
                    break;
                case DrawTypeEnum.Lines:
                    render.LinesRendering(ref points);
                    break;
                case DrawTypeEnum.Polygons:
                    render.PolygonsRendering(ref points);
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

        public static void ChangeDrawType(DrawTypeEnum type)
        {
            _drawType = type;
        }

        public static void ChangeViewType(ViewTypeEnum type)
        {
            _viewType = type;
        }
    }
}
