namespace Thoroid
{
    public static class ExtensionMethods
    {
        public static double DegToRad(this double angle)
        {
            return angle * System.Math.PI / 180;
        }
    }
}