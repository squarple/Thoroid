using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Thoroid.Rendering
{
    public class Rendering
    {
        private readonly Pen pen = new Pen(Color.Blue, 1);

        private static Graphics graph;
        private List<Polygon> coordList;

        public Rendering(ref PictureBox pictureBox)
        {
            graph = pictureBox.CreateGraphics();

            graph.SmoothingMode = SmoothingMode.AntiAlias;
            graph.TranslateTransform((float)pictureBox.Width / 2, (float)pictureBox.Height / 2);
            graph.ScaleTransform(1, -1);
        }

        public void PointsRendering(ref Points[,] points)
        {
            graph.Clear(Color.Transparent);
            var random = new Random();
            foreach (var temp in points)
            {
                using (var newPen = new Pen(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)), 1))
                {
                    graph.DrawEllipse(newPen, (int)temp.X, (int)temp.Y, 1, 1);
                }
            }
        }

        public void LinesRendering(ref Points[,] realPoints)
        {
            graph.Clear(Color.Transparent);

            coordList = new List<Polygon>();
            coordList = CreatePolygons(realPoints);

            foreach (var temp in coordList)
            {
                graph.DrawPolygon(pen, temp.ScreenPoints);
            }
        }

        public void PPolygonsRendering(ref Points[,] points, Points viewPoint, bool isPerspective)
        {
            graph.Clear(Color.Transparent);

            coordList = new List<Polygon>();   //лист полигонов из 4 точек
            coordList = CreatePolygons(points);

            graph.Clear(Color.Transparent);

            //#TODO сортировка
            for (int i = 0; i < coordList.Count - 1; i++)
            {
                for (int j = i + 1; j < coordList.Count; j++)
                {
                    if (coordList[i].midpoint.Z < coordList[j].midpoint.Z)
                    {
                        var temp = coordList[i];
                        coordList[i] = coordList[j];
                        coordList[j] = temp;
                    }
                }
            }

            if (isPerspective)
            {
                foreach (var polygon in coordList)
                {
                    polygon.Points[0] = polygon.Points[0].PerspectiveProjection(Data.PerspectiveD);
                    polygon.Points[1] = polygon.Points[1].PerspectiveProjection(Data.PerspectiveD);
                    polygon.Points[2] = polygon.Points[2].PerspectiveProjection(Data.PerspectiveD);
                    polygon.Points[3] = polygon.Points[3].PerspectiveProjection(Data.PerspectiveD);
                }
            }

            foreach (var p in coordList)
            {
                graph.DrawPolygon(pen, p.ScreenPoints);
                graph.FillPolygon(Brushes.Aquamarine, p.ScreenPoints);
            }
        }

        /*public void PolygonsRendering(ref Points[,] points)
        {
            graph.Clear(Color.Transparent);

            coordList = new List<Polygon>();   //лист полигонов из 4 точек
            coordList = CreatePolygons(points);

            graph.Clear(Color.Transparent);

            Point[] p = new Point[4];
            double[,] arr = new double[coordList.Count, 2];   //массив 
            for (var i = 0; i < coordList.Count; i++)
            {
                double cur = (coordList[i].ZArray[0] + coordList[i].ZArray[1] + coordList[i].ZArray[2] + coordList[i].ZArray[3]) / 4;
                arr[i, 0] = cur;
                arr[i, 1] = i;
            }

            var normAngle = new double[coordList.Count];
            for (var m = 0; m < coordList.Count; m++)
            {
                normAngle[m] = CosNormal(coordList[m]);
            }

            QSort(arr, 0, coordList.Count - 1);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                p[0].X = coordList[(int)arr[i, 1]].Points[0].X;
                p[0].Y = coordList[(int)arr[i, 1]].Points[0].Y;

                p[1].X = coordList[(int)arr[i, 1]].Points[1].X;
                p[1].Y = coordList[(int)arr[i, 1]].Points[1].Y;

                p[2].X = coordList[(int)arr[i, 1]].Points[2].X;
                p[2].Y = coordList[(int)arr[i, 1]].Points[2].Y;

                p[3].X = coordList[(int)arr[i, 1]].Points[3].X;
                p[3].Y = coordList[(int)arr[i, 1]].Points[3].Y;

                //int alpha = Math.Abs((int)(255 * (normAngle[(int)arr[i, 1]])));
                //Color clr = Color.FromArgb(alpha, 55, 100, 120);
                Color clr = Color.FromArgb( 55, 100, 120);
                SolidBrush dr = new SolidBrush(clr);
                graph.FillPolygon(Brushes.Black, p);
                graph.FillPolygon(dr, p);
            }
        }
        private static double CosNormal(Polygon p)
        {
            var coord = new double[3];
            coord[0] = (p.Points[1].Y - p.Points[0].Y) * (p.ZArray[2] - p.ZArray[0]) - (p.ZArray[1] - p.ZArray[0]) * (p.Points[2].Y - p.Points[0].Y);  //координаты нормали по x
            coord[1] = (p.ZArray[1] - p.ZArray[0]) * (p.Points[2].X - p.Points[0].X) - (p.Points[1].X - p.Points[0].X) * (p.ZArray[2] - p.ZArray[0]);  //координаты нормали по y
            coord[2] = (p.Points[1].X - p.Points[0].X) * (p.Points[2].Y - p.Points[0].Y) - (p.Points[1].Y - p.Points[0].Y) * (p.Points[2].X - p.Points[0].X);  //координаты нормали по z
            var cos = coord[2] / (Math.Sqrt(Math.Pow(coord[0], 2) + Math.Pow(coord[1], 2) + Math.Pow(coord[2], 2)));
            return cos;
        }
        //эти 2 ф-ции -- сортировка
        private static void QSort(double[,] facets, int @in, int @out)
        {
            if (@in >= @out)
                return;
            var temp = Partition(facets, @in, @out);
            QSort(facets, @in, temp - 1);
            QSort(facets, temp + 1, @out);
        }
        private static int Partition(double[,] facets, int @in, int @out)
        {
            var marker = @in;
            for (var i = @in; i <= @out; i++)
            {
                if (facets[i, 0] <= facets[@out, 0])
                {
                    double temp = facets[marker, 0];
                    facets[marker, 0] = facets[i, 0];
                    facets[i, 0] = temp;
                    temp = facets[marker, 1];
                    facets[marker, 1] = facets[i, 1];
                    facets[i, 1] = temp;
                    marker++;
                }
            }
            return marker - 1;
        }*/

        private static List<Polygon> CreatePolygons(Points[,] p)
        {
            List<Polygon> list = new List<Polygon>();
            for (var i = 0; i < p.GetLength(0) - 1; i++)
            {
                for (var j = 0; j < p.GetLength(1) - 1; j++)
                {
                    list.Add(new Polygon(p[i, j], p[i, j + 1], p[i + 1, j + 1], p[i + 1, j]));
                }
            }
            return list;
        }
    }
}
