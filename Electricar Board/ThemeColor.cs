﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricar_Board
{
    class ThemeColor
    {
        public static List<string> ColorList = new List<string>() { "#3F51B5",
                                                        "#009688",
                                                        "#FF5722",
                                                        "#607D8B",
                                                        "#FF9800",
                                                        "#9C27B0",
                                                        "#2196F3",
                                                        "#EA676C",
                                                        "#5978BB"
                                                        };
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color. I
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
