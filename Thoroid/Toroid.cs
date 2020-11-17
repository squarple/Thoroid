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
                    var psi = (double) i * 360 / (approximationBig - 1);
                    var phi = (double) j * 360 / (approximationSmall - 1);
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
