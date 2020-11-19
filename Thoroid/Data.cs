using Thoroid.Enums;

namespace Thoroid
{
    public static class Data
    {
        public static DrawTypeEnum DrawType { get; set; } = DrawTypeEnum.Lines;
        public static ViewTypeEnum ViewType { get; set; } = ViewTypeEnum.Usual;
        public static double ObliqueL { get; set; }
        public static double ObliqueAlpha { get; set; }
        public static double AxonometryPhi { get; set; }
        public static double AxonometryTheta { get; set; }
        public static double PerspectiveD { get; set; }
        public static double PerspectivePhi { get; set; }
        public static double PerspectiveTheta { get; set; }
        public static double PerspectiveRo { get; set; }
    }
}