﻿using System.Windows.Forms;
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
        //private Points[,] transformPoints;

        private static DrawTypeEnum _drawType = DrawTypeEnum.Lines;
        private static ViewTypeEnum _viewType = ViewTypeEnum.Usual;

        public Toroid(int approximationBig, int approximationSmall, int radiusBig, int radiusSmall, ref PictureBox picture)
        {
            this.approximationBig = approximationBig;
            this.approximationSmall = approximationSmall;
            this.radiusBig = radiusBig;
            this.radiusSmall = radiusSmall;

            realPoints = new Points[approximationBig, approximationSmall];
            //transformPoints = new Points[approximationBig, approximationSmall];
            CreateCoordinates();

            render = new Rendering.Rendering(ref picture);
        }

        public void Update()
        {
            DrawFigure();
        }

        private void DrawFigure()
        {
            switch (_viewType)
            {
                case ViewTypeEnum.Usual:
                    UsualRendering();
                    break;
                case ViewTypeEnum.Oblique:
                    //ObliqueRendering();
                    break;
                case ViewTypeEnum.Axonometric:
                    //AxonometricRendering();
                    break;
                case ViewTypeEnum.Perspective:
                    //PerpectiveRendering();
                    break;
                case ViewTypeEnum.Orthogonal:
                    //OrthogonalRendering();
                    break;
                case ViewTypeEnum.Profile:
                    //ProfileRendering();
                    break;
                case ViewTypeEnum.Horizontal:
                    //HorizontalRendering();
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
                    //render.PointsRendering(ref points);
                    break;
                case DrawTypeEnum.Lines:
                    render.LinesRendering(ref points);
                    break;
                case DrawTypeEnum.Polygons:
                    //render.PolygonsRendering(ref points);
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

        public void Move(double dX, double dY, double dZ)
        {
            for (var i = 0; i < realPoints.GetLength(0); i++)
            {
                for (var j = 0; j < realPoints.GetLength(1); j++)
                {
                    realPoints[i, j] = Transformations.Move(realPoints[i, j], dX, dY, dZ);
                }
            }
            DrawFigure();
        }

        public void Scale(double sX, double sY, double sZ)
        {
            for (var i = 0; i < realPoints.GetLength(0); i++)
            {
                for (var j = 0; j < realPoints.GetLength(1); j++)
                {
                    realPoints[i, j] = Transformations.Scale(realPoints[i, j], sX, sY, sZ);
                }
            }

            DrawFigure();
        }

        public void Rotate(double thetaX, double thetaY, double thetaZ)
        {
            Transformations.CreateRotateMatrix(thetaX, thetaY, thetaZ);
            for (var i = 0; i < realPoints.GetLength(0); i++)
            {
                for (var j = 0; j < realPoints.GetLength(1); j++)
                {
                    realPoints[i, j] = Transformations.Rotate(realPoints[i, j]);
                }
            }

            DrawFigure();
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
