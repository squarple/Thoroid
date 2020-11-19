using System;

namespace Thoroid.Enums
{
    [Flags]
    public enum ViewType
    {

        None = 0,
        Oblique = 1,
        Axonometric = 2,
        Perspective = 4,
        Orthogonal = 8,
        Profile = 16,
        Horizontal = 32
    }
}