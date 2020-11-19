using Thoroid.Enums;

namespace Thoroid
{
    public static class Data
    {
        public static DrawType DrawType { get; set; } = DrawType.Lines;
        public static ViewType ViewType { get; set; } = ViewType.None;
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