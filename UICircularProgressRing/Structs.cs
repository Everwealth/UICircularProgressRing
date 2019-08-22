using System;
using ObjCRuntime;

namespace UICircularProgressRing
{
    [Native]
    public enum UICircularProgressRingGradientPosition : ulong
    {
        Top = 1,
        Bottom = 2,
        Left = 3,
        Right = 4,
        TopLeft = 5,
        TopRight = 6,
        BottomLeft = 7,
        BottomRight = 8
    }

    [Native]
    public enum UICircularProgressRingStyle : ulong
    {
        Inside = 1,
        Ontop = 2,
        Dashed = 3,
        Dotted = 4,
        Gradient = 5,
        Bordered = 6
    }
}

