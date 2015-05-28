using System;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#ControlPosition
    /// </summary>
    public enum ControlPosition
    {
        /// <summary>
        /// Elements are positioned in the top left and flow towards the middle.
        /// </summary>
        Top_Left = 1,

        /// <summary>
        /// Elements are positioned in the center of the top row.
        /// </summary>
        Top_Center = 2,

        /// <summary>
        /// Elements are positioned in the top right and flow towards the middle.
        /// </summary>
        Top_Right = 3,

        /// <summary>
        /// Elements are positioned in the center of the left side.
        /// </summary>
        Left_Center = 4,

        /// <summary>
        /// Elements are positioned on the left, below top-left elements, and flow downwards.
        /// </summary>
        Left_Top = 5,

        /// <summary>
        /// Elements are positioned on the left, above bottom-left elements, and flow upwards.
        /// </summary>
        Left_Bottom = 6,

        /// <summary>
        /// Elements are positioned on the right, below top-right elements, and flow downwards.
        /// </summary>
        Right_Top = 7,

        /// <summary>
        /// Elements are positioned in the center of the right side.
        /// </summary>
        Right_Center = 8,

        /// <summary>
        /// Elements are positioned on the right, above bottom-right elements, and flow upwards.
        /// </summary>
        Right_Bottom = 9,

        /// <summary>
        /// Elements are positioned in the bottom left and flow towards the middle. Elements are positioned to the right of the Google logo.
        /// </summary>
        Bottom_Left = 10,

        /// <summary>
        /// Elements are positioned in the center of the bottom row.
        /// </summary>
        Bottom_Center = 11,

        /// <summary>
        /// Elements are positioned in the bottom right and flow towards the middle. Elements are positioned to the left of the copyrights.
        /// </summary>
        Bottom_Right = 12,
    }
}