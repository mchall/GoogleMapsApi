using System;
using System.Drawing;

namespace GoogleMapsApi
{
    public static class Helpers
    {
        public static string ConvertToHex(Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }
    }
}